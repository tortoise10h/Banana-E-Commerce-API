using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductImage;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Rating
{
    public class ProductResponseOfRating
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public PriceCurrency PriceCurrency { get; set; }
        public IEnumerable<ProductImageResponse> ProductImages { get; set; }
    }
}