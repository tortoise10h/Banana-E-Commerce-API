using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels
{
    public class ErrorResponse
    {
        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>();
    }
}