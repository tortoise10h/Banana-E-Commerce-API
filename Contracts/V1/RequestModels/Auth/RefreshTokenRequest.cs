using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Auth
{
    public class RefreshTokenRequest
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}