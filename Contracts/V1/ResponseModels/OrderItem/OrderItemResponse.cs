using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTier;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.OrderItem
{
    public class OrderItemResponse
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double SinglePrice { get; set; }
        public int ProductTierId { get; set; }
        public int OrderId { get; set; }
        public ProductTierResponse ProductTier { get; set; }
    }
}