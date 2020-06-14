using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Auth;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Auth;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users;
using Banana_E_Commerce_API.CustomAttributes;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Helpers;
using Banana_E_Commerce_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Banana_E_Commerce_API.Controllers.V1
{
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;
        private IUserService _userService;
        private ICustomerService _customerService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public AuthController(
            IAuthService authService,
            IUserService userService,
            ICustomerService customerService,
            IMapper mapper,
            IOptions<AppSettings> appSettings
        )
        {
            _authService = authService;
            _userService = userService;
            _customerService = customerService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.Auth.Login)]
        public async Task<IActionResult> Login([FromBody] AuthenticateRequest model)
        {
            var result = await _authService.Authenticate(model.Email, model.Password);

            if (result.IsSuccess == false)
            {
                return BadRequest(
                    new AuthenticateFailedResponse
                    {
                        Errors = result.Errors
                    }
                );
            }

            var userResponse = _mapper.Map<UserResponse>(result.User);

            // generate JWT token for login user
            var writeTokenResult = await _authService
                .WriteTokenForLoginUser(
                    _appSettings.SecretKey,
                    userResponse,
                    _appSettings.TokenLifeTime);

            if (writeTokenResult.IsSuccess == false)
            {
                return BadRequest(
                    new AuthenticateFailedResponse
                    {
                        Errors = new[] { "Đăng nhập không thành công, vui lòng thử lại" }
                    }
                );
            }


            var exp = DateTime.UtcNow.Add(_appSettings.TokenLifeTime);

            return Ok(
                new AuthenticateSuccessResponse
                {
                    Token = writeTokenResult.Token,
                    User = userResponse,
                    RefreshToken = writeTokenResult.RefreshToken,
                    Exp = exp
                }
            );
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.Auth.Register)]
        public async Task<IActionResult> Register([FromBody] RegisterRequest model)
        {
            var customerEntity = _mapper.Map<Customer>(model);

            var registerResult = await _authService.RegisterAsync(model.Email, model.Password, customerEntity);

            if (!registerResult.IsSuccess)
            {
                return BadRequest(new RegisterFailedResponse
                {
                    Errors = registerResult.Errors
                });
            }

            var userResponse = _mapper.Map<UserResponse>(registerResult.User);

            return Ok(new Response<UserResponse>(userResponse));
        }

        [HttpPost(ApiRoutes.Auth.Refresh)]
        public async Task<IActionResult> Refresh([FromBody] RefreshTokenRequest model)
        {
            var result = await _authService.RefreshTokenAsync(
                model.Token,
                model.RefreshToken,
                _appSettings.TokenLifeTime,
                _appSettings.SecretKey
            );

            if (result.IsSuccess == false)
            {
                return BadRequest(
                    new AuthenticateFailedResponse
                    {
                        Errors = result.Errors
                    }
                );
            }

            var exp = DateTime.UtcNow.AddDays(7);

            return Ok(
                new AuthenticateSuccessResponse
                {
                    Token = result.Token,
                    User = result.User,
                    RefreshToken = result.RefreshToken,
                    Exp = exp
                }
            );
        }
    }
}