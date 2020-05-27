using System.Collections.Generic;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Entities
{
    public class Tier
    {
        public int Id { get; set; }
        public TierEnum TierOption { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<ProductTier> ProductTiers { get; set; }
    }
}