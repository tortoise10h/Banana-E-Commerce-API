namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.CartDetail
{
    public class AddProductToCartRequest
    {
        public double Quantity { get; set; }

        public int CartId { get; set; }

        public int ProductTierId { get; set; }
    }
}