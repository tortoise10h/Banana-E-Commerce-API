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
using Microsoft.EntityFrameworkCore;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Role;
using AutoMapper;

namespace Banana_E_Commerce_API.Services
{
    public interface IAuthService
    {
        Task<RegisterResult> RegisterAsync(string email, string password, Customer customer);
        void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
        bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);
        Task<AuthenticateResult> Authenticate(string email, string password);
        Task<WriteTokenForLoginUserResult> WriteTokenForLoginUser(
            string secretKey,
            UserResponse user,
            TimeSpan tokenLifeTime);
        Task<WriteTokenForLoginUserResult> RefreshTokenAsync(
            string token,
            string refreshToken,
            TimeSpan tokenLifeTime,
            string secretKey
        );
    }
    public class AuthService : IAuthService
    {
        private readonly DataContext _context;
        private readonly ICustomerService _customerService;
        private readonly ICartService _cartService;
        private readonly TokenValidationParameters _tokenValidationParameters;
        private readonly IMapper _mapper;

        public AuthService(
            DataContext context,
            ICustomerService customerService,
            ICartService cartService,
            TokenValidationParameters tokenValidationParameters,
            IMapper mapper)
        {
            _context = context;
            _customerService = customerService;
            _cartService = cartService;
            _tokenValidationParameters = tokenValidationParameters;
            _mapper = mapper;
        }

        public async Task<RegisterResult> RegisterAsync(string email, string password, Customer customer)
        {
            var existedUser = _context.Users.SingleOrDefault(u => u.Email == email);
            var customerRole = _context.Roles.SingleOrDefault(r => r.RoleName == RoleNameEnum.Customer);

            if (existedUser != null)
            {
                return new RegisterResult
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
                CreatedAt = DateTime.UtcNow,
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
                    // Create user
                    await _context.Users.AddAsync(newUser);
                    var created = await _context.SaveChangesAsync();
                    var createUser = _context.Users.SingleOrDefault(u => u.Email == email);


                    // create customer
                    customer.UserId = createUser.Id;
                    var isCustomerCreated = await _customerService.CreateAsync(customer);
                    if (!isCustomerCreated)
                    {
                        transaction.Dispose();
                    }

                    // create cart for customer
                    var isCartCreated = await _cartService.CreateAsync(customer.Id);
                    if (!isCartCreated)
                    {
                        transaction.Dispose();
                    }

                    transaction.Commit();
                }
                catch (System.Exception)
                {

                    return new RegisterResult
                    {
                        IsSuccess = false,
                        Errors = new[]
                        {
                            $"The phone number {customer.Phone} is already existed"
                        }
                    };
                }
            }

            return new RegisterResult
            {
                IsSuccess = true,
                User = newUser
            };
        }

        public async Task<AuthenticateResult> Authenticate(string email, string password)
        {
            var user = await _context.Users
                .Where(user => user.Email == email)
                .Include(user => user.Role)
                .FirstOrDefaultAsync();


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

            switch (user.Role.RoleName)
            {
                case RoleNameEnum.Admin:
                    {
                        user = await _context.Users
                            .Where(u => u.Id == user.Id)
                            .Include(u => u.Admin)
                            .Include(user => user.Role)
                            .FirstOrDefaultAsync();
                        break;
                    }
                case RoleNameEnum.Manager:
                    {
                        user = await _context.Users
                            .Where(u => u.Id == user.Id)
                            .Include(u => u.Manager)
                            .Include(user => user.Role)
                            .FirstOrDefaultAsync();
                        break;
                    }
                case RoleNameEnum.Customer:
                    {
                        user = await _context.Users
                            .Where(u => u.Id == user.Id)
                            .Include(u => u.Customer)
                                .ThenInclude(u => u.Cart)
                            .Include(user => user.Role)
                            .FirstOrDefaultAsync();
                        break;
                    }
                case RoleNameEnum.StorageManager:
                    {
                        user = await _context.Users
                            .Where(u => u.Id == user.Id)
                            .Include(user => user.Role)
                            .Include(u => u.StorageManager)
                            .FirstOrDefaultAsync();
                        break;
                    }
                default: break;
            }

            // authenticate successful
            return new AuthenticateResult
            {
                IsSuccess = true,
                User = user
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

        public async Task<WriteTokenForLoginUserResult> WriteTokenForLoginUser(
            string secretKey,
            UserResponse user,
            TimeSpan tokenLifeTime)
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
                    new Claim("id", user.Id.ToString()),
                    new Claim("role", user.Role.RoleName.ToString())
                }),
                Expires = DateTime.UtcNow.Add(tokenLifeTime),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            var refreshToken = new RefreshToken
            {
                Token = Guid.NewGuid().ToString(),
                JwtId = token.Id,
                UserId = user.Id,
                CreatedAt = DateTime.UtcNow,
                ExpiryDate = DateTime.UtcNow.AddDays(7),
                IsUsed = false,
                IsValidated = true
            };

            await _context.RefreshToken.AddAsync(refreshToken);
            await _context.SaveChangesAsync();

            return new WriteTokenForLoginUserResult
            {
                IsSuccess = true,
                Token = tokenString,
                RefreshToken = refreshToken.Token,
                User = user
            };
        }

        public async Task<WriteTokenForLoginUserResult> RefreshTokenAsync(
            string token,
            string refreshToken,
            TimeSpan tokenLifeTime,
            string secretKey)
        {
            var validatedToken = GetPrincipalFromToken(token);

            if (validatedToken == null)
            {
                return new WriteTokenForLoginUserResult
                {
                    IsSuccess = false,
                    Errors = new[] { "Invalid token" }
                };
            }

            // check the expiry time of token
            // by compare the expiry time and current time
            // if the expiry time smaller than current time => token has been expired
            var expiryDateUnix =
                long.Parse(validatedToken.Claims
                    .Single(x => x.Type == JwtRegisteredClaimNames.Exp).Value);
            var expiryDateTimeUtc = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                .AddSeconds(expiryDateUnix);
            if (expiryDateTimeUtc > DateTime.UtcNow)
            {
                return new WriteTokenForLoginUserResult
                {
                    IsSuccess = false,
                    Errors = new[] { "This token hasn't expired yet" }
                };
            }

            var jti =
                validatedToken.Claims
                    .Single(x => x.Type == JwtRegisteredClaimNames.Jti).Value;

            var storedRefreshToken = await _context.RefreshToken
                .SingleOrDefaultAsync(x => x.Token == refreshToken);

            if (storedRefreshToken == null)
            {
                return new WriteTokenForLoginUserResult
                {
                    IsSuccess = false,
                    Errors = new[] { "This refresh token does not exist" }
                };
            }

            if (DateTime.UtcNow > storedRefreshToken.ExpiryDate)
            {
                return new WriteTokenForLoginUserResult
                {
                    IsSuccess = false,
                    Errors = new[] { "This refresh token has expired" }
                };
            }

            if (storedRefreshToken.IsValidated == false)
            {
                return new WriteTokenForLoginUserResult
                {
                    IsSuccess = false,
                    Errors = new[] { "This refresh token has been invalidated" }
                };
            }

            if (storedRefreshToken.IsUsed == true)
            {
                return new WriteTokenForLoginUserResult
                {
                    IsSuccess = false,
                    Errors = new[] { "This refresh token has been used" }
                };
            }

            if (storedRefreshToken.JwtId != jti)
            {
                return new WriteTokenForLoginUserResult
                {
                    IsSuccess = false,
                    Errors = new[] { "This refresh token does not match this JWT" }
                };
            }

            storedRefreshToken.IsUsed = true;
            _context.RefreshToken.Update(storedRefreshToken);
            await _context.SaveChangesAsync();

            var userId = int.Parse(validatedToken.Claims
                    .Single(x => x.Type == "id").Value);
            var user = await _context.Users
                .Where(x => x.Id == userId)
                .Include(x => x.Role)
                .FirstOrDefaultAsync();

            var userResponse = _mapper.Map<UserResponse>(user);

            return await WriteTokenForLoginUser(
                secretKey,
                userResponse,
                tokenLifeTime
            );
        }

        private ClaimsPrincipal GetPrincipalFromToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            try
            {
                var principal = tokenHandler.ValidateToken(
                    token,
                    _tokenValidationParameters,
                    out var validatedToken);

                if (!IsJwtWithValidSecurityAlgorithm(validatedToken))
                {
                    return null;
                }

                return principal;
            }
            catch
            {

                return null;
            }
        }

        private bool IsJwtWithValidSecurityAlgorithm(SecurityToken validatedToken)
        {
            return (validatedToken is JwtSecurityToken jwtSecurityToken) &&
                jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256,
                    StringComparison.InvariantCultureIgnoreCase);
        }
    }
}