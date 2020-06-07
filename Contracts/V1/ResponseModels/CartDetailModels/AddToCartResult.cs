using System.Collections.Generic;
using E = Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.CartDetailModels
{
    public class AddToCartResult
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public E.CartDetail CartDetail { get; set; }
    }
}