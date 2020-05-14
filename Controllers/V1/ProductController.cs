using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Product;
using Banana_E_Commerce_API.CustomAttributes;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Helpers;
using Banana_E_Commerce_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using Banana_E_Commerce_API.Extensions;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product;
using Banana_E_Commerce_API.Contracts.V1;

namespace Banana_E_Commerce_API.Controllers.V1
{
    [AuthorizeRoles(RoleNameEnum.Admin)]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private IMapper _mapper;
        private readonly IOptions<AppSettings> _appSettings;

        public ProductController(
            IProductService productService,
            IMapper mapper,
            IOptions<AppSettings> appSettings

        )
        {
            _productService = productService;
            _mapper = mapper;
            _appSettings = appSettings;
        }

        [HttpPost(ApiRoutes.Product.Create)]
        public async Task<IActionResult> Create([FromBody] CreateProductRequest model)
        {
            var createdProductUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            var productEntity = _mapper.Map<Product>(model);

            var result = await _productService.CreateAsync(productEntity, createdProductUserId);

            var productResponse = _mapper.Map<ProductResponse>(productEntity);

            return Created("/api/v1/product/1", productResponse);
        }

    }
}