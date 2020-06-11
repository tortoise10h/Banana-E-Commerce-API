using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IProductExportBillService
    {
        Task<CreateResult<ProductExportBill>> CreateAsync(
            ProductExportBill productExportBill,
            IEnumerable<ProductExportDetail> productExportDetails,
            int requestedUserId
        );

        Task<ProductExportBill> GetByIdAsync(int id);
    }
    public class ProductExportBillService : IProductExportBillService
    {
        private readonly DataContext _context;

        public ProductExportBillService(
            DataContext context
        )
        {
            _context = context;
        }

        /** CREATE ASYNC */
        public async Task<CreateResult<ProductExportBill>> CreateAsync(
            ProductExportBill productExportBill,
            IEnumerable<ProductExportDetail> productExportDetails,
            int requestedUserId)
        {
            try
            {
                var order = await _context.Orders
                    .Where(x => x.Id == productExportBill.OrderId &&
                        x.IsDeleted == false)
                    .Include(x => x.OrderItems)
                    .FirstOrDefaultAsync();

                var productTiers = await GetProductTierListFromProductExportDetails(
                    productExportDetails
                );

                await PrepareProductExportBillInfo(
                    productExportBill,
                    requestedUserId,
                    order);

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        /** Save product export bill */
                        await _context.ProductExportBills.AddAsync(productExportBill);
                        var productExportBillCreated = await _context.SaveChangesAsync();
                        if (!(productExportBillCreated > 0))
                        {
                            transaction.Dispose();
                            throw new Exception("Tạo hoá đơn xuất hàng bị lỗi, xin thử lại");
                        }

                        /** Change status of order to Delivering */
                        order.OrderStatus = OrderStatus.Delivering;

                        _context.Orders.Update(order);
                        var orderUpdated = await _context.SaveChangesAsync();
                        if (!(orderUpdated > 0))
                        {
                            transaction.Dispose();
                            throw new Exception("Tạo hoá đơn xuất hàng bị lỗi, xin thử lại");
                        }

                        /** Save product export details */
                        var createProductExportDetailsResult = await SaveProductExportDetailsWhenCreateProductExportBill(
                            productExportDetails,
                            productExportBill,
                            order.OrderItems,
                            productTiers
                        );
                        if (createProductExportDetailsResult.IsSuccess == false)
                        {
                            transaction.Dispose();
                            return new CreateResult<ProductExportBill>
                            {
                                IsSuccess = false,
                                Errors = createProductExportDetailsResult.Errors
                            };
                        }

                        /** Update product quantity */
                        bool isUpdateProductTiersQuantitySucceeded = await UpdateProductTiersQuantityAfterCreateExportBill(
                            productTiers,
                            productExportDetails
                        );
                        if (!isUpdateProductTiersQuantitySucceeded)
                        {
                            transaction.Dispose();
                            throw new Exception("Tạo hoá đơn xuất hàng bị lỗi, xin thử lại");
                        }

                        await transaction.CommitAsync();
                    }
                    catch (Exception e)
                    {
                        return new CreateResult<ProductExportBill>
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
                return new CreateResult<ProductExportBill>
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    {
                        e.Message.ToString()
                    }
                };
            }


            productExportBill.ProductExportDetails = productExportDetails.ToList();
            return new CreateResult<ProductExportBill>
            {
                IsSuccess = true,
                EntityReturn = productExportBill
            };
        }

        private async Task<IEnumerable<ProductTier>> GetProductTierListFromProductExportDetails(
            IEnumerable<ProductExportDetail> productExportDetails
        )
        {
            var productTierIdsInProductExportDetailList = productExportDetails
                .Select(x => x.ProductTierId);

            var productTiers = await _context.ProductTiers
                .Where(pt => productTierIdsInProductExportDetailList.Contains(pt.Id))
                .Include(pt => pt.Product)
                .Include(pt => pt.Tier)
                .ToListAsync();

            return productTiers;
        }

        private async Task PrepareProductExportBillInfo(
            ProductExportBill productExportBill,
            int requestedUserId,
            Order order
        )
        {
            var storageManager = await _context.StorageManagers
                .SingleOrDefaultAsync(x => x.UserId == requestedUserId);
            if (storageManager == null)
            {
                throw new Exception("Bạn không có quyền để xuất hoá đơn này");
            }

            var validateOrderResult = ValidateValidOrderOfProductExportBill(
                order);
            if (validateOrderResult.IsSuccess == false)
            {
                throw new Exception(validateOrderResult.Errors[0]);
            }

            productExportBill.IsDeleted = false;
            productExportBill.CreatedAt = DateTime.UtcNow;
            productExportBill.UpdatedAt = DateTime.UtcNow;
            productExportBill.StorageManagerId = storageManager.Id;
        }

        private CheckValidResult ValidateValidOrderOfProductExportBill(
            Order order
        )
        {
            if (order == null)
            {
                return new CheckValidResult
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    {
                        "Hoá đơn xuất hàng này danh cho đơn hàng không tồn tại"
                    }
                };
            }

            /** Only allow to create product export bill for order that has status Processing */
            if (order.OrderStatus != OrderStatus.Processing)
            {
                return new CheckValidResult
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    {
                        "Không thể tạo hoá đơn xuất cho đơn hàng này nữa"
                    }
                };
            }

            return new CheckValidResult
            {
                IsSuccess = true
            };
        }

        private async Task<CreateResult<IEnumerable<ProductExportDetail>>> SaveProductExportDetailsWhenCreateProductExportBill(
            IEnumerable<ProductExportDetail> productExportDetails,
            ProductExportBill productExportBill,
            IEnumerable<OrderItem> orderItems,
            IEnumerable<ProductTier> productTiers
        )
        {
            var validateProductExportDetailsResult = ValidateProductExportDetails(
                productExportDetails,
                orderItems,
                productTiers
            );
            if (validateProductExportDetailsResult.IsSuccess == false)
            {
                return new CreateResult<IEnumerable<ProductExportDetail>>
                {
                    IsSuccess = false,
                    Errors = validateProductExportDetailsResult.Errors
                };
            }

            PrepareInfoForAllProductExportDetails(
                productExportDetails,
                productExportBill.Id,
                orderItems
            );

            /** Save to db */
            await _context.ProductExportDetails.AddRangeAsync(productExportDetails);
            var created = await _context.SaveChangesAsync();

            if (!(created > 0))
            {
                return new CreateResult<IEnumerable<ProductExportDetail>>
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    {
                        "Tạo hoá đơn xuất kho bị lỗi, xin thử lại"
                    }
                };
            }

            return new CreateResult<IEnumerable<ProductExportDetail>>
            {
                IsSuccess = true
            };

        }

        private CheckValidResult ValidateProductExportDetails(
            IEnumerable<ProductExportDetail> productExportDetails,
            IEnumerable<OrderItem> orderItems,
            IEnumerable<ProductTier> productTiers
        )
        {
            List<string> errors = new List<string>();

            bool areAllProductTiersInProductExportDetailsExist = ValidateProductTiersInProductExportDetailListAllExist(
                productExportDetails,
                productTiers
            );
            if (!areAllProductTiersInProductExportDetailsExist)
            {
                return new CheckValidResult
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    {
                        "Danh sách sản phẩm trong hoá đơn xuất không hợp lệ"
                    }
                };
            }

            var checkQuantityOfProductExportDetailListResult = ValidateQuantityOfProductExportDetails(
                productExportDetails,
                productTiers
            );
            if (checkQuantityOfProductExportDetailListResult.IsSuccess == false)
            {
                return new CheckValidResult
                {
                    IsSuccess = false,
                    Errors = checkQuantityOfProductExportDetailListResult.Errors
                };
            }


            bool isSuccess = true;
            /** Loop through product export detail list and check
             * if there is any product tier id in product export detail list
             * doesn't exist in order item list  => product export detail does not match
             * product in order item */
            foreach (var productExportDetail in productExportDetails)
            {
                var orderItem = orderItems
                    .SingleOrDefault(x => x.ProductTierId == productExportDetail.ProductTierId);

                if (orderItem == null)
                {
                    isSuccess = false;
                    errors.Add(
                        $"Sản phẩm với id = {productExportDetail.ProductTierId} không có trong yêu cầu đơn hàng"
                    );
                };
            }

            if (!isSuccess)
            {
                return new CheckValidResult
                {
                    IsSuccess = false,
                    Errors = errors
                };
            }

            return new CheckValidResult
            {
                IsSuccess = true
            };
        }

        private bool ValidateProductTiersInProductExportDetailListAllExist(
            IEnumerable<ProductExportDetail> productExportDetails,
            IEnumerable<ProductTier> productTiers
        )
        {
            return productTiers.Count() == productExportDetails.Count();
        }

        private CheckValidResult ValidateQuantityOfProductExportDetails(
            IEnumerable<ProductExportDetail> productExportDetails,
            IEnumerable<ProductTier> productTiers
        )
        {
            List<string> errors = new List<string>();
            bool isSuccess = true;

            foreach (var exportDetail in productExportDetails)
            {
                var productTier = productTiers
                    .SingleOrDefault(pt => pt.Id == exportDetail.ProductTierId);

                if (exportDetail.Quantity > productTier.Quantity)
                {
                    isSuccess = false;
                    errors.Add(
                        $"Số lượng xuất kho của sản phẩm '{productTier.Product.Name}' loại {productTier.Tier.TierOption} là {exportDetail.Quantity} lớn hơn số lượng còn lại trong kho là: {productTier.Quantity}"
                    );
                }
            }

            if (!isSuccess)
            {
                return new CheckValidResult
                {
                    IsSuccess = false,
                    Errors = errors
                };
            }

            return new CheckValidResult
            {
                IsSuccess = true
            };
        }

        private void PrepareInfoForAllProductExportDetails(
            IEnumerable<ProductExportDetail> productExportDetails,
            int productExportBillId,
            IEnumerable<OrderItem> orderItems
        )
        {
            foreach (var exportDetail in productExportDetails)
            {
                /** Get order item which has the same productTierId to get price */
                var orderItem = orderItems
                    .SingleOrDefault(x => x.ProductTierId == exportDetail.ProductTierId);

                exportDetail.ExportBillId = productExportBillId;
                exportDetail.Price = orderItem.SinglePrice;
            }
        }

        private async Task<bool> UpdateProductTiersQuantityAfterCreateExportBill(
            IEnumerable<ProductTier> productTiers,
            IEnumerable<ProductExportDetail> productExportDetails
        )
        {
            /** Decrease product tiers quantity base on produdt export detail list */
            foreach (var productTier in productTiers)
            {
                var matchProductExportDetail = productExportDetails
                    .SingleOrDefault(x => x.ProductTierId == productTier.Id);

                productTier.Quantity = productTier.Quantity - matchProductExportDetail.Quantity;
            }

            /** Save to db */
            _context.ProductTiers.UpdateRange(productTiers);
            var updated = await _context.SaveChangesAsync();

            return updated > 0;
        }


        /** GET BY ID ASYNC */
        public async Task<ProductExportBill> GetByIdAsync(int id)
        {
            return await _context.ProductExportBills
                .Where(peb => peb.Id == id)
                .Include(peb => peb.ProductExportDetails)
                    .ThenInclude(ped => ped.ProductTier)
                        .ThenInclude(pt => pt.Product)
                            .ThenInclude(p => p.ProductImages)
                .Include(o => o.Order)
                    .ThenInclude(o => o.OrderItems)
                        .ThenInclude(oi => oi.ProductTier)
                            .ThenInclude(pt => pt.Product)
                                .ThenInclude(p => p.ProductImages)
                .FirstOrDefaultAsync();
        }
    }
}