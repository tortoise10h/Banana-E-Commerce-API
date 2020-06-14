using System;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Rating;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Rating;
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
using Microsoft.AspNetCore.Hosting;

namespace Banana_E_Commerce_API.Controllers.V1
{
    public class RatingController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IRatingService _ratingService;
        private readonly IUriService _uriService;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;

        public RatingController(
            IRatingService ratingService,
            IUriService uriService,
            IMapper mapper,
            IOptions<AppSettings> appSettings,
            IWebHostEnvironment env
        )
        {
            _ratingService = ratingService;
            _uriService = uriService;
            _mapper = mapper;
            _appSettings = appSettings;
            _env = env;
        }

        [AuthorizeRoles(RoleNameEnum.Customer)]
        [HttpPost(ApiRoutes.Rating.Create)]
        public async Task<IActionResult> Create([FromForm] CreateRatingRequest createModel)
        {
            var ratingEntity = _mapper.Map<Rating>(createModel);
            var createdCustomerId = int.Parse(HttpContext.GetUserIdFromRequest());

            var result = await _ratingService.CreateAsync(
                ratingEntity,
                createdCustomerId,
                createModel.Images,
                _appSettings.Value.RatingImageDir,
                _env.ContentRootPath);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Errors);
            }

            var ratingUri = _uriService.GetByIdUri(
                            ApiRoutes.Rating.GetById.Replace("{ratingId}", ratingEntity.Id.ToString()));
            var ratingResponse = _mapper.Map<RatingResponse>(ratingEntity);
            return Created(
                ratingUri,
                new Response<RatingResponse>(ratingResponse));
        }

        [HttpGet(ApiRoutes.Rating.GetById)]
        public async Task<IActionResult> GetById([FromRoute] int ratingId)
        {
            var result = await _ratingService.GetByIdAsync(ratingId);
            var ratingResponse = _mapper.Map<RatingResponse>(result);

            if (result != null)
            {
                return Ok(new Response<RatingResponse>(ratingResponse));
            }
            return NotFound();
        }

        [HttpGet(ApiRoutes.Rating.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllRatingQuery filterModel,
            [FromQuery] PaginationQuery paginModel)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginModel);
            var filter = _mapper.Map<GetAllRatingFilter>(filterModel);
            var rating = await _ratingService.GetAllAsync(pagination, filter);
            int totalRating = await _ratingService.CountAllAsync(pagination, filter);
            var responseRating = _mapper.Map<List<RatingResponse>>(rating);

            var paginationRatingResponse = PaginationHelpers.CreatePaginatedResponse(
                _uriService,
                pagination,
                responseRating,
                totalRating,
                ApiRoutes.Rating.GetAll
            );

            return Ok(paginationRatingResponse);
        }

        [HttpPut(ApiRoutes.Rating.Update)]
        public async Task<IActionResult> Update(
            [FromRoute] int ratingId, 
            [FromBody] UpdateRatingRequest updateModel)
        {
            var ratingEntity = await _ratingService.GetByIdAsync(ratingId);
            var userId = int.Parse(HttpContext.GetUserIdFromRequest());
            if (ratingEntity == null)
            {
                return NotFound();
            }

            // validate customer valid to update address
            var isCustomerValidRating = await _ratingService.IsCustomerOwnRating(userId, ratingId);
            if (!isCustomerValidRating)
            {
                return Forbid();
            }

            _mapper.Map<UpdateRatingRequest, Rating>(updateModel, ratingEntity);
            var isRatingUpdated = await _ratingService.UpdateAsync(ratingEntity);

            var ratingResponse = _mapper.Map<RatingResponse>(ratingEntity);
            if (isRatingUpdated)
            {
                return Ok(new Response<RatingResponse>(ratingResponse));
            }

            return NotFound();
        }

        [HttpDelete(ApiRoutes.Rating.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int ratingId)
        {
            var ratingEntity = await _ratingService.GetByIdAsync(ratingId);
            var userId = int.Parse(HttpContext.GetUserIdFromRequest());

            if (ratingEntity == null)
            {
                return NotFound();
            }

            var isCustomerValidRating = await _ratingService.IsCustomerOwnRating(userId, ratingId);
            if (!isCustomerValidRating)
            {   
                return Unauthorized("Bạn không có quyền truy cập");
            }

            var isDeleted = await _ratingService.DeleteAsync(ratingId);
            if (isDeleted)
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}