using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTier;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Tier
{
    public class TierResponse
    {
        public int Id { get; set; }
        public TierEnum TierOption { get; set; }

        public IEnumerable<ProductTierResponse> ProductTiers { get; set; }
    }
}