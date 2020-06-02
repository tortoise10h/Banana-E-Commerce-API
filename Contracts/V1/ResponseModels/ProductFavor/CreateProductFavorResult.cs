using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductFavor
{
    public class CreateProductFavorResult
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public ProductFavorResponse ProductFavorResponse { get; set; }
    }
}