using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Address;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IAddressService
    {
        Task<bool> CreateAsync(Address address, int createdCustomerId);
        Task<IEnumerable<Address>> GetAllAsync(
            int userId,
            PaginationFilter pagination,
            GetAllAddressesFilter filter = null);
        Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllAddressesFilter filter = null
        );
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

        public async Task<IEnumerable<Address>> GetAllAsync(
            int userId,
            PaginationFilter pagination,
            GetAllAddressesFilter filter = null
        )
        {
            var customer = await _context.Customers.SingleOrDefaultAsync(c => c.UserId == userId);
            var queryable = _context.Addresses.AsQueryable();

            queryable = AddFilterOnQuery(filter, queryable);

            var skip = (pagination.PageNumber - 1) * pagination.PageSize;
            return await queryable
                .Where(c => c.CustomerId == customer.Id)
                .Skip(skip)
                .Take(pagination.PageSize)
                .ToListAsync();
        }



        public async Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllAddressesFilter filter = null
        )
        {
            var queryable = _context.Addresses.AsQueryable();

            queryable = queryable.Where(x => x.IsDeleted == false);
            queryable = AddFilterOnQuery(filter, queryable);
            return await queryable.CountAsync();
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

        private IQueryable<Address> AddFilterOnQuery(
            GetAllAddressesFilter filter,
            IQueryable<Address> queryable
        )
        {
            return queryable;
        }
    }
}