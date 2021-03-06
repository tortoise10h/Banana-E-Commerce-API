using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductImage;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductFavor
{
    public class ProductResponseOfProductFavor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public PriceCurrency PriceCurrency { get; set; }
        public ProductStatus Status { get; set; }
        public double ProductTier1AverageRate { get; set; }
        public double ProductTier2AverageRate { get; set; }

        public IEnumerable<ProductImageResponse> ProductImages { get; set; }
    }
}