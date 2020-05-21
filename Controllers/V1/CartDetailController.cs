using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.CartDetail;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.CartDetailModels;
using Banana_E_Commerce_API.CustomAttributes;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Extensions;
using Banana_E_Commerce_API.Helpers;
using Banana_E_Commerce_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Banana_E_Commerce_API.Controllers.V1
{
    [AuthorizeRoles(RoleNameEnum.Customer)]
    public class CartDetailController : ControllerBase
    {
        private readonly ICartDetailService _cartDetailService;
        private readonly IUriService _uriService;
        private IMapper _mapper;
        private readonly IOptions<AppSettings> _appSettings;

        public CartDetailController(
            ICartDetailService cartDetailService,
            IUriService uriService,
            IMapper mapper,
            IOptions<AppSettings> appSettings

        )
        {
            _cartDetailService = cartDetailService;
            _uriService = uriService;
            _mapper = mapper;
            _appSettings = appSettings;
        }

        [HttpPost(ApiRoutes.CartDetail.AddToCart)]
        public async Task<IActionResult> Create([FromBody] AddProductToCartRequest model)
        {
            var requestedUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            var cartDetailEntity = _mapper.Map<CartDetail>(model);

            var result = await _cartDetailService.AddProductToCartAsync(cartDetailEntity);

            if (!result.IsSuccess)
            {
                return BadRequest(new AddProductToCartFailedResponse
                {
                    Errors = result.Errors
                });
            }

            var cartDetailResponse = _mapper.Map<CartDetailResponse>(cartDetailEntity);

            var locationUri = _uriService.GetByIdUri(
                ApiRoutes.Product.GetById.Replace("{cartDetailId}", cartDetailEntity.Id.ToString())
            );

            return Created(locationUri,
                new Response<CartDetailResponse>(cartDetailResponse));
        }

        [HttpGet(ApiRoutes.CartDetail.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllCartDetailsQuery filterModel,
            [FromQuery] PaginationQuery paginModel)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginModel);
            var filter = _mapper.Map<GetAllCartDetailsFilter>(filterModel);
            var cartDetails = await _cartDetailService.GetAllAsync(pagination, filter);
            int totalCartDetails = await _cartDetailService.CountAllAsync(pagination, filter);
            var responseCartDetails = _mapper.Map<List<CartDetailResponse>>(cartDetails);

            var paginationCartDetailsResponse = PaginationHelpers.CreatePaginatedResponse(
                _uriService,
                pagination,
                responseCartDetails,
                totalCartDetails,
                ApiRoutes.CartDetail.GetAll
            );

            return Ok(paginationCartDetailsResponse);
        }

        [HttpPut(ApiRoutes.CartDetail.Update)]
        public async Task<IActionResult> Update(
            [FromRoute] int cartDetailId,
            [FromBody] UpdateCartDetailRequest updateModel)
        {
            var cartDetailEntity = await _cartDetailService.GetByIdAsync(cartDetailId);

            if (cartDetailEntity == null)
            {
                return NotFound();
            }

            // map modified fields from request model to entity
            _mapper.Map<UpdateCartDetailRequest, CartDetail>(updateModel, cartDetailEntity);

            var updateResult = await _cartDetailService.UpdateAsync(cartDetailEntity);

            var cartDetailResponse = _mapper.Map<CartDetailResponse>(cartDetailEntity);
            if (updateResult.IsSuccess)
            {
                return Ok(new Response<CartDetailResponse>(cartDetailResponse));
            }

            return NotFound();
        }

        [HttpGet(ApiRoutes.CartDetail.GetById)]
        public async Task<IActionResult> GetById([FromRoute] int cartDetailId)
        {
            var result = await _cartDetailService.GetByIdAsync(cartDetailId);
            var cartDetailResponse = _mapper.Map<CartDetailResponse>(result);

            if (result != null)
            {
                return Ok(new Response<CartDetailResponse>(cartDetailResponse));
            }

            return NotFound();
        }

        [HttpDelete(ApiRoutes.CartDetail.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int cartDetailId)
        {
            var cartDetail = await _cartDetailService.GetByIdAsync(cartDetailId);
            var isDeleted = await _cartDetailService.DeleteAsync(cartDetailId);

            if (isDeleted)
            {
                var cartDetailResponse = _mapper.Map<CartDetailResponse>(cartDetail);
                return Ok(new Response<CartDetailResponse>(cartDetailResponse));
            }

            return NotFound();
        }

        [HttpDelete(ApiRoutes.CartDetail.DeleteAll)]
        public async Task<IActionResult> DeleteAll()
        {
            var requestedUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            var isDeleted = await _cartDetailService.DeleteAllAsync(requestedUserId);

            if (isDeleted)
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}