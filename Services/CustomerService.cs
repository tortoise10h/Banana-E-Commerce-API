using System;
using System.Linq;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Customer;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;

namespace Banana_E_Commerce_API.Services
{
    public interface ICustomerService
    {
        Task<bool> CreateAsync(Customer customer);
    }

    public class CustomerService : ICustomerService
    {
        private readonly DataContext _context;

        public CustomerService(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateAsync(Customer customer)
        {
            var existedCustomerPhone = _context.Customers.SingleOrDefault(c => c.Phone == customer.Phone);

            if (existedCustomerPhone != null)
            {
                return false;
            }

            customer.CreatedAt = DateTime.UtcNow;
            customer.UpdatedAt = DateTime.UtcNow;
            customer.IsDeleted = false;

            await _context.Customers.AddAsync(customer);
            var created = await _context.SaveChangesAsync();

            return created > 0;
        }
    }
}