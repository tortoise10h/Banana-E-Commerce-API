using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ImportBillDetail;
using Microsoft.AspNetCore.Http;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.ImportBill
{
    public class CreateImportBillRequest
    {
        public int RequestImportProductId { get; set; }
        public IFormFile SupplierBillImage { get; set; }
        public IFormFile StorageManagerBillImage { get; set; }
        public IEnumerable<CreateImportBillDetailRequest> ImportBillDetails { get; set; }
    }
}