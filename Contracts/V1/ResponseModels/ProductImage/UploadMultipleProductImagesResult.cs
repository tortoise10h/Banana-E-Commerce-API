using Banana_E_Commerce_API.Entities;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductImage
{
    public class UploadMultipleProductImagesResult
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public List<ProductImageResponse> ProductImages { get; set; }
    }
}