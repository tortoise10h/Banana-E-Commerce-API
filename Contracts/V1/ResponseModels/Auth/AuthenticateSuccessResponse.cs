using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Auth
{
    public class AuthenticateSuccessResponse
    {
        public string Token { get; set; }
        public UserResponse User { get; set; }
    }
}