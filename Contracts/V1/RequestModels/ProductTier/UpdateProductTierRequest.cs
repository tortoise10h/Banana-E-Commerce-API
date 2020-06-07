using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductTier
{
    public class UpdateProductTierRequest
    {
        public double Quantity { get; set; }
        public double PricePerKg { get; set; }
        public double KgSale { get; set; }
        public int DiscountPercentage { get; set; }
        public PriceCurrency PriceCurrency { get; set; }
    }
}