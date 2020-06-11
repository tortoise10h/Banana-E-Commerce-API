using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductExportDetail;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductExportBill
{
    public class CreateProductExportBillRequest
    {
        public int OrderId { get; set; }
        public IEnumerable<CreateProductExportDetailRequest> ProductExportDetails { get; set; }
    }
}