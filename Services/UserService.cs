using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Helpers;

namespace Banana_E_Commerce_API.Services
{
    public interface IUserService
    {

        IEnumerable<User> GetAll();
        User GetById(int id);
        void Update(User user, string password);
        void Delete(int id);
        Task<bool> CreateAsync(User user, string password);
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

        public User GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public async Task<bool> CreateAsync(User user, string password)
        {
            // hash user password process
            byte[] passwordHash, passwordSalt;
            _authService.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.IsDeleted = false;
            user.CreatedAt = DateTime.Now;
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
    }
}