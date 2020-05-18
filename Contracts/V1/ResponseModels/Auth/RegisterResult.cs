using System.Collections;
using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users;
using Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Auth
{
    public class RegisterResult
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }

        public User User { get; set; }
    }
}