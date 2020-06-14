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
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries;
using Banana_E_Commerce_API.Domains;

namespace Banana_E_Commerce_API.Controllers
{
    [AuthorizeRoles(RoleNameEnum.Admin, RoleNameEnum.Customer, RoleNameEnum.StorageManager)]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private readonly IUriService _uriService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public UsersController(
            IUserService userService,
            IUriService uriService,
            IMapper mapper,
            IOptions<AppSettings> appSettings
        )
        {
            _userService = userService;
            _uriService = uriService;
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
                return Unauthorized("Bạn không có quyền tra cứu thông tin tài khoản này");
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
                return Unauthorized("Bạn không có quyền thay đổi thông tin tài khoản này");
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
            return Ok("Cập nhật mật khẩu thành công");

        }

        [AuthorizeRoles(RoleNameEnum.Admin)]
        [HttpDelete(ApiRoutes.Users.Banned)]
        public async Task<IActionResult> BannedUser([FromRoute] int userId)
        {
            int requestedUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            var userEntity = await _userService.GetByIdAsync(userId);
            var isAdminAccount = await _userService.IsAdmin(userId);
            var isAdmin = await _userService.IsAdmin(requestedUserId);

            if (userEntity == null)
            {
                return NotFound();
            }

            if (!isAdmin)
            {   
                return Unauthorized("Bạn không có quyền khoá tài khoản người dùng");
            }

            if (isAdminAccount)
            {   
                return BadRequest("Bạn không thể khoá tài khoản này");
            }

            var isDeleted = await _userService.BannedUserAsync(userId);
            if (isDeleted)
            {
                return NoContent();
            }

            return NotFound();
        }

        [AuthorizeRoles(RoleNameEnum.Admin)]
        [HttpPut(ApiRoutes.Users.Unbanned)]
        public async Task<IActionResult> UnbannedUser([FromRoute] int userId)
        {
            int requestedUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            var userEntity = await _userService.GetByIdAsync(userId);
            var isAdminAccount = await _userService.IsAdmin(userId);
            var isAdmin = await _userService.IsAdmin(requestedUserId);
            var isUserBanned = await _userService.isUserBanned(userId);

            if (userEntity == null)
            {
                return NotFound();
            }

            if (!isAdmin)
            {   
                return Unauthorized("Bạn không có quyền mở khoá tài khoản người dùng");
            }

            if (isAdminAccount || !isUserBanned)
            {   
                return BadRequest();
            }

            var isUpdated = await _userService.UnbannedUserAsync(userId);
            if (isUpdated)
            {
                return NoContent();
            }

            return NotFound();
        }


        [AuthorizeRoles(RoleNameEnum.Admin, RoleNameEnum.StorageManager)]
        [HttpGet(ApiRoutes.Users.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllUsersQuery filterModel,
            [FromQuery] PaginationQuery paginModel)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginModel);
            var filter = _mapper.Map<GetAllUserFilter>(filterModel);
            var users = await _userService.GetAllAsync(pagination, filter);
            int totalUsers = await _userService.CountAllAsync(pagination, filter);
            var responseUser = _mapper.Map<List<UserResponse>>(users);

            var paginationUsersResponse = PaginationHelpers.CreatePaginatedResponse(
                _uriService,
                pagination,
                responseUser,
                totalUsers,
                ApiRoutes.Users.GetAll
            );

            return Ok(paginationUsersResponse);
        }
    }
}
