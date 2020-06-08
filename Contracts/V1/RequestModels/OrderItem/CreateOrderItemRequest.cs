namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.OrderItem
{
    public class CreateOrderItemRequest
    {
        public int Quantity { get; set; }
        public int ProductTierId { get; set; }
    }
}