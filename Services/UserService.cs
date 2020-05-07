using System;
using System.Collections.Generic;
using System.Linq;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;

namespace Banana_E_Commerce_API.Services
{
    public interface IUserService
    {
        User Authenticate(string email, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Create(User user, string password);
        void Update(User user, string password);
        void Delete(int id);
    }

    public class UserService : IUserService
    {
        private DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public User Authenticate(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            var user = _context.Users.SingleOrDefault(user => user.Email == email);

            if (user == null)
            {
                return null;
            }

            // check if password is correct 
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                return null;
            }

            // authenticate successful
            return user;
        }
        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public User GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public User Create(User user, string password)
        {
            // validattion 
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Password is required");
            }
            if (_context.Users.Any(x => x.Email == user.Email))
            {
                throw new Exception($"Email {user.Email} is already taken");
            }

            // hash user password process
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.IsDeleted = false;
            user.CreatedAt = DateTime.Now;
            user.RoleId = 1;

            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
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
                CreatePasswordHash(password, out passwordHash, out passwordSalt);

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

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Valuate can not be empty or contain white space", "password");
            }

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Value can not empty or contain white space", "password");
            }
            if (passwordHash.Length != 64)
            {
                throw new ArgumentException("Invalid length of password hash (64 bytes expected)", "passwordHash");
            }
            if (passwordSalt.Length != 128)
            {
                throw new ArgumentException("Invalid length of password salt (128 bytes expected)", "passwordSalt");
            }

            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}