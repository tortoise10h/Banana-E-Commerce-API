using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.RequestImportProduct
{
    public class CalculateProductsPriceResult
    {
        public bool IsSuccess { get; set; }
        public List<string> Errors { get; set; }
    }
}