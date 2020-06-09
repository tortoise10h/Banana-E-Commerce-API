using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.RatingImage
{
    public class UploadMultipleRatingImagesResult
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public List<RatingImageResponse> RatingImages { get; set; }
    }
}