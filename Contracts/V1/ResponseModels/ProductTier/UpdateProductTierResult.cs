using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTier
{
    public class UpdateProductTierResult
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public ProductTierResponse ProductTierResponse { get; set; }
    }
}