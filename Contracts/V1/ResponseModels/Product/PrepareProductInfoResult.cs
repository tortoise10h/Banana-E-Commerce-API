using System.Collections.Generic;
using E = Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product
{
    public class PrepareProductInfoResult
    {
        public bool IsSuccess { get; set; }
        public List<string> Errors { get; set; }
        public E.Product Product { get; set; }
    }
}