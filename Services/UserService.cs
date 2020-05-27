using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Admin;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Customer;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Services
{
    public interface IUserService
    {

        Task<IEnumerable<User>> GetAllAsync(
            PaginationFilter pagination,
            GetAllUserFilter filter = null);
        Task<int> CountAllAsync(
            PaginationFilter pagination,
            GetAllUserFilter filter = null
        );
        Task<User> GetByIdAsync(int userId);
        void Update(User user, string password);
        void Delete(int id);
        Task<bool> CreateAsync(User user, string password);
        Task<bool> IsUserOwnInfo(int userId, int requestedUserId);
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
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Id == userId);
            var roleOfUser = await _context.Roles.SingleOrDefaultAsync(x => x.Id == user.RoleId);
            var roleName = roleOfUser.RoleName;

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
        public void Update(User userParam, string password)
        {
            var user = _context.Users.Find(userParam.Id);

            if (user == null)
            {
                throw new Exception("User is not existed");
            }

            // update email if it has changed
            if (!string.IsNullOrWhiteSpace(userParam.Email) && userParam.Email != user.Email)
            {
                // throw error if email is already taken
                if (_context.Users.Any(x => x.Email == user.Email))
                {
                    throw new Exception($"Email {userParam.Email} is already taken");
                }

                user.Email = userParam.Email;
            }

            // update password if provided
            if (!string.IsNullOrWhiteSpace(password))
            {
                byte[] passwordHash, passwordSalt;
                _authService.CreatePasswordHash(password, out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
            }

            _context.Users.Update(user);
            _context.SaveChanges();

        }
        public void Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public Task<IEnumerable<User>> GetAllAsync(PaginationFilter pagination, GetAllUserFilter filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAllAsync(PaginationFilter pagination, GetAllUserFilter filter = null)
        {
            throw new NotImplementedException();
        }

        private IQueryable<User> AddFilterOnQuery(
            GetAllUserFilter filter,
            IQueryable<User> queryable
        )
        {
            return queryable;
        }


        public async Task<bool> IsUserOwnInfo(int userId, int requestedUserId)
        {
            var user = await _context.Users.SingleOrDefaultAsync(user => user.Id == userId);

            return user.Id == requestedUserId;
        }
    }
}