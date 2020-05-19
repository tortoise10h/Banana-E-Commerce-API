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
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries;
using Banana_E_Commerce_API.Domains;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Controllers.V1
{
    // [AuthorizeRoles(RoleNameEnum.Admin, RoleNameEnum.Customer)]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IUriService _uriService;
        private IMapper _mapper;
        private readonly IOptions<AppSettings> _appSettings;

        public ProductController(
            IProductService productService,
            IUriService uriService,
            IMapper mapper,
            IOptions<AppSettings> appSettings

        )
        {
            _productService = productService;
            _uriService = uriService;
            _mapper = mapper;
            _appSettings = appSettings;
        }

        [AuthorizeRoles(RoleNameEnum.Admin)]
        [HttpPost(ApiRoutes.Product.Create)]
        public async Task<IActionResult> Create([FromBody] CreateProductRequest model)
        {
            var createdProductUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            var productEntity = _mapper.Map<Product>(model);

            var result = await _productService.CreateAsync(productEntity, createdProductUserId);

            if (!result.IsSuccess)
            {
                return BadRequest(new CreateProductFailedResponse
                {
                    Errors = result.Errors
                });
            }

            var productResponse = _mapper.Map<ProductResponse>(productEntity);

            var locationUri = _uriService.GetByIdUri(
                ApiRoutes.Product.GetById.Replace("{productId}", productEntity.Id.ToString())
            );

            return Created(locationUri,
            new Response<ProductResponse>(productResponse));
        }

        [HttpGet(ApiRoutes.Product.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllProductsQuery filterModel,
            [FromQuery] PaginationQuery paginModel)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginModel);
            var filter = _mapper.Map<GetAllProductsFilter>(filterModel);
            var products = await _productService.GetAllAsync(pagination, filter);
            int totalProducts = await _productService.CountAllAsync(pagination, filter);
            var responseProducts = _mapper.Map<List<ProductResponse>>(products);

            var paginationProductsResponse = PaginationHelpers.CreatePaginatedResponse(
                _uriService,
                pagination,
                responseProducts,
                totalProducts,
                ApiRoutes.Product.GetAll
            );

            return Ok(paginationProductsResponse);
        }

        [AuthorizeRoles(RoleNameEnum.Admin)]
        [HttpPut(ApiRoutes.Product.Update)]
        public async Task<IActionResult> Update([FromRoute] int productId, [FromBody] UpdateProductRequest updateModel)
        {
            var productEntity = await _productService.GetByIdAsync(productId);

            if (productEntity == null)
            {
                return NotFound();
            }

            // map modified fields from request model to entity
            _mapper.Map<UpdateProductRequest, Product>(updateModel, productEntity);

            var isProductUpdated = await _productService.UpdateAsync(productEntity);

            var productResponse = _mapper.Map<ProductResponse>(productEntity);
            if (isProductUpdated)
            {
                return Ok(new Response<ProductResponse>(productResponse));
            }

            return NotFound();
        }

        [HttpGet(ApiRoutes.Product.GetById)]
        public async Task<IActionResult> GetById([FromRoute] int productId)
        {
            var result = await _productService.GetByIdAsync(productId);
            var productResponse = _mapper.Map<ProductResponse>(result);

            if (result != null)
            {
                return Ok(new Response<ProductResponse>(productResponse));
            }

            return NotFound();
        }

    }
}