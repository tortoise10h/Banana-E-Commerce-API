using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Domains
{
    public class GetAllUserFilter
    {
        public string Email { get; set; }
        public UserStatus Status { get; set; }
        public int RoleId { get; set; }
    }
}