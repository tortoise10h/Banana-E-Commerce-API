using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Cart;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface ICartService
    {
        AddToCartResult AddProductToCart(int productId, int cartId, int quantity);
    }

    public class CartService : ICartService
    {
        private DataContext _dataContext;

        public CartService(DataContext dataContext)
        {

        }

        public AddToCartResult AddProductToCart(int productId, int cartId, int quantity)
        {
            throw new System.NotImplementedException();
        }
    }
}