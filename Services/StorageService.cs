using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IStorageService
    {
        Task<Storage> GetByIdAsync(int id);
        Task<IEnumerable<Storage>> GetAllAsync();
        Task<bool> CreateAsync(Storage storage, int createdUserId);
        Task<bool> UpdateAsync(Storage storage);
    }

    public class StorageService : IStorageService
    {
        private readonly DataContext _context;

        public StorageService(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(Storage storage, int createdUserId)
        {
            var createdByAdmin = await _context.Admins.SingleOrDefaultAsync(a => a.UserId == createdUserId);

            storage.CreatedAt = DateTime.UtcNow;
            storage.UpdatedAt = DateTime.UtcNow;
            storage.IsDeleted = false;
            storage.CreatedBy = createdByAdmin.Id;

            await _context.Storages.AddAsync(storage);
            var created = await _context.SaveChangesAsync();

            return created > 0;
        }

        public async Task<IEnumerable<Storage>> GetAllAsync()
        {
            return await _context.Storages.ToListAsync();
        }

        public async Task<Storage> GetByIdAsync(int id)
        {
            return await _context.Storages.SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task<bool> UpdateAsync(Storage storage)
        {
            _context.Storages.Update(storage);
            var updated = await _context.SaveChangesAsync();

            return updated > 0;
        }
    }
}