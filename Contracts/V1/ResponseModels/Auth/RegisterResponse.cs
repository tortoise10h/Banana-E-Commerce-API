using System.Collections;
using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Auth
{
    public class RegisterResponse
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }

        public UserResponse user { get; set; }
    }
}