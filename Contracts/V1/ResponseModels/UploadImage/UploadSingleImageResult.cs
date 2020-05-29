using System.Collections.Generic;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.UploadImage
{
    public class UploadSingleImageResult
    {
        public bool IsSuccess { get; set; }
        public string ImageLocation { get; set; }
        public List<string> Errors { get; set; }
    }
}