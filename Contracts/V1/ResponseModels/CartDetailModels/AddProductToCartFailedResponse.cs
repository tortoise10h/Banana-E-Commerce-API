using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.CartDetailModels
{
    public class AddProductToCartFailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}