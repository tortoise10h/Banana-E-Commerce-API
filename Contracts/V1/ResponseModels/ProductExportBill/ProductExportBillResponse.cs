using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Order;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductExportDetail;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.StorageManager;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductExportBill
{
    public class ProductExportBillResponse
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int StorageManagerId { get; set; }

        public StorageManagerResponse StorageManager { get; set; }
        public OrderResponse Order { get; set; }
        public IEnumerable<ProductExportDetailResponse> ProductExportDetails { get; set; }
    }
}