using System;
using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ImportBillDetail;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.StorageManager;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ImportBill
{
    public class ImportBillResponse
    {
        public int Id { get; set; }
        public double TotalAmount { get; set; }
        public PriceCurrency Currency { get; set; }
        public string Code { get; set; }
        public int RequestImportProductId { get; set; }
        public int StorageManagerId { get; set; }
        public int StorageId { get; set; }
        public string SupplierBillImageLocation { get; set; }
        public string StorageManagerBillImageLocation { get; set; }
        public StorageManagerResponse StorageManager { get; set; }
        public IEnumerable<ImportBillDetailResponse> ImportBillDetails { get; set; }
    }
}