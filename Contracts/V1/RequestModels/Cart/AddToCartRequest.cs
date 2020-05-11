namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Cart
{
    public class AddToCartRequest
    {
        public int ProductId { get; set; }
        public int CartId { get; set; }
        public int Quantity { get; set; }
    }
}