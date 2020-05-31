using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTier;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.CartDetailModels
{
    public class CartDetailResponse
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public int CartId { get; set; }
        public ProductTierResponseOfCartDetail ProductTier { get; set; }
    }
}