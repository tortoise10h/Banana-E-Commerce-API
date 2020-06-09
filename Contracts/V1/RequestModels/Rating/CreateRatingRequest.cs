using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Rating
{
    public class CreateRatingRequest
    {
        public int StarNum { get; set; }
        public string Comment { get; set; }
        public int ProductTierId { get; set; }
        public IEnumerable<IFormFile> Images { get; set; }
    }
}