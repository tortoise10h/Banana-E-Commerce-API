using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.CartDetailModels
{
    public class CartDetailResponse
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int CartId { get; set; }
        public ProductResponse Product { get; set; }
    }
}