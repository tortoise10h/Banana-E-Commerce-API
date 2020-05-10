using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Auth
{
    public class RegisterFailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}