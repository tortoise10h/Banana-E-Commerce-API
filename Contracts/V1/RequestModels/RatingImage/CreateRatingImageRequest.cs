using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.RatingImage
{
    public class CreateRatingImageRequest
    {
        public int RatingId { get; set; }
        public int ProductTierId { get; set; }
        public IEnumerable<IFormFile> Images { get; set; }
    }
}