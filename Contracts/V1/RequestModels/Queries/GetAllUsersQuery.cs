using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries
{
    public class GetAllUsersQuery
    {
        public string Email { get; set; }
        public UserStatus Status { get; set; }
        public int RoleId { get; set; }

    }
}