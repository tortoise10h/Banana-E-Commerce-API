using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Role
{
    public class RoleResponse
    {
        public int Id { get; set; }
        public RoleNameEnum RoleName { get; set; }
    }
}