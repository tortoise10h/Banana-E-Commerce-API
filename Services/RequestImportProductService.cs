using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.RequestImportDetail;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.RequestImportProduct;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IRequestImportProductService
    {
        Task<CreateRequestImportProductResult> CreateAsync(
            IEnumerable<RequestImportDetail> requestImportDetails,
            int requestedUserId
        );
        Task<bool> UpdateAsync(RequestImportProduct requestImportProduct);
        Task<RequestImportProduct> GetByIdAsync(int requestImportProductId);
        Task<IEnumerable<RequestImportProduct>> GetAllAsync(
            PaginationFilter pagination,
            GetAllRequestImportProductsFilter filter);
        Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllRequestImportProductsFilter filter);
        Task<CancelRequestImportProductResult> CancelRequestAsync(
            RequestImportProduct requestImportProduct);
    }

    public class RequestImportProductService : IRequestImportProductService
    {
        private readonly DataContext _context;
        private readonly IRequestImportDetailService _requestImportDetailService;

        public RequestImportProductService(
            DataContext context,
            IRequestImportDetailService requestImportDetailService
        )
        {
            _context = context;
            _requestImportDetailService = requestImportDetailService;
        }

        public async Task<CreateRequestImportProductResult> CreateAsync(
            IEnumerable<RequestImportDetail> requestImportDetails,
            int requestedUserId)
        {
            var admin = await _context.Admins
                .SingleOrDefaultAsync(a => a.UserId == requestedUserId);
            RequestImportProduct requestImportProduct = new RequestImportProduct
            {
                CreatedBy = admin.Id,
                CreatedAt = DateTime.UtcNow,
                IsDeleted = false,
                Status = RequestImportProductStatus.Processing
            };

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    /** Create request import product */
                    await _context.RequestImportProducts
                        .AddAsync(requestImportProduct);
                    var requestImportProductCreated = await _context.SaveChangesAsync();
                    if (!(requestImportProductCreated > 0))
                    {
                        transaction.Dispose();
                    }

                    /** Create request import details */
                    // add created RequestImportProduct's Id to each request import detail
                    requestImportDetails
                        .Select(x => x.RequestImportProductId = requestImportProduct.Id)
                        .ToList();

                    // make sure all product tier in request import detail are existed
                    bool areProductTiersInRequestValid = await CheckProductTiersInRequestDetailsAreExistedOrNot(
                        requestImportDetails);
                    if (!areProductTiersInRequestValid)
                    {
                        transaction.Dispose();
                        throw new Exception("Product tier which is requested to import is not existed");
                    }

                    await _context.RequestImportDetails.AddRangeAsync(
                        requestImportDetails
                    );
                    var requestDetailsCreated = await _context.SaveChangesAsync();
                    if (!(requestDetailsCreated > 0))
                    {
                        transaction.Dispose();
                        throw new Exception(
                            "Create request import product error"
                        );
                    }

                    await transaction.CommitAsync();
                }
                catch (System.Exception e)
                {
                    return new CreateRequestImportProductResult
                    {
                        IsSuccess = false,
                        Errors = new[] {
                            e.Message
                        }
                    };
                }
            }

            return new CreateRequestImportProductResult
            {
                IsSuccess = true,
                RequestImportProduct = requestImportProduct
            };
        }

        private async Task<bool> CheckProductTiersInRequestDetailsAreExistedOrNot(
            IEnumerable<RequestImportDetail> requestImportDetails
        )
        {
            /** get all product tier Ids in request import detail list
             * to query to db to check all of them are existed or not
             */
            IEnumerable<int> productTierIdList = requestImportDetails
                .Select(x => x.ProductTierId);
            var productTiers = await _context.ProductTiers
                .Where(pt => productTierIdList.Contains(pt.Id) && pt.IsDeleted == false)
                .ToListAsync();

            /** If the requested product tiers list in db has the same length
            * as the request import detail list => all request product tier in
            * request import detail are existed
            */
            return requestImportDetails.Count() == productTiers.Count();
        }

        private async Task<CreateRequestImportDetailResult> CreateSingleRequestImportDetailAsync(
            RequestImportDetail requestImportDetail)
        {
            var productTier = await _context.ProductTiers
            .Where(pt => pt.Id == requestImportDetail.ProductTierId &&
                pt.IsDeleted == false)
            .Include(pt => pt.Product)
            .FirstOrDefaultAsync();
            if (productTier == null)
            {
                return new CreateRequestImportDetailResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Product tier need to import is not existed" }
                };
            }

            await _context.RequestImportDetails.AddAsync(requestImportDetail);
            var created = await _context.SaveChangesAsync();

            if (!(created > 0))
            {
                return new CreateRequestImportDetailResult
                {
                    IsSuccess = false,
                    Errors = new[] {
                        $"Create request import detail for product {productTier.Product.Name} is not success"
                    }
                };
            }

            return new CreateRequestImportDetailResult
            {
                IsSuccess = true,
                RequestImportDetail = requestImportDetail
            };
        }

        public async Task<RequestImportProduct> GetByIdAsync(int requestImportProductId)
        {
            return await _context.RequestImportProducts
                .Where(x => x.Id == requestImportProductId &&
                    x.IsDeleted == false)
                .Include(rip => rip.RequestImportDetails)
                    .ThenInclude(rid => rid.ProductTier)
                        .ThenInclude(pt => pt.Product)
                            .ThenInclude(p => p.ProductImages)
                .Include(rip => rip.ImportBills)
                    .ThenInclude(ib => ib.ImportBillDetails)
                      .ThenInclude(rid => rid.ProductTier)
                        .ThenInclude(pt => pt.Product)
                            .ThenInclude(p => p.ProductImages)
                .FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateAsync(RequestImportProduct requestImportProduct)
        {
            _context.RequestImportProducts.Update(requestImportProduct);
            var updated = await _context.SaveChangesAsync();

            return updated > 0;
        }

        public async Task<IEnumerable<RequestImportProduct>> GetAllAsync(
            PaginationFilter pagination,
            GetAllRequestImportProductsFilter filter)
        {
            var queryable = _context.RequestImportProducts.AsQueryable();

            queryable = AddFilterOnQuery(filter, queryable);

            var skip = (pagination.PageNumber - 1) * pagination.PageSize;
            return await queryable
                .Skip(skip)
                .Take(pagination.PageSize)
                .Include(rip => rip.RequestImportDetails)
                    .ThenInclude(rid => rid.ProductTier)
                        .ThenInclude(pt => pt.Product)
                            .ThenInclude(p => p.ProductImages)
                .Include(rip => rip.ImportBills)
                    .ThenInclude(ib => ib.ImportBillDetails)
                      .ThenInclude(rid => rid.ProductTier)
                        .ThenInclude(pt => pt.Product)
                            .ThenInclude(p => p.ProductImages)
                .ToListAsync();
        }

        public async Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllRequestImportProductsFilter filter)
        {
            var queryable = _context.RequestImportProducts.AsQueryable();

            queryable = AddFilterOnQuery(filter, queryable);
            return await queryable.CountAsync();
        }

        private IQueryable<RequestImportProduct> AddFilterOnQuery(
            GetAllRequestImportProductsFilter filter,
            IQueryable<RequestImportProduct> queryable
        )
        {
            queryable = queryable.Where(x => x.IsDeleted == false);

            if (filter?.Status != null && filter?.Status != 0)
            {
                queryable = queryable.Where(x => x.Status == filter.Status);
            }

            return queryable;
        }

        public async Task<CancelRequestImportProductResult> CancelRequestAsync(
            RequestImportProduct requestImportProduct)
        {
            /** Only cancel a request when its status is processing */
            if (requestImportProduct.Status != RequestImportProductStatus.Processing)
            {
                return new CancelRequestImportProductResult
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    {
                        "Chỉ được phép huỷ yêu cầu nhập hàng đang trong quá trình xử lý (Processing)"
                    }
                };
            }

            requestImportProduct.Status = RequestImportProductStatus.Canceled;

            _context.RequestImportProducts
                .Update(requestImportProduct);
            var updated = await _context.SaveChangesAsync();

            return new CancelRequestImportProductResult
            {
                IsSuccess = true
            };
        }
    }
}