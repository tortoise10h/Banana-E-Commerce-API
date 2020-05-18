using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Cart;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface ICartService
    {
        Task<bool> CreateAsync(int customerId);
    }

    public class CartService : ICartService
    {
        private DataContext _context;

        public CartService(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(int customerId)
        {
            Cart cart = new Cart
            {
                CustomerId = customerId
            };

            await _context.Carts.AddAsync(cart);
            var created = await _context.SaveChangesAsync();

            return created > 0;
        }
    }
}