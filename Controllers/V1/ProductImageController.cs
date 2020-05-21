using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductImage;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductImage;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Helpers;
using Banana_E_Commerce_API.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Banana_E_Commerce_API.Controllers.V1
{
    public class ProductImageController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IWebHostEnvironment _env;
        private readonly IProductImageService _productImageService;
        private readonly IUriService _uriService;
        private readonly IMapper _mapper;

        public ProductImageController(
            IProductImageService productImageService,
            IUriService uriService,
            IMapper mapper,
            IOptions<AppSettings> appSettings,
            IWebHostEnvironment env
        )
        {
            _productImageService = productImageService;
            _uriService = uriService;
            _mapper = mapper;
            _appSettings = appSettings;
            _env = env;
        }

        [HttpPost(ApiRoutes.ProductImage.UploadMultiples)]
        public async Task<IActionResult> Create(
            [FromForm] CreateProductImageRequest createModel
        )
        {
            var productImageEntity = _mapper.Map<ProductImage>(createModel);
            var result = await _productImageService.UploadMultipleProductImages(
                _env.ContentRootPath,
                _appSettings.Value.ProductImageDir,
                createModel.ProductId,
                createModel.Images
            );

            if (result.IsSuccess == false)
            {
                return BadRequest(result.Errors);
            }

            return Ok(
                new Response<List<ProductImageResponse>>(result.ProductImages)
            );
        }

        [HttpDelete(ApiRoutes.ProductImage.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int productImageId)
        {
            var productImage = await _productImageService.GetByIdAsync(productImageId);
            if (productImage == null)
            {
                return NotFound();
            }

            var isDeleted = await _productImageService.DeleteAsync(productImage);
            if (!isDeleted)
            {
                return BadRequest("Delete product image error");
            }

            return NoContent();
        }
    }
}