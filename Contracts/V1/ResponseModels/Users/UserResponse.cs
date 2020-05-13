using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public UserStatus Status { get; set; }
    }
}