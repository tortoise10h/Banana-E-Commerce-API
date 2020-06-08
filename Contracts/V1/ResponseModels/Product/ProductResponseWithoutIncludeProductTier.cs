using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductImage;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product
{
    public class ProductResponseWithoutIncludeProductTier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double EntryPrice { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public ProductUnit ProductUnit { get; set; }
        public PriceCurrency PriceCurrency { get; set; }
        public int CreatedBy { get; set; }
        public int CategoryId { get; set; }
        public int StorageId { get; set; }
        public ProductStatus Status { get; set; }

        public IEnumerable<ProductImageResponse> ProductImages { get; set; }
    }
}