using System;
using Banana_E_Commerce_API.Enums;
using Microsoft.AspNetCore.Authorization;

namespace Banana_E_Commerce_API.CustomAttributes
{
    public class AuthorizeRolesAttribute : AuthorizeAttribute
    {
        public AuthorizeRolesAttribute(params RoleNameEnum[] roles)
        {
            Roles = String.Join(",", roles);
        }
    }
}