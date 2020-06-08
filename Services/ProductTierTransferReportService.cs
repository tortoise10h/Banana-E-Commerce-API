using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTierTransferReport;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IProductTierTransferReportService
    {
        Task<CreateResult<ProductTierTransferReport>> CreateAsync(
            ProductTierTransferReport productTierTransferReport,
            int requestedUserId
        );
        Task<ProductTierTransferReport> GetByIdAsync(int id);
        Task<IEnumerable<ProductTierTransferReport>> GetAllAsync(
            PaginationFilter pagination,
            GetAllProductTierTransferReportsFilter filter);
        Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllProductTierTransferReportsFilter filter);
        Task<IEnumerable<CreateResult<ProductTierTransferReport>>> BulkCreateAsync(
            IEnumerable<ProductTierTransferReport> productTierTransferReports,
            int requestedUserId);
        Task<bool> DeleteAsync(ProductTierTransferReport productTierTransferReport);
    }

    public class ProductTierTransferReportService : IProductTierTransferReportService
    {
        private readonly DataContext _context;

        public ProductTierTransferReportService(
            DataContext context
        )
        {
            _context = context;
        }

        /** CREATE ASYNC */
        public async Task<CreateResult<ProductTierTransferReport>> CreateAsync(
            ProductTierTransferReport productTierTransferReport,
            int requestedUserId)
        {
            try
            {
                await PrepareProductTierTransferReportInfo(
                    productTierTransferReport,
                    requestedUserId);

                /** Get both source (fromTierId) and destination (toTierId)
                 * from db to validate */
                var productTier1 = await _context.ProductTiers
                    .Where(pt => pt.Id == productTierTransferReport.FromTierId)
                    .Include(pt => pt.Tier)
                    .FirstOrDefaultAsync();
                var productTier2 = await _context.ProductTiers
                    .Where(pt => pt.Id == productTierTransferReport.ToTierId)
                    .Include(pt => pt.Tier)
                    .FirstOrDefaultAsync();

                /** Validate both source and destination product tier */
                AreSourceAndDestinationProductTierValid(
                    productTier1,
                    productTier2,
                    productTierTransferReport.Quantity);

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        /** Update product tier quantity */
                        bool isUpdateProductTiersQuantitySuccess = await UpdateSourceAndDestinationProductTiersQuantity(
                            productTier1,
                            productTier2,
                            productTierTransferReport.Quantity
                        );
                        if (isUpdateProductTiersQuantitySuccess == false)
                        {
                            transaction.Dispose();
                            throw new Exception("Chuyển số lượng sản từ loại 1 sang loại 2 có lỗi, xin thử lại!");
                        }

                        /** Create product tier transfer report */
                        await _context.ProductTierTransferReports.AddAsync(productTierTransferReport);
                        var created = await _context.SaveChangesAsync();
                        if (!(created > 0))
                        {
                            transaction.Dispose();
                            throw new Exception("Chuyển số lượng sản từ loại 1 sang loại 2 có lỗi, xin thử lại!");
                        }

                        await transaction.CommitAsync();
                    }
                    catch (Exception e)
                    {
                        return new CreateResult<ProductTierTransferReport>
                        {
                            IsSuccess = false,
                            Errors = new List<string>()
                            {
                                e.Message.ToString()
                            }
                        };
                    }
                }
            }
            catch (Exception e)
            {
                return new CreateResult<ProductTierTransferReport>
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    {
                        e.Message.ToString()
                    }
                };
            }

            return new CreateResult<ProductTierTransferReport>
            {
                IsSuccess = true,
                EntityReturn = productTierTransferReport
            };
        }

        private async Task PrepareProductTierTransferReportInfo(
            ProductTierTransferReport productTierTransferReport,
            int requestedUserId
        )
        {
            var storageManager = await _context.StorageManagers
                .SingleOrDefaultAsync(sm => sm.UserId == requestedUserId);

            productTierTransferReport.CreatedAt = DateTime.UtcNow;
            productTierTransferReport.CreatedBy = storageManager.Id;
            productTierTransferReport.IsDeleted = false;
            // rounded transfer quantity to 2 decimal place to avoid
            // awkward quantity number
            productTierTransferReport.Quantity = Math.Round(
                productTierTransferReport.Quantity,
                2,
                MidpointRounding.AwayFromZero);
        }

        private void AreSourceAndDestinationProductTierValid(
            ProductTier productTier1,
            ProductTier productTier2,
            double transferQuantity
        )
        {
            try
            {
                /** validate source and destination has to be the same product */
                if (productTier1.ProductId != productTier2.ProductId)
                {
                    throw new Exception(
                        @"Sản phẩm cần chuyển và sản phẩm nhận không cùng chung một loại sản phẩm"
                    );
                }

                CheckValidSourceProductTier(productTier1, transferQuantity);
                CheckValidDestinationProductTier(productTier2);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CheckValidSourceProductTier(
            ProductTier productTier1,
            double transferQuantity
        )
        {
            if (productTier1 == null || productTier1.IsDeleted == true)
            {
                throw new Exception(
                    $"Sản phẩm với id = {productTier1.Id} không tồn tại"
                );
            }

            /** Only allow to transfer from tier 1 to tier 2 */
            if (productTier1.Tier.TierOption != TierEnum.tier1)
            {
                throw new Exception(
                    "Chỉ cho phép chuyển số lượng từ sản phẩm loại 1"
                );
            }

            /** Check valid quantity */
            if (transferQuantity > productTier1.Quantity)
            {
                throw new Exception(
                    $"Số lượng yêu cầu chuyển ({transferQuantity}) lớn hơn số lượng hiện có của sản phẩm ({productTier1.Quantity})"
                );
            }
        }

        private void CheckValidDestinationProductTier(
            ProductTier productTier2
        )
        {
            if (productTier2 == null || productTier2.IsDeleted == true)
            {
                throw new Exception(
                    $"Sản phẩm với id = {productTier2.Id} không tồn tại"
                );
            }

            /** Only allow to transfer from tier 1 to tier 2 */
            if (productTier2.Tier.TierOption != TierEnum.tier2)
            {
                throw new Exception(
                    "Chỉ cho phép chuyển số lượng từ sản phẩm loại 1 sang loại 2"
                );
            }
        }

        private async Task<bool> UpdateSourceAndDestinationProductTiersQuantity(
            ProductTier productTier1,
            ProductTier productTier2,
            double transferQuantity
        )
        {
            /** calculate new quantity */
            productTier1.Quantity = productTier1.Quantity - transferQuantity;
            productTier2.Quantity = productTier2.Quantity + transferQuantity;

            /** Update to Database */
            _context.ProductTiers.UpdateRange(
                new List<ProductTier>()
                {
                    productTier1,
                    productTier2
                }
            );
            var updated = await _context.SaveChangesAsync();

            return updated > 0;
        }

        /** GET BY ID ASYNC */
        public async Task<ProductTierTransferReport> GetByIdAsync(int id)
        {
            return await _context.ProductTierTransferReports
                .Where(pttr => pttr.Id == id &&
                    pttr.IsDeleted == false)
                .Include(pttr => pttr.ProductTier)
                    .ThenInclude(pt => pt.Product)
                .Include(pttr => pttr.StorageManager)
                .FirstOrDefaultAsync();
        }



        /** BULK CREATE */
        public async Task<IEnumerable<CreateResult<ProductTierTransferReport>>> BulkCreateAsync(
            IEnumerable<ProductTierTransferReport> productTierTransferReports,
            int requestedUserId)
        {
            using (DataContext db = new DataContext())
            {

                List<Task<CreateResult<ProductTierTransferReport>>> listOfCreateAsyncMethod = new List<Task<CreateResult<ProductTierTransferReport>>>();
                foreach (var productTierTransferReport in productTierTransferReports)
                {
                    listOfCreateAsyncMethod.Add(
                        CreateAsync(
                            productTierTransferReport,
                            requestedUserId
                        )
                    );
                }

                var result = await Task.WhenAll<CreateResult<ProductTierTransferReport>>(
                    listOfCreateAsyncMethod);

                return result;
            }

        }


        /** GET ALL ASYNC */
        public async Task<IEnumerable<ProductTierTransferReport>> GetAllAsync(
            PaginationFilter pagination,
            GetAllProductTierTransferReportsFilter filter)
        {
            var queryable = _context.ProductTierTransferReports.AsQueryable();

            queryable = AddFilterOnQuery(filter, queryable);

            var skip = (pagination.PageNumber - 1) * pagination.PageSize;
            return await queryable
                .Skip(skip)
                .Take(pagination.PageSize)
                    .Include(pttr => pttr.ProductTier)
                        .ThenInclude(pt => pt.Product)
                    .Include(pttr => pttr.StorageManager)
                .ToListAsync();
        }

        public async Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllProductTierTransferReportsFilter filter)
        {
            var queryable = _context.ProductTierTransferReports.AsQueryable();

            queryable = AddFilterOnQuery(filter, queryable);
            return await queryable.CountAsync();
        }

        private IQueryable<ProductTierTransferReport> AddFilterOnQuery(
            GetAllProductTierTransferReportsFilter filter,
            IQueryable<ProductTierTransferReport> queryable
        )
        {
            queryable = queryable.Where(x => x.IsDeleted == false);

            if (filter?.FromQuantity != null)
            {
                queryable = queryable.Where(x => x.Quantity >= filter.FromQuantity);
            }

            if (filter?.ToQuantity != null && filter?.ToQuantity > 0)
            {
                queryable = queryable.Where(x => x.Quantity <= filter.ToQuantity);
            }

            if (filter?.FromTierId != null && filter?.FromTierId > 0)
            {
                queryable = queryable.Where(x => x.FromTierId == filter.FromTierId);
            }

            if (filter?.ToTierId != null && filter?.ToTierId > 0)
            {
                queryable = queryable.Where(x => x.Quantity == filter.ToTierId);
            }


            return queryable;
        }



        /** DELETE ASYNC */
        public async Task<bool> DeleteAsync(
            ProductTierTransferReport productTierTransferReport)
        {
            var productTier1 = await _context.ProductTiers
                .SingleOrDefaultAsync(x => x.Id == productTierTransferReport.FromTierId);
            var productTier2 = await _context.ProductTiers
                .SingleOrDefaultAsync(x => x.Id == productTierTransferReport.ToTierId);

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    /** Reverse transfer quantity back */
                    productTier1.Quantity = productTier1.Quantity + productTierTransferReport.Quantity;
                    productTier2.Quantity = productTier2.Quantity - productTierTransferReport.Quantity;
                    _context.ProductTiers.UpdateRange(
                        new List<ProductTier>()
                        {
                            productTier1,
                            productTier2
                        }
                    );
                    var productTierUpdated = await _context.SaveChangesAsync();
                    if (!(productTierUpdated > 0))
                    {
                        return false;
                    }

                    /** Delete product tier transfer report */
                    _context.ProductTierTransferReports.Remove(productTierTransferReport);
                    var deleted = await _context.SaveChangesAsync();
                    if (!(deleted > 0))
                    {
                        return false;
                    }

                    await transaction.CommitAsync();
                }
                catch (Exception)
                {
                    return false;
                }
            }

            return true;
        }
    }
}