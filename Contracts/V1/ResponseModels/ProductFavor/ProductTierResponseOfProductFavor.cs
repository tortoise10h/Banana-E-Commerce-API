using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductFavor
{
    public class ProductTierResponseOfProductFavor
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int TierId { get; set; }
        public double Quantity { get; set; }
        public double PricePerKg { get; set; }
        public double SalePrice { get; set; }
        public int DiscountPercentage { get; set; }
        public double AfterDiscountPrice { get; set; }
        public PriceCurrency PriceCurrency { get; set; }
        public ProductResponseOfProductFavor Product { get; set; }
    }
}