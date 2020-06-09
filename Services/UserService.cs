using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Admin;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Customer;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IUserService
    {

        Task<IEnumerable<User>> GetAllAsync
        (
            PaginationFilter pagination,
            GetAllUserFilter filter = null
        );
        Task<int> CountAllAsync
        (
            PaginationFilter pagination,
            GetAllUserFilter filter = null
        );
        Task<User> GetByIdAsync(int userId);
        Task<UpdateUserPasswordResult> UpdateUserPassword
        (
            User user, 
            string oldPassword, 
            string newPassword, 
            string confirmPassword
        );
        Task<bool> BanUserAsync(int userId);
        Task<bool> CreateAsync(User user, string password);
        Task<bool> IsUserOwnInfo(int userId, int requestedUserId);
        Task<bool> IsAdmin(int userId);
    }

    public class UserService : IUserService
    {
        private DataContext _context;
        public IAuthService _authService;

        public UserService(
            DataContext context,
            IAuthService authService
        )
        {
            _context = context;
            _authService = authService;
        }
        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public async Task<User> GetByIdAsync(int userId)
        {
            var user = await _context.Users
                .Where(x => x.Id == userId)
                .Include(x => x.Role)
                .FirstOrDefaultAsync();
            if (user == null)
            {
                return null;
            }
            
            var roleName = user.Role.RoleName;

            User userAndInfo = null;

            switch (roleName)
            {
                case RoleNameEnum.Admin:
                    {
                        userAndInfo = await _context.Users
                            .Where(u => u.Id == userId)
                            .Include(u => u.Admin)
                            .FirstOrDefaultAsync();
                        break;
                    }
                case RoleNameEnum.Manager:
                    {
                        userAndInfo = await _context.Users
                            .Where(u => u.Id == userId)
                            .Include(u => u.Manager)
                            .FirstOrDefaultAsync();
                        break;
                    }
                case RoleNameEnum.Customer:
                    {
                        userAndInfo = await _context.Users
                            .Where(u => u.Id == userId)
                            .Include(u => u.Customer)
                                .ThenInclude(c => c.Cart)
                            .FirstOrDefaultAsync();
                        break;
                    }
                case RoleNameEnum.StorageManager:
                    {
                        userAndInfo = await _context.Users
                            .Where(u => u.Id == userId)
                            .Include(u => u.StorageManager)
                            .FirstOrDefaultAsync();
                        break;
                    }
                default:
                    {
                        userAndInfo = user;
                        break;
                    }
            }

            return userAndInfo;

        }

        public async Task<bool> CreateAsync(User user, string password)
        {
            // hash user password process
            byte[] passwordHash, passwordSalt;
            _authService.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.IsDeleted = false;
            user.CreatedAt = DateTime.UtcNow;
            user.Status = UserStatus.Verified;

            await _context.Users.AddAsync(user);
            var created = await _context.SaveChangesAsync();

            return created > 0;
        }
        public async Task<UpdateUserPasswordResult> UpdateUserPassword(
            User user, 
            string oldPassword, 
            string newPassword, 
            string confirmPassword)
        {
            var userInfo = await _context.Users.SingleOrDefaultAsync(u => u.Id == user.Id && u.IsDeleted == false);

            if (userInfo == null)
            {
                return new UpdateUserPasswordResult
                {
                    IsSuccess = false,
                    Errors = new[] { "User is not existed" }
                };
            }
        
            // verify old password
            if (!_authService.VerifyPasswordHash(oldPassword, userInfo.PasswordHash, userInfo.PasswordSalt))
            {
                return new UpdateUserPasswordResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Old password is not correct" }
                };
            }

            // verify password and confirm password
            if (newPassword != confirmPassword)
            {
                return new UpdateUserPasswordResult
                {
                    IsSuccess = false,
                    Errors = new[] { "New password and confirm password do not match" }
                };
            }

            // update new password
            if (!string.IsNullOrWhiteSpace(newPassword))
            {
                byte[] passwordHash, passwordSalt;
                _authService.CreatePasswordHash(newPassword, out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
            }

            _context.Users.Update(user);
            var updated = await _context.SaveChangesAsync();

            return new UpdateUserPasswordResult
                {
                    IsSuccess = true,
                };
        }
        
        public async Task<bool> BanUserAsync(int userId)
        {
            var userInfo = await _context.Users.SingleOrDefaultAsync(a => a.Id == userId);

            if (userInfo == null)
            {
                return false;
            }

            userInfo.Status = UserStatus.Banned;
            _context.Users.Update(userInfo);
            var deleted = await _context.SaveChangesAsync();

            return deleted > 0;
        }

        public async Task<IEnumerable<User>> GetAllAsync(
            PaginationFilter pagination,
            GetAllUserFilter filter = null)
        {
            var queryable = _context.Users.AsQueryable();

            queryable = AddFilterOnQuery(filter, queryable);

            var skip = (pagination.PageNumber - 1) * pagination.PageSize;
            return await queryable
                .Skip(skip)
                .Include(u => u.Admin)
                .Include(u => u.Customer)
                .Include(u => u.StorageManager)
                .Take(pagination.PageSize)
                .ToListAsync();
        }

        public async Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllUserFilter filter = null
        )
        {
            var queryable = _context.Users.AsQueryable();

            queryable = queryable.Where(x => x.IsDeleted == false);
            queryable = AddFilterOnQuery(filter, queryable);
            return await queryable.CountAsync();
        }
        private IQueryable<User> AddFilterOnQuery(
            GetAllUserFilter filter,
            IQueryable<User> queryable
        )
        {
            queryable = queryable.Where(x => x.IsDeleted == false);

            if (!string.IsNullOrEmpty(filter?.Email))
            {
                queryable = queryable.Where(x => x.Email.Contains(filter.Email));
            }

            if (filter?.Status > 0)
            {
                queryable = queryable.Where(x => x.Status == filter.Status);
            }
            
            if (filter?.RoleId > 0)
            {
                queryable = queryable.Where(x => x.RoleId == filter.RoleId);
            }

            return queryable;
        }


        public async Task<bool> IsUserOwnInfo(int userId, int requestedUserId)
        {
            var user = await _context.Users.SingleOrDefaultAsync(user => user.Id == userId);

            if (user.Id != requestedUserId)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> IsAdmin(int userId)
        {
            var admin = await _context.Admins.SingleOrDefaultAsync(a => a.UserId == userId);

            if (admin == null)
            {
                return false;
            }
            return true;
        }
    }
}