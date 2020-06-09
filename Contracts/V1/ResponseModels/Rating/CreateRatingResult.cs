using System.Collections.Generic;
using E = Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Rating
{
    public class CreateRatingResult
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public E.Rating Rating { get; set; }
    }
}