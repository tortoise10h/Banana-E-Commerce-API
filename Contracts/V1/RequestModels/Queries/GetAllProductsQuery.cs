using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries
{
    public class GetAllProductsQuery
    {
        public string Name { get; set; }
        public double FromPrice { get; set; }
        public double ToPrice { get; set; }
        public int Quantity { get; set; }
        public FilterOrder Order { get; set; }
        public string OrderOption { get; set; }
        public PriceCurrency PriceCurrency { get; set; }
        public int CategoryId { get; set; }
        public int StorageId { get; set; }
    }
}