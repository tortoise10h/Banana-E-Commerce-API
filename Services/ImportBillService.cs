using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ImportBill;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IImportBillService
    {
        Task<CreateImportBillResult> CreateAsync(
            ImportBill importBill,
            IEnumerable<ImportBillDetail> importBillDetails,
            int requestedUserId,
            IFormFile supplierBillImage,
            IFormFile storageManagerBillImage,
            string importBillImageDir,
            string rootDir
        );
        Task<ImportBill> GetByIdAsync(
            int importBillId
        );
    }

    public class ImportBillService : IImportBillService
    {
        private readonly DataContext _context;
        private readonly IUploadImageService _uploadImageService;

        public ImportBillService(
            DataContext context,
            IUploadImageService uploadImageService
        )
        {
            _context = context;
            _uploadImageService = uploadImageService;
        }

        public async Task<CreateImportBillResult> CreateAsync(
            ImportBill importBill,
            IEnumerable<ImportBillDetail> importBillDetails,
            int requestedUserId,
            IFormFile supplierBillImage,
            IFormFile storageManagerBillImage,
            string importBillImageDir,
            string rootDir)
        {
            /** get storage manager to get id from him/her */
            var storageManager = await _context.StorageManagers
                .SingleOrDefaultAsync(sm => sm.UserId == requestedUserId);
            if (storageManager == null)
            {
                return new CreateImportBillResult
                {
                    IsSuccess = false,
                    Errors = new List<string> { "Thủ kho không tồn tại" }
                };
            }

            /** Get storage to get Id - temporary handle for only one storage business */
            var storage = await _context.Storages
                .FirstOrDefaultAsync();

            /** Prepare default data for import bill */
            importBill.Currency = PriceCurrency.VND;
            importBill.TotalAmount = CalculateTotalAmountInImportBillDetails(importBillDetails);
            importBill.Code = Regex.Replace(
                Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "");
            importBill.CreatedAt = DateTime.UtcNow;
            importBill.UpdatedAt = DateTime.UtcNow;
            importBill.IsDeleted = false;
            importBill.StorageId = storage.Id;
            importBill.StorageManagerId = storageManager.Id;

            /** Validate Import Bill Detail Products */
            var importBillDetailValidationResult = await CheckValidImportBillDetail(
                importBillDetails,
                importBill.RequestImportProductId
            );
            if (importBillDetailValidationResult.IsSuccess == false)
            {
                return new CreateImportBillResult
                {
                    IsSuccess = false,
                    Errors = importBillDetailValidationResult.Errors
                };
            }

            /** Handle upload image and put image links to new ImportBill*/
            var uploadSupplierBillImageResult = await _uploadImageService
                .UploadSingleImage(
                    rootDir,
                    importBillImageDir,
                    supplierBillImage
                );
            var uploadStorageManagerBillImageResult = await _uploadImageService
                .UploadSingleImage(
                    rootDir,
                    importBillImageDir,
                    supplierBillImage
                );

            importBill.SupplierBillImageLocation = uploadSupplierBillImageResult?.ImageLocation;
            importBill.StorageManagerBillImageLocation = uploadStorageManagerBillImageResult?.ImageLocation;

            /** Save import bill and import bill detail */
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    /** Save Import Bill */
                    await _context.ImportBills.AddAsync(importBill);
                    var importBillCreated = await _context.SaveChangesAsync();
                    if (!(importBillCreated > 0))
                    {
                        transaction.Dispose();
                        throw new Exception("Tạo hoá đơn nhập hàng bị lỗi, xin thử lại!");
                    }


                    /** Save Import Detail */
                    // add the rest additional information to each item of import bill details
                    importBillDetails = importBillDetails.Select(x =>
                    {
                        x.CreatedAt = DateTime.UtcNow;
                        x.UpdatedAt = DateTime.UtcNow;
                        x.IsDeleted = false;
                        x.ImportBillId = importBill.Id;

                        return x;
                    }).ToList();

                    await _context.ImportBillDetails.AddRangeAsync(importBillDetails);
                    var importBillDetailsCreated = await _context.SaveChangesAsync();
                    if (!(importBillDetailsCreated > 0))
                    {
                        transaction.Dispose();
                        throw new Exception("Tạo hoá đơn nhập hàng bị lỗi, xin thử lại!");
                    }

                    await transaction.CommitAsync();
                }
                catch (Exception e)
                {
                    return new CreateImportBillResult
                    {
                        IsSuccess = false,
                        Errors = new List<string>()
                        {
                            e.Message.ToString()
                        }
                    };
                }
            }

            /** Get the created import bill and full related information to display on FE */
            var createdImportBill = await GetByIdAsync(importBill.Id);
            return new CreateImportBillResult
            {
                IsSuccess = true,
                ImportBill = createdImportBill
            };

        }

        private double CalculateTotalAmountInImportBillDetails(
            IEnumerable<ImportBillDetail> importBillDetails
        )
        {
            double totalAmount = importBillDetails
                .Sum(item =>
                {
                    double sum = item.Price * item.Quantity;
                    return sum;
                });

            return totalAmount;
        }

        private async Task<CheckValidImportBillDetailsResult> CheckValidImportBillDetail(
            IEnumerable<ImportBillDetail> importBillDetails,
            int requestImportProductId
        )
        {
            var requestImportDetails = await _context.RequestImportDetails
                .Where(rid => rid.RequestImportProductId == requestImportProductId)
                .ToListAsync();


            var checkProductsMatchResult = AreProductTiersInImportBillDetailMatchedRequestImportDetails(
                importBillDetails,
                requestImportDetails
            );
            if (checkProductsMatchResult.IsSuccess == false)
            {
                return new CheckValidImportBillDetailsResult
                {
                    IsSuccess = false,
                    Errors = checkProductsMatchResult.Errors
                };
            }


            bool areAllProductsInImportDetailExist = await CheckExistOfAllProductInImportDetails(
                importBillDetails
            );
            if (!areAllProductsInImportDetailExist)
            {
                return new CheckValidImportBillDetailsResult
                {
                    IsSuccess = false,
                    Errors = new List<string>()
                    {
                        "Sản phẩm yêu cầu nhập không tồn tại"
                    }
                };
            }


            var checkProductsQuantityResult = await AreTheQuantityOfProductTiersInImportBillValid(
                importBillDetails,
                requestImportDetails,
                requestImportProductId
            );
            if (checkProductsQuantityResult.IsSuccess == false)
            {
                return new CheckValidImportBillDetailsResult
                {
                    IsSuccess = false,
                    Errors = checkProductsQuantityResult.Errors
                };
            }


            return new CheckValidImportBillDetailsResult
            {
                IsSuccess = true
            };
        }

        private CheckImportProductAndRequestImportProductMatchResult AreProductTiersInImportBillDetailMatchedRequestImportDetails(
            IEnumerable<ImportBillDetail> importBillDetails,
            IEnumerable<RequestImportDetail> requestImportDetails
        )
        {
            /** Get all requested product tier ids from request import details */
            var productTierIdsFromRequestImportDetails = requestImportDetails
                .Select(x => x.ProductTierId);

            /** Extract all product tier ids from import bill */
            var productTierIdsFromImportBillDetails = importBillDetails
                .Select(x => x.ProductTierId);

            /** If there is exists an item that only exist in ImportBillDetail
             * But not exist in RequestImportDetail
             * => that's a invalid product 
             */
            var productIdsNotInRequest = productTierIdsFromImportBillDetails
                .Except(productTierIdsFromRequestImportDetails)
                    .ToList();
            if (productIdsNotInRequest.Count() > 0)
            {
                /** Create error message from invalid product id list */
                List<string> errors = new List<string>();
                foreach (var productId in productIdsNotInRequest)
                {
                    errors.Add(
                        $"Sản phẩm với id: {productId} không được yêu cầu nhập hàng trong đợt nhập hàng lần này"
                    );
                }

                return new CheckImportProductAndRequestImportProductMatchResult
                {
                    IsSuccess = false,
                    Errors = errors
                };
            }

            return new CheckImportProductAndRequestImportProductMatchResult
            {
                IsSuccess = true
            };
        }

        private async Task<CheckValidImportBillDetailQuantityResult> AreTheQuantityOfProductTiersInImportBillValid(
            IEnumerable<ImportBillDetail> newImportBillDetails,
            IEnumerable<RequestImportDetail> requestImportDetails,
            int requestImportProductId
        )
        {
            bool isSuccess = true;

            var oldImportBillsOfRequestImportProduct = await _context.ImportBills
                .Where(ib => ib.RequestImportProductId == requestImportProductId)
                .Include(ib => ib.ImportBillDetails)
                .ToListAsync();

            /** Clone requestImportDetail to the new list with quantity  = 0 to calculate the 
            * quantity of all import detail and compare that it's enough or not */
            List<RequestImportDetail> baseEmptyRequestImportDetails = requestImportDetails
                .Select(rid =>
                    new RequestImportDetail
                    {
                        RequestImportProductId = rid.RequestImportProductId,
                        ProductTierId = rid.ProductTierId,
                        Quantity = rid.Quantity
                    }
                )
                .ToList();

            baseEmptyRequestImportDetails = baseEmptyRequestImportDetails
                 .Select(x =>
                 {
                     x.Quantity = 0;
                     return x;
                 })
                 .ToList();

            /** If the old import bill details are existed
             * then add them to the baseEmptyRequestImportDetails */
            if (oldImportBillsOfRequestImportProduct.Count() > 0)
            {
                /** Loop through all import bill details and 
                 * add them in baseEmptyRequestImportDetails */
                foreach (var importBill in oldImportBillsOfRequestImportProduct)
                {
                    foreach (var importDetail in importBill.ImportBillDetails)
                    {
                        baseEmptyRequestImportDetails = baseEmptyRequestImportDetails.Select(x =>
                        {
                            if (x.ProductTierId == importDetail.ProductTierId)
                            {
                                x.Quantity += importDetail.Quantity;
                            }

                            return x;
                        })
                        .ToList();
                    }
                }
            }

            /** Add new import detail to baseEmptyRequestImportDetail too */
            foreach (var detail in newImportBillDetails)
            {
                baseEmptyRequestImportDetails = baseEmptyRequestImportDetails.Select(x =>
                {
                    if (x.ProductTierId == detail.ProductTierId)
                    {
                        x.Quantity += detail.Quantity;
                    }

                    return x;
                })
                .ToList();
            }


            List<string> errors = new List<string>();
            foreach (var request in baseEmptyRequestImportDetails)
            {
                /** Get the orginal request import detail item 
                 * and compare to the request import detail item in new custom list above
                 * if the quantity of the custom list is over the origin
                 * => fail
                 */
                var originalRequestItem = requestImportDetails
                    .SingleOrDefault(x => x.ProductTierId == request.ProductTierId);
                var importBillDetailItem = newImportBillDetails
                    .SingleOrDefault(x => x.ProductTierId == request.ProductTierId);

                if (request.Quantity > originalRequestItem.Quantity)
                {
                    isSuccess = false;
                    errors.Add(
                        $"Số lượng nhập thêm {importBillDetailItem.Quantity}kg " +
                        $"của sản phẩm id = {originalRequestItem.ProductTierId} " +
                        $"(tổng số lượng nhập của sản phẩm này là: {request.Quantity}kg) " +
                        $"không hợp lệ vì vượt mức của số lượng yêu cầu là: " +
                        $"{originalRequestItem.Quantity}kg"
                    );
                }
            }

            if (!isSuccess)
            {
                return new CheckValidImportBillDetailQuantityResult
                {
                    IsSuccess = false,
                    Errors = errors
                };
            }

            return new CheckValidImportBillDetailQuantityResult
            {
                IsSuccess = true
            };
        }

        private async Task<bool> CheckExistOfAllProductInImportDetails(
            IEnumerable<ImportBillDetail> newImportBillDetails
        )
        {
            /** get all product Ids in import detail list
             * to query to db to check all of them are existed or not
             */
            IEnumerable<int> productTierIdList = newImportBillDetails
                .Select(x => x.ProductTierId);
            var productTiers = await _context.ProductTiers
                .Where(pt => productTierIdList.Contains(pt.Id) && pt.IsDeleted == false)
                .ToListAsync();

            /** If the requested product tiers list in db has the same length
            * as the request import detail list => all request product tier in
            * request import detail are existed
            */
            return newImportBillDetails.Count() == productTiers.Count();
        }

        public async Task<ImportBill> GetByIdAsync(int importBillId)
        {
            return await _context.ImportBills
                .Where(ib => ib.Id == importBillId)
                .Include(ib => ib.StorageManager)
                .Include(ib => ib.ImportBillDetails)
                    .ThenInclude(ibd => ibd.ProductTier)
                        .ThenInclude(pt => pt.Product)
                .FirstOrDefaultAsync();
        }
    }
}
