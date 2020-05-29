using System;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IStorageManagerService
    {
        Task<bool> CreateAsync(User user, StorageManager storageManager, string password);
    }

    public class StorageManagerService : IStorageManagerService
    {
        private readonly DataContext _context;
        private readonly IUserService _userService;

        public StorageManagerService(
            DataContext context,
            IUserService userService
        )
        {
            _context = context;
            _userService = userService;
        }

        public async Task<bool> CreateAsync(
            User user,
            StorageManager storageManager,
            string password)
        {
            var storageManagerRole = await _context.Roles
                .SingleOrDefaultAsync(r => r.RoleName == RoleNameEnum.StorageManager);

            /** prepare storage manager info */
            storageManager.CreatedAt = DateTime.UtcNow;
            storageManager.UpdatedAt = DateTime.UtcNow;
            storageManager.IsDeleted = false;

            /** prepare user info */
            user.RoleId = storageManagerRole.Id;


            var isUserCreated = await _userService.CreateAsync(
                user, password);
            if (!isUserCreated)
            {
                return false;
            }


            storageManager.UserId = user.Id;
            await _context.StorageManagers.AddAsync(storageManager);
            var storageManagerCreated = await _context.SaveChangesAsync();
            if (!(storageManagerCreated > 0))
            {
                return false;
            }

            return true;
        }
    }
}