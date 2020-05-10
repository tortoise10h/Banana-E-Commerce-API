using System;
using System.Linq;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Auth;
using Banana_E_Commerce_API.Helpers;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace Banana_E_Commerce_API.Services
{
    public interface IAuthService
    {
        Task<RegisterResponse> RegisterAsync(string email, string password);
        void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
        bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);
        AuthenticateResult Authenticate(string email, string password);
        string WriteTokenForLoginUser(string secretKey, int userId);
    }
    public class AuthService : IAuthService
    {
        private DataContext _dataContext;

        public AuthService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<RegisterResponse> RegisterAsync(string email, string password)
        {
            var existedUser = _dataContext.Users.SingleOrDefault(u => u.Email == email);

            if (existedUser != null)
            {
                return new RegisterResponse
                {
                    IsSuccess = false,
                    Errors = new[]
                    {
                        $"The email {email} is already existed"
                    }
                };
            }

            var newUser = new User
            {
                Email = email
            };

            // hash user password process
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            newUser.PasswordHash = passwordHash;
            newUser.PasswordSalt = passwordSalt;
            newUser.IsDeleted = false;
            newUser.CreatedAt = DateTime.Now;
            newUser.Status = UserStatus.Verified;

            // TODO: get the existed roles in db and filter to get customer role to put in RoleID field
            newUser.RoleId = 1;

            _dataContext.Users.Add(newUser);
            await _dataContext.SaveChangesAsync();

            return new RegisterResponse
            {
                IsSuccess = true,
                user = new UserResponse
                {
                    Email = email,
                    RoleId = newUser.RoleId
                }
            };
        }

        // I'll make it async later
        public AuthenticateResult Authenticate(string email, string password)
        {
            var user = _dataContext.Users.SingleOrDefault(user => user.Email == email);

            if (user == null)
            {
                return new AuthenticateResult
                {
                    IsSuccess = false,
                    Errors = new[] { "This user does not exist" }
                };
            }

            // check if password is correct 
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                return new AuthenticateResult
                {
                    IsSuccess = false,
                    Errors = new[] { "The email or password is incorrect" }
                };
            }

            // authenticate successful
            return new AuthenticateResult
            {
                IsSuccess = true,
                User = new UserResponse
                {
                    RoleId = user.RoleId,
                    Email = user.Email,
                    Id = user.Id
                }
            };
        }

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
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

        public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
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

        public string WriteTokenForLoginUser(string secretKey, int userId)
        {
            // generate JWT token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name, userId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }
    }
}