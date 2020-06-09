using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.RatingImage;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.RatingImage;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;
using Banana_E_Commerce_API.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Banana_E_Commerce_API.Controllers.V1
{
    public class RatingImageController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IWebHostEnvironment _env;
        private readonly IRatingImageService _ratingImageService;
        private readonly IUriService _uriService;
        private readonly IMapper _mapper;

        public RatingImageController(
            IRatingImageService ratingImageService,
            IUriService uriService,
            IMapper mapper,
            IOptions<AppSettings> appSettings,
            IWebHostEnvironment env
        )
        {
            _ratingImageService = ratingImageService;
            _uriService = uriService;
            _mapper = mapper;
            _appSettings = appSettings;
            _env = env;
        }

        [HttpPost(ApiRoutes.RatingImage.UploadMultiples)]
        public async Task<IActionResult> Create(
            [FromForm] CreateRatingImageRequest createModel
        )
        {
            var ratingImageEntity = _mapper.Map<RatingImage>(createModel);
            var result = await _ratingImageService.UploadMultipleRatingImages(
                _env.ContentRootPath,
                _appSettings.Value.RatingImageDir,
                createModel.RatingId,
                createModel.ProductTierId,
                createModel.Images
            );

            if (result.IsSuccess == false)
            {
                return BadRequest(result.Errors);
            }

            return Ok(
                new Response<List<RatingImageResponse>>(result.RatingImages)
            );
        }
    }

    
}