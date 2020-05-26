using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Banana_E_Commerce_API.Helpers;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authorization;
using Banana_E_Commerce_API.Services;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Banana_E_Commerce_API.Entities;
using Microsoft.AspNetCore.Http;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Users;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.CustomAttributes;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Extensions;

namespace Banana_E_Commerce_API.Controllers
{
    [AuthorizeRoles(RoleNameEnum.Admin, RoleNameEnum.Customer)]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public UsersController(
            IUserService userService,
            IMapper mapper,
            IOptions<AppSettings> appSettings
        )
        {
            _userService = userService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        [HttpGet(ApiRoutes.Users.Get)]
        public async Task<IActionResult> GetById(int userId)
        {
            var requestedUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            var isUserOwnInfo = await _userService.IsUserOwnInfo(userId, requestedUserId);
            var isAdmin = await _userService.IsAdmin(requestedUserId);

            if (!isUserOwnInfo && !isAdmin)
            {   
                return Unauthorized("You don\'t have a permission");
            }

            var result = await _userService.GetByIdAsync(userId);
            var userResponse = _mapper.Map<UserResponse>(result);

            if (result != null)
            {
                return Ok(new Response<UserResponse>(userResponse));
            }

            return NotFound();
        }

        [HttpPut(ApiRoutes.Users.Update)]
        public async Task<IActionResult> UpdateUserPassword(
            [FromRoute] int userId,
            [FromBody] UpdateUserPasswordRequest updateModel)
        {
            var userEntity = await _userService.GetByIdAsync(userId);
            
            if (userEntity == null)
            {
                return NotFound();
            }

            var id = int.Parse(HttpContext.GetUserIdFromRequest());
            var isUserOwnInfo = await _userService.IsUserOwnInfo(userId, id);

            if (!isUserOwnInfo)
            {   
                return Unauthorized("You don\'t have a permission");
            }

            _mapper.Map<UpdateUserPasswordRequest, User>(updateModel, userEntity);

            var isUserUpdated = await _userService.UpdateUserPassword(userEntity, updateModel.oldPassword, updateModel.newPassword, updateModel.confirmPassword);
            if (!isUserUpdated.IsSuccess)
            {
                return BadRequest(new UpdateUserPasswordResult
                {
                    Errors = isUserUpdated.Errors
                });
            }

            var userResponse = _mapper.Map<UserResponse>(userEntity);
            return Ok("Update password successfully");

        }
    }
}
