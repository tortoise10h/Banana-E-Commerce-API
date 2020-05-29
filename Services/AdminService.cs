using System;
using System.Linq;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Helpers;

namespace Banana_E_Commerce_API.Services
{
    public interface IAdminService
    {
        Task<bool> CreateAsync(User user, Admin admin, string password);
    }

    public class AdminService : IAdminService
    {
        private readonly DataContext _context;
        private readonly IUserService _userService;

        public AdminService(
            DataContext context,
            IUserService userService
        )
        {
            _context = context;
            _userService = userService;
        }

        public async Task<bool> CreateAsync(User user, Admin admin, string password)
        {
            var adminRole = _context.Roles.SingleOrDefault(r => r.RoleName == RoleNameEnum.Admin);

            /** prepare admin info */
            admin.CreatedAt = DateTime.UtcNow;
            admin.UpdatedAt = DateTime.UtcNow;
            admin.IsDeleted = false;

            /** prepare user info */
            user.RoleId = adminRole.Id;

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var isUserCreated = await _userService.CreateAsync(
                        user, password);
                    if (!isUserCreated)
                    {
                        transaction.Dispose();
                    }

                    var createdUser = _context.Users.SingleOrDefault(u => u.Email == user.Email);
                    admin.UserId = createdUser.Id;
                    await _context.Admins.AddAsync(admin);
                    var adminCreated = await _context.SaveChangesAsync();
                    if (!(adminCreated > 0))
                    {
                        transaction.Dispose();
                    }

                    transaction.Commit();
                }
                catch (System.Exception)
                {
                    transaction.Dispose();
                    return false;
                }
            }

            return true;
        }
    }
}