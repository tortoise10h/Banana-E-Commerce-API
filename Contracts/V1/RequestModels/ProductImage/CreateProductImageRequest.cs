using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductImage
{
    public class CreateProductImageRequest
    {
        public int ProductId { get; set; }
        public IEnumerable<IFormFile> Images { get; set; }
    }
}