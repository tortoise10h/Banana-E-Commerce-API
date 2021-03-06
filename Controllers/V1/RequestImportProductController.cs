using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.RequestImportDetail;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.RequestImportProduct;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.RequestImportProduct;
using Banana_E_Commerce_API.CustomAttributes;
using Banana_E_Commerce_API.Domains;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Extensions;
using Banana_E_Commerce_API.Helpers;
using Banana_E_Commerce_API.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Banana_E_Commerce_API.Controllers.V1
{
    [AuthorizeRoles(RoleNameEnum.Admin, RoleNameEnum.StorageManager)]
    public class RequestImportProductController : ControllerBase
    {
        private readonly IRequestImportProductService _requestImportProductService;
        private readonly IRequestImportDetailService _requestImportDetail;
        private readonly IUriService _uriService;
        private IMapper _mapper;
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IWebHostEnvironment _env;

        public RequestImportProductController(
            IRequestImportProductService requestImportProductService,
            IRequestImportDetailService requestImportDetail,
            IUriService uriService,
            IMapper mapper,
            IOptions<AppSettings> appSettings,
            IWebHostEnvironment env
        )
        {
            _requestImportProductService = requestImportProductService;
            _requestImportDetail = requestImportDetail;
            _uriService = uriService;
            _mapper = mapper;
            _appSettings = appSettings;
            _env = env;
        }



        [AuthorizeRoles(RoleNameEnum.Admin)]
        [HttpPost(ApiRoutes.RequestImportProduct.Create)]
        public async Task<IActionResult> Create(
                [FromBody] CreateRequestImportProductRequest createModel
            )
        {
            var requestedUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            var requestImportDetails = _mapper.Map<IEnumerable<CreateRequestImportDetailRequest>, IEnumerable<RequestImportDetail>>(createModel.RequestImportDetails);
            var result = await _requestImportProductService.CreateAsync(
                requestImportDetails,
                requestedUserId
            );

            if (result.IsSuccess == false)
            {
                return BadRequest(result.Errors);
            }

            var requestImportProductResponse = _mapper.Map<RequestImportProductResponse>(
                result.RequestImportProduct);

            var locationUri = _uriService.GetByIdUri(
                ApiRoutes.Product.GetById.Replace(
                    "{requestImportProductId}",
                    result.RequestImportProduct.Id.ToString())
            );

            return Created(locationUri,
                new Response<RequestImportProductResponse>(requestImportProductResponse));
        }



        [HttpGet(ApiRoutes.RequestImportProduct.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllRequestImportProductsQuery filterModel,
            [FromQuery] PaginationQuery paginModel)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginModel);
            var filter = _mapper.Map<GetAllRequestImportProductsFilter>(filterModel);
            var requestImportProducts = await _requestImportProductService
                .GetAllAsync(pagination, filter);
            int totalRequestImportProducts = await _requestImportProductService
                .CountAllAsync(pagination, filter);
            var responseRequestImportProducts = _mapper
                .Map<List<RequestImportProductResponse>>(requestImportProducts);

            var paginationRequestImportProductsResponse = PaginationHelpers
                .CreatePaginatedResponse(
                    _uriService,
                    pagination,
                    responseRequestImportProducts,
                    totalRequestImportProducts,
                    ApiRoutes.RequestImportProduct.GetAll
                );

            return Ok(paginationRequestImportProductsResponse);
        }



        [HttpGet(ApiRoutes.RequestImportProduct.GetById)]
        public async Task<IActionResult> GetById(
            [FromRoute] int requestImportProductId
        )
        {
            var requestImportProduct = await _requestImportProductService
                .GetByIdAsync(requestImportProductId);
            if (requestImportProduct == null)
            {
                return NotFound();
            }

            var requestImportProductResponse = _mapper
                .Map<RequestImportProductResponse>(requestImportProduct);

            return Ok(new Response<RequestImportProductResponse>(requestImportProductResponse));
        }



        [AuthorizeRoles(RoleNameEnum.Admin)]
        [HttpDelete(ApiRoutes.RequestImportProduct.Cancel)]
        public async Task<IActionResult> CancelRequest(
            [FromRoute] int requestImportProductId
        )
        {
            var requestImportProduct = await _requestImportProductService
                .GetByIdAsync(requestImportProductId);
            if (requestImportProduct == null)
            {
                return NotFound();
            }

            var cancelResult = await _requestImportProductService
                .CancelRequestAsync(requestImportProduct);

            if (cancelResult.IsSuccess == false)
            {
                return BadRequest(cancelResult.Errors);
            }

            var requestImportProductResponse = _mapper.Map<RequestImportProductResponse>(
                requestImportProduct);

            return Ok(new Response<RequestImportProductResponse>(requestImportProductResponse));
        }
    }

}