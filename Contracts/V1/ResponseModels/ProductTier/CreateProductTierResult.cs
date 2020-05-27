using System.Collections.Generic;
using E = Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTier
{
    public class CreateProductTierResult
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public E.ProductTier ProductTier { get; set; }
    }
}