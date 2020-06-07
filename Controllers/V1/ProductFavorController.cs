using System;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductFavor;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductFavor;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries;
using Banana_E_Commerce_API.CustomAttributes;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Extensions;
using Banana_E_Commerce_API.Helpers;
using Banana_E_Commerce_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Banana_E_Commerce_API.Domains;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Controllers.V1
{
    [AuthorizeRoles(RoleNameEnum.Customer)]
    public class ProductFavorController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IProductFavorService _productFavorService;
        private readonly IUriService _uriService;
        private readonly IMapper _mapper;

        public ProductFavorController(
            IProductFavorService productfavorservice,
            IUriService uriService,
            IMapper mapper,
            IOptions<AppSettings> appSettings
        )
        {
            _productFavorService = productfavorservice;
            _uriService = uriService;
            _mapper = mapper;
            _appSettings = appSettings;
        }

        [HttpPost(ApiRoutes.ProductFavor.Create)]
        public async Task<IActionResult> Create([FromBody] CreateProductFavorRequest createModel)
        {
            var productFavorEntity = _mapper.Map<ProductFavorite>(createModel);
            var createdCustomerId = int.Parse(HttpContext.GetUserIdFromRequest());

            var isCreateSuccess = await _productFavorService
                .CreateAsync(productFavorEntity, createdCustomerId);

            if (!isCreateSuccess.IsSuccess)
            {
                return BadRequest(isCreateSuccess.Errors);
            }

            var productFavorUri = _uriService.GetByIdUri(
                            ApiRoutes.ProductFavor.GetById.Replace("{productFavorId}", productFavorEntity.Id.ToString()));
            var prodcutFavorResponse = _mapper.Map<ProductFavorResponse>(productFavorEntity);
            return Created(
                productFavorUri,
                new Response<ProductFavorResponse>(prodcutFavorResponse));
        }

        [HttpGet(ApiRoutes.ProductFavor.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllProductFavoritesQuery filterModel,
            [FromQuery] PaginationQuery paginModel)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginModel);
            var filter = _mapper.Map<GetAllProductFavoritesFilter>(filterModel);
            var userId = int.Parse(HttpContext.GetUserIdFromRequest());
            var productFavors = await _productFavorService.GetAllAsync(userId, pagination, filter);
            int totalProductFavors = await _productFavorService.CountAllAsync(pagination, filter);
            var responseProductFavor = _mapper.Map<List<ProductFavorResponse>>(productFavors);

            var paginationAddressesResponse = PaginationHelpers.CreatePaginatedResponse(
                _uriService,
                pagination,
                responseProductFavor,
                totalProductFavors,
                ApiRoutes.Address.GetAll
            );

            return Ok(paginationAddressesResponse);
        }

        [HttpDelete(ApiRoutes.ProductFavor.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int productFavorId)
        {
            var productFavor = await _productFavorService.GetByIdAsync(productFavorId);
            var userId = int.Parse(HttpContext.GetUserIdFromRequest());

            if (productFavor == null)
            {
                return NotFound();
            }

            var isCustomerOwnInfo = await _productFavorService.IsCustomerOwnInfo(userId, productFavor.CustomerId);
            if (!isCustomerOwnInfo)
            {   
                return Unauthorized("You don\'t have a permission");
            }

            var isDeleted = await _productFavorService.DeleteAsync(productFavorId);
            if (isDeleted)
            {
                return NoContent();
            }

            return NotFound();
        }

        [HttpDelete(ApiRoutes.ProductFavor.DeleteAll)]
        public async Task<IActionResult> DeleteAll()
        {
            var requestedUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            var isDeleted = await _productFavorService.DeleteAllAsync(requestedUserId);

            if (isDeleted)
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}