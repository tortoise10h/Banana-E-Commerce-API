using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Category
{
    public class CreateCategoryFailResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}