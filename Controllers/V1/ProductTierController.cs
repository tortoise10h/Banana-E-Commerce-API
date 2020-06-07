using System;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductTier;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTier;
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
    [AuthorizeRoles(RoleNameEnum.Admin)]
    public class ProductTierController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IProductTierService _productTierService;
        private readonly IUriService _uriService;
        private readonly IMapper _mapper;

        public ProductTierController(
            IProductTierService producttierservice,
            IUriService uriService,
            IMapper mapper,
            IOptions<AppSettings> appSettings
        )
        {
            _productTierService = producttierservice;
            _uriService = uriService;
            _mapper = mapper;
            _appSettings = appSettings;
        }

        [HttpGet(ApiRoutes.ProductTier.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllProductTiersQuery filterModel,
            [FromQuery] PaginationQuery paginModel)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginModel);
            var filter = _mapper.Map<GetAllProductTiersFilter>(filterModel);
            var productTiers = await _productTierService.GetAllAsync(pagination, filter);
            int totalproductTiers = await _productTierService.CountAllAsync(pagination, filter);
            var responseProductTier = _mapper.Map<List<ProductTierResponse>>(productTiers);

            var paginationAddressesResponse = PaginationHelpers.CreatePaginatedResponse(
                _uriService,
                pagination,
                responseProductTier,
                totalproductTiers,
                ApiRoutes.Address.GetAll
            );

            return Ok(paginationAddressesResponse);
        }

        [HttpPut(ApiRoutes.ProductTier.Update)]
        public async Task<IActionResult> Update(
            [FromRoute] int productTierId,
            [FromBody] UpdateProductTierRequest updateModel)
        {
            var productTierEntity = await _productTierService.GetByIdAsync(productTierId);

            if (productTierEntity == null)
            {
                return NotFound();
            }

            // map modified fields from request model to entity
            _mapper.Map<UpdateProductTierRequest, ProductTier>(updateModel, productTierEntity);

            var isProductTierUpdated = await _productTierService.UpdateAsync(productTierEntity);
            if (!isProductTierUpdated.IsSuccess)
            {
                 return BadRequest(
                    isProductTierUpdated.Errors
                );
            }

            var productTierResponse = _mapper.Map<ProductTierResponse>(productTierEntity);
            return Ok(new Response<ProductTierResponse>(productTierResponse));
        }

        [HttpGet(ApiRoutes.ProductTier.GetById)]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int productTierId)
        {
            var result = await _productTierService.GetByIdAsync(productTierId);
            var productTierResponse = _mapper.Map<ProductTierResponse>(result);

            if (result != null)
            {
                return Ok(new Response<ProductTierResponse>(productTierResponse));
            }

            return NotFound();
        }

    }
}