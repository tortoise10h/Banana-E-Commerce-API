using System.Collections.Generic;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Domains
{
    public class GetAllProductsFilter
    {
        public string Name { get; set; }
        public double ProductTier1FromPrice { get; set; }
        public double ProductTier1ToPrice { get; set; }
        public double ProductTier2FromPrice { get; set; }
        public double ProductTier2ToPrice { get; set; }
        public FilterOrder Order { get; set; }
        public int Quantity { get; set; }
        public string OrderOption { get; set; }
        public PriceCurrency PriceCurrency { get; set; }
        public int[] CategoryIds { get; set; }
        public int StorageId { get; set; }
    }
}