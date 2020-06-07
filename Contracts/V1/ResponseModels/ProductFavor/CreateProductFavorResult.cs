using System.Collections.Generic;
using Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductFavor
{
    public class CreateProductFavorResult
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public ProductFavorite ProductFavorite { get; set; }
    }
}