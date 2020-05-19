using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Auth
{
    public class WriteTokenForLoginUserResult
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public UserResponse User { get; set; }
    }
}