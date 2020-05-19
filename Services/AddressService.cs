using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Address;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IAddressService
    {
        Task<bool> CreateAsync(Address address, int createdCustomerId);
        Task<IEnumerable<Address>> GetAllAsync();
        Task<Address> GetByIdAsync(int addressId);
        Task<bool> UpdateAsync(Address address, int userId);
        Task<bool> IsCustomerOwnAddress(int userId, int addressId);
    }

    public class AddressService : IAddressService
    {
        private readonly DataContext _context;

        public AddressService(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(Address address, int userId)
        {
            var createdByCustomer = await _context.Customers.SingleOrDefaultAsync(c => c.UserId == userId);

            address.CustomerId = createdByCustomer.Id;
            address.CreatedAt = DateTime.UtcNow;
            address.UpdatedAt = DateTime.UtcNow;
            address.IsDeleted = false;

            await _context.Addresses.AddAsync(address);
            var created = await _context.SaveChangesAsync();

            return created > 0;
        }

        public async Task<IEnumerable<Address>> GetAllAsync()
        {
            return await _context.Addresses
                .Where(a => a.IsDeleted == false)
                .ToListAsync();
        }

        public async Task<Address> GetByIdAsync(int id)
        {
            return await _context.Addresses
                .SingleOrDefaultAsync(a => a.Id == id && a.IsDeleted == false);
        }

    public async Task<bool> IsCustomerOwnAddress(int userId, int addressId)
    {
        var customer = await _context.Customers.SingleOrDefaultAsync(c => c.UserId == userId);
        var validateAddress = await _context.Addresses
            .Where(a => a.Id == addressId &&
                a.CustomerId == customer.Id)
            .FirstOrDefaultAsync();
        
        if (validateAddress == null)
        {
            return false;
        }

        return true;
    }

    public async Task<bool> UpdateAsync(Address address, int userId)
        {
            //Check only the creator can update
            var customer = await _context.Customers.SingleOrDefaultAsync(c => c.UserId == userId);
      
            _context.Addresses.Update(address);
            var updated = await _context.SaveChangesAsync();

            return updated > 0;
        }
    }
}