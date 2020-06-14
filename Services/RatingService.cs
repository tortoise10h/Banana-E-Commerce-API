using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Rating;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IRatingService
    {
        Task<Rating> GetByIdAsync(int id);
        Task<CreateRatingResult> CreateAsync(
            Rating rating, 
            int userId,
            IEnumerable<IFormFile> images,
            string ratingImageDir,
            string appRootDir
        );
        Task<IEnumerable<Rating>> GetAllAsync(
            PaginationFilter pagination,
            GetAllRatingFilter filter = null);
        Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllRatingFilter filter = null
        );
        Task<bool> IsCustomerOwnRating(int userId, int ratingId);
        Task<bool> UpdateAsync(Rating rating);
        Task<bool> DeleteAsync(int ratingId);
    }

    public class RatingService : IRatingService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IRatingImageService _ratingImageService;

        public RatingService(
            DataContext context,
            IMapper mapper,
            IRatingImageService ratingImageService
        )
        {
           _context = context;
            _mapper = mapper;
            _ratingImageService = ratingImageService;
        }

        public async Task<IEnumerable<Rating>> GetAllAsync(
            PaginationFilter pagination,
            GetAllRatingFilter filter = null
        )
        {
            var queryable = _context.Rates.AsQueryable();

            queryable = AddFilterOnQuery(filter, queryable);

            var skip = (pagination.PageNumber - 1) * pagination.PageSize;
            return await queryable
                .Where(r => r.IsDeleted == false)
                .Include(r => r.RatingImages)
                .Include(r => r.Customer)
                .Include(pdf => pdf.ProductTier)
                    .ThenInclude(pt => pt.Product)
                        .ThenInclude(p => p.ProductImages)
                .Skip(skip)
                .Take(pagination.PageSize)
                .ToListAsync();
        }

        public async Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllRatingFilter filter = null
        )
        {
            var queryable = _context.Rates.AsQueryable();

            queryable = queryable.Where(x => x.IsDeleted == false);
            queryable = AddFilterOnQuery(filter, queryable);
            return await queryable.CountAsync();
        }

        public async Task<Rating> GetByIdAsync(int id)
        {
            return await _context.Rates
                .Where(r => r.Id == id && r.IsDeleted == false)
                .Include(r => r.RatingImages)
                .Include(c => c.Customer)
                .Include(pdf => pdf.ProductTier)
                    .ThenInclude(pt => pt.Product)
                        .ThenInclude(p => p.ProductImages)
                .FirstOrDefaultAsync();
        }

        public async Task<CreateRatingResult> CreateAsync(
            Rating rating, 
            int userId,
            IEnumerable<IFormFile> images,
            string ratingImageDir,
            string appRootDir
        )
        {
            var prepareRatingInfoResult = await PrepareNewRating(
                rating,
                userId
            );
            if (prepareRatingInfoResult.IsSuccess == false)
            {
                return new CreateRatingResult
                {
                    IsSuccess = false,
                    Errors = prepareRatingInfoResult.Errors
                };
            }

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    /** Create rating */
                    await _context.Rates.AddAsync(rating);
                    var created = await _context.SaveChangesAsync();
                    if (!(created > 0))
                    {
                        transaction.Dispose();
                        throw new Exception("Có lỗi khi tạo rating mới, vui lòng thử lại");
                    }

                    /** Create Images of rating */
                    // only work if images are existed
                    bool isUploadImageSuccess = await UploadImagesWhenCreateRating(
                        images,
                        appRootDir,
                        ratingImageDir,
                        rating.Id,
                        rating.ProductTierId
                    );
                    if (isUploadImageSuccess == false)
                    {
                        transaction.Dispose();
                        throw new Exception("Có lỗi khi tạo rating mới, vui lòng thử lại");
                    }

                    await transaction.CommitAsync();
                }
                catch (Exception e)
                {
                    return new CreateRatingResult
                    {
                        IsSuccess = false,
                        Errors = new[] { e.Message.ToString() }
                    };
                }
            }
            var createdRating = await GetByIdAsync(rating.Id);

            return new CreateRatingResult
            {
                IsSuccess = true,
                Rating = createdRating
            };
        }

        private async Task<PrepareRatingInfoResult> PrepareNewRating(
            Rating rating,
            int userId
        )
        {
            var createdByCustomer = await _context.Customers.SingleOrDefaultAsync(c => c.UserId == userId);
            var productRating = await _context.ProductTiers.SingleOrDefaultAsync(pt => pt.Id == rating.ProductTierId);

            var isCustomerOrder = await _context.Orders.Where(
                o => o.CustomerId == createdByCustomer.Id
            ).FirstOrDefaultAsync();

            var isItemOrder = await _context.OrderItems.Where(
                io => io.ProductTierId == rating.ProductTierId  
            ).FirstOrDefaultAsync();

            var currentRating = await _context.Rates.Where(
                r => r.CustomerId == createdByCustomer.Id &&
                r.ProductTierId == rating.ProductTierId
            ).FirstOrDefaultAsync();

            if (productRating == null)
            {
                return new PrepareRatingInfoResult
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    { "Sản phẩm này không tồn tại" }
                };
            }

            if (isCustomerOrder == null || isItemOrder == null)
            {
                return new PrepareRatingInfoResult
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    { "Bạn phải mua hàng trước khi đánh giá" }
                };
            }

            if (currentRating != null)
            {
                return new PrepareRatingInfoResult
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    { "Bạn đã đánh giá sản phẩm này rồi" }
                };
            }

            rating.CreatedAt = DateTime.UtcNow;
            rating.UpdatedAt = DateTime.UtcNow;
            rating.IsDeleted = false;
            rating.CustomerId = createdByCustomer.Id;
            
           return new PrepareRatingInfoResult
            {
                IsSuccess = true,
                Rating = rating
            };
        }

        private async Task<bool> UploadImagesWhenCreateRating(
            IEnumerable<IFormFile> images,
            string appRootDir,
            string ratingImageDir,
            int ratingId,
            int productTierId
        )
        {
            if (images != null && images.Count() > 0)
            {
                var createRatingImageResult = await _ratingImageService
                    .UploadMultipleRatingImages(
                        appRootDir,
                        ratingImageDir,
                        ratingId,
                        productTierId,
                        images
                    );

                return createRatingImageResult.IsSuccess;
            }

            return true;
        }

        public async Task<bool> UpdateAsync(Rating rating)
        {
            _context.Rates.Update(rating);
            var updated = await _context.SaveChangesAsync();

            return updated > 0;
        }

        public async Task<bool> DeleteAsync(int ratingId)
        {
            var rating = await _context.Rates.SingleOrDefaultAsync(a => a.Id == ratingId);

            if (rating == null)
            {
                return false;
            }

            rating.IsDeleted = true;
            _context.Rates.Update(rating);
            var deleted = await _context.SaveChangesAsync();

            return deleted > 0;
        }

        private IQueryable<Rating> AddFilterOnQuery(
            GetAllRatingFilter filter,
            IQueryable<Rating> queryable
        )
        {
            queryable = queryable.Where(x => x.IsDeleted == false);

            if (filter?.ProductId > 0)
            {
                queryable = queryable.Where(x => x.ProductTier.ProductId == filter.ProductId);
            }

            return queryable;
        }

        public async Task<bool> IsCustomerOwnRating(int userId, int ratingId)
        {
            var customer = await _context.Customers.SingleOrDefaultAsync(c => c.UserId == userId);
            var validateRating = await _context.Rates
                .Where(a => a.Id == ratingId &&
                    a.CustomerId == customer.Id)
                .FirstOrDefaultAsync();
        
            if (validateRating == null)
            {
                return false;
            }

            return true;
        }
    }
}