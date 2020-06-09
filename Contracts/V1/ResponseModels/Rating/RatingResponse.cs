using System;
using System.Collections.Generic;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.RatingImage;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Rating
{
    public class RatingResponse
    {
        public int Id { get; set; }
        public int StarNum { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<RatingImageResponse> RatingImages { get; set; }
        public CustomerResponseOfRating Customer { get; set; }
        public ProductTierResponseOfRating ProductTier { get; set; }
    }
}