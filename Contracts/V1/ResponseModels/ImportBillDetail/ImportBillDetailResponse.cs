using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTier;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ImportBillDetail
{
    public class ImportBillDetailResponse
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public int ImportBillId { get; set; }
        public int ProductTierId { get; set; }
        public ProductTierResponseOfImportBillDetail ProductTier { get; set; }
    }
}