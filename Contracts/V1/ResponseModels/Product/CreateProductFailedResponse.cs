using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product
{
    public class CreateProductFailedResponse
    {
        public IEnumerable<string> Errors { get; set; }

    }
}