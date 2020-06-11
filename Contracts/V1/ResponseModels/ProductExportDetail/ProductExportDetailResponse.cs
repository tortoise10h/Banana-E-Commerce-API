using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTier;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductExportDetail
{
    public class ProductExportDetailResponse
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public int ExportBillId { get; set; }
        public int ProductTierId { get; set; }

        public ProductTierResponse ProductTier { get; set; }
    }
}