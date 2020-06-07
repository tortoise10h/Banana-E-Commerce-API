using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries
{
    public class GetAllProductTiersQuery
    {
        public int ProductId { get; set; }
        public int TierId { get; set; }
        public double Quantity { get; set; }
        public int DiscountPercentage { get; set; }
        public double AfterDiscountPrice { get; set; }
    }
}