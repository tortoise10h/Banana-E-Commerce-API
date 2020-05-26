using System.Collections.Generic;
namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users
{
    public class UpdateUserPasswordResult
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}