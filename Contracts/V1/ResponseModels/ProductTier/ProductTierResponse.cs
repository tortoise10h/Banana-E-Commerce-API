using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTier
{
    public class ProductTierResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int TierId { get; set; }
        public double Quantity { get; set; }
        public double PricePerKg { get; set; }
        public double KgSale { get; set; }
        public double SalePrice { get; set; }
        public int DiscountPercentage { get; set; }
        public double AfterDiscountPrice { get; set; }
        public PriceCurrency PriceCurrency { get; set; }
        public ProductResponseWithoutIncludeProductTier Product { get; set; }
        // public ProductResponseOfProductTier Product { get; set; }
    }
}