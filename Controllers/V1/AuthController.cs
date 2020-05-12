using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Auth;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Auth;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;
using Banana_E_Commerce_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Banana_E_Commerce_API.Controllers.V1
{
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;
        private IUserService _userService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public AuthController(
            IAuthService authService,
            IUserService userService,
            IMapper mapper,
            IOptions<AppSettings> appSettings
        )
        {
            _authService = authService;
            _userService = userService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.Auth.Login)]
        public IActionResult Login([FromBody] AuthenticateRequest model)
        {
            var result = _authService.Authenticate(model.Email, model.Password);

            if (result.IsSuccess == false)
            {
                return BadRequest(
                    new AuthenticateFailedResponse
                    {
                        Errors = result.Errors
                    }
                );
            }

            // generate JWT token for login user
            string token = _authService.WriteTokenForLoginUser(_appSettings.SecretKey, result.User);

            return Ok(
                new AuthenticateSuccessResponse
                {
                    Token = token,
                    User = result.User
                }
            );
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.Auth.Register)]
        public async Task<IActionResult> Register([FromBody] RegisterRequest model)
        {
            var registerResult = await _authService.RegisterAsync(model.Email, model.Password);

            if (!registerResult.IsSuccess)
            {
                return BadRequest(new RegisterFailedResponse
                {
                    Errors = registerResult.Errors
                });
            }

            return Ok(registerResult);
        }
    }
}