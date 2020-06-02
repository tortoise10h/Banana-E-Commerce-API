using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Customer;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;
using Banana_E_Commerce_API.Domains;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface ICustomerService
    {
        Task<bool> CreateAsync(Customer customer);
        Task<UpdateCustomerInfoResult> UpdateAsync(Customer customer, int userId);
        Task<bool> IsCustomerOwnInfo(int userId, int customerId);
        Task<Customer> GetByIdAsync(int customerId);
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

        public async Task<Customer> GetByIdAsync(int customerId)
        {
            return await _context.Customers
                .SingleOrDefaultAsync(a => a.Id == customerId && a.IsDeleted == false);
        }

        public async Task<bool> IsCustomerOwnInfo(int userId, int customerId)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Id == userId);
            var customer = await _context.Customers
                .Where(u => u.Id == customerId && 
                        u.UserId == user.Id)
                    .FirstOrDefaultAsync();

            if (customer == null)
            {
                return false;
            }
            
            return true;
        }

        public async Task<UpdateCustomerInfoResult> UpdateAsync(Customer customer, int userId)
        {
            var currentPhone = await _context.Customers
                .SingleOrDefaultAsync(c => c.Phone == customer.Phone && c.UserId == userId);

            var newPhone = await _context.Customers.SingleOrDefaultAsync(c => c.Phone == customer.Phone);

            if (currentPhone == null && newPhone != null)
            {
                return new UpdateCustomerInfoResult
                {
                    IsSuccess = false,
                    Errors = new[] { $"The phone number {customer.Phone} is already existed" }
                };
            }
            
            var adminPhone = await _context.Admins.SingleOrDefaultAsync(a => a.Phone == customer.Phone);
            if (adminPhone != null)
            {
                return new UpdateCustomerInfoResult
                {
                    IsSuccess = false,
                    Errors = new[] { $"The phone number {customer.Phone} is already existed" }
                };
            }

            var storageManagerPhone = await _context.StorageManagers.SingleOrDefaultAsync(s => s.Phone == customer.Phone);
            if (storageManagerPhone != null)
            {
                return new UpdateCustomerInfoResult
                {
                    IsSuccess = false,
                    Errors = new[] { $"The phone number {customer.Phone} is already existed" }
                };
            }

            _context.Customers.Update(customer);
            var updated = await _context.SaveChangesAsync();

            return new UpdateCustomerInfoResult
                {
                    IsSuccess = true,
                };
        }
    }
}