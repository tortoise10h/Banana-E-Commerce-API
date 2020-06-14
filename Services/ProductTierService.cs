using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTier;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IProductTierService
    {
        Task<CreateProductTierResult> CreateAsync(
            ProductTier productTier
        );
        Task<UpdateProductTierResult> UpdateAsync(ProductTier productTier);
        Task<IEnumerable<ProductTier>> GetAllAsync(
            PaginationFilter pagination,
            GetAllProductTiersFilter filter = null);
        Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllProductTiersFilter filter = null
        );
        Task<ProductTier> GetByIdAsync(int productTierId);
    }

    public class ProductTierService : IProductTierService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ProductTierService(
            DataContext context,
            IMapper mapper
        )
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CreateProductTierResult> CreateAsync(ProductTier productTier)
        {
            productTier.IsDeleted = false;
            productTier.CreatedAt = DateTime.UtcNow;
            productTier.UpdatedAt = DateTime.UtcNow;

            await _context.ProductTiers.AddAsync(productTier);
            var created = await _context.SaveChangesAsync();

            if (!(created > 0))
            {
                return new CreateProductTierResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Có lỗi khi tạo sản phẩm mới, vui lòng thử lại" }
                };
            }

            return new CreateProductTierResult
            {
                IsSuccess = true
            };
        }

        public async Task<ProductTier> GetByIdAsync(int productTierId)
        {
            return await _context.ProductTiers
                .Where(p => p.Id == productTierId)
                .Include(pt => pt.Product)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ProductTier>> GetAllAsync(
            PaginationFilter pagination,
            GetAllProductTiersFilter filter = null)
        {
            var queryable = _context.ProductTiers.AsQueryable();

            queryable = AddFilterOnQuery(filter, queryable);

            var skip = (pagination.PageNumber - 1) * pagination.PageSize;
            return await queryable
                .Skip(skip)
                .Take(pagination.PageSize)
                .Include(pt => pt.Product)
                .ToListAsync();
        }
        public async Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllProductTiersFilter filter = null
        )
        {
            var queryable = _context.ProductTiers.AsQueryable();

            queryable = queryable.Where(x => x.IsDeleted == false);
            queryable = AddFilterOnQuery(filter, queryable);
            return await queryable.CountAsync();
        }
        

        public async Task<UpdateProductTierResult> UpdateAsync(ProductTier productTier)
        {
            var currentPricePerKg = await _context.ProductTiers
                .FirstOrDefaultAsync(pt => pt.Id == productTier.Id && pt.PricePerKg == productTier.PricePerKg);

            var currentKgSale = await _context.ProductTiers
                .FirstOrDefaultAsync(pt => pt.Id == productTier.Id && pt.KgSale == productTier.KgSale);

            var currentDiscountPercentage = await _context.ProductTiers
                .FirstOrDefaultAsync(pt => pt.Id == productTier.Id 
                                    && pt.DiscountPercentage == productTier.DiscountPercentage);
            
            if (currentPricePerKg == null || currentKgSale == null || currentDiscountPercentage == null)
            {
                productTier.SalePrice = Math.Floor(productTier.PricePerKg * productTier.KgSale);
                productTier.AfterDiscountPrice = CalculateAfterDiscountPrice(
                    productTier.SalePrice,
                    productTier.DiscountPercentage
                );
            }

            _context.ProductTiers.Update(productTier);
            var updated = await _context.SaveChangesAsync();

            return new UpdateProductTierResult
                {
                    IsSuccess = true,
                };
        }

        public double CalculateAfterDiscountPrice(double originalPrice, int discountPercentage)
        {
            double discountPrice = (originalPrice * discountPercentage) / 100;
            double afterDiscountPrice = Math.Floor(originalPrice - discountPrice);

            return afterDiscountPrice;
        }

        private IQueryable<ProductTier> AddFilterOnQuery(
            GetAllProductTiersFilter filter,
            IQueryable<ProductTier> queryable
        )
        {
            queryable = queryable.Where(x => x.IsDeleted == false);

            if (filter?.ProductId > 0)
            {
                queryable = queryable.Where(x => x.ProductId == filter.ProductId);
            }

            if (filter?.TierId > 0)
            {
                queryable = queryable.Where(x => x.TierId == filter.TierId);
            }

            if (filter?.Quantity > 0)
            {
                queryable = queryable.Where(x => x.Quantity == filter.Quantity);
            }

            if (filter?.DiscountPercentage > 0)
            {
                queryable = queryable.Where(x => x.DiscountPercentage == filter.DiscountPercentage);
            }

            if (filter?.AfterDiscountPrice > 0)
            {
                queryable = queryable.Where(x => x.AfterDiscountPrice == filter.AfterDiscountPrice);
            }

            return queryable;
        }
    }
}