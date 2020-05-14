using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product
{
    public class CreateProductResult
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public ProductResponse Product { get; set; }
    }
}