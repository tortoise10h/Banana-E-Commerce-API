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
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Services
{
    public interface IAuthService
    {
        Task<RegisterResponse> RegisterAsync(string email, string password, Customer customer);
        void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
        bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);
        AuthenticateResult Authenticate(string email, string password);
        string WriteTokenForLoginUser(string secretKey, UserResponse user);
    }
    public class AuthService : IAuthService
    {
        private readonly DataContext _context;
        private readonly ICustomerService _customerService;

        public AuthService(
            DataContext context,
            ICustomerService customerService)
        {
            _context = context;
            _customerService = customerService;
        }

        public async Task<RegisterResponse> RegisterAsync(string email, string password, Customer customer)
        {
            var existedUser = _context.Users.SingleOrDefault(u => u.Email == email);
            var customerRole = _context.Roles.SingleOrDefault(r => r.RoleName == RoleNameEnum.Customer);

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

            /** Create new user info */
            var newUser = new User
            {
                Email = email,
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                Status = UserStatus.Verified,
                RoleId = customerRole.Id
            };
            // hash user password process
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);
            newUser.PasswordHash = passwordHash;
            newUser.PasswordSalt = passwordSalt;

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    await _context.Users.AddAsync(newUser);
                    var created = await _context.SaveChangesAsync();
                    var createUser = _context.Users.SingleOrDefault(u => u.Email == email);


                    customer.UserId = createUser.Id;
                    var customerCreated = await _customerService.CreateAsync(customer);
                    if (!customerCreated)
                    {
                        transaction.Dispose();
                    }

                    transaction.Commit();
                }
                catch (System.Exception)
                {

                    return new RegisterResponse
                    {
                        IsSuccess = false,
                        Errors = new[]
                        {
                            $"The phone number {customer.Phone} is already existed"
                        }
                    };
                }
            }

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
            var user = _context.Users.SingleOrDefault(user => user.Email == email);

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

        public string WriteTokenForLoginUser(string secretKey, UserResponse user)
        {
            // generate JWT token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim("id", user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(4),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }
    }
}