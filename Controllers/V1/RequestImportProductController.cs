using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.RequestImportDetail;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.RequestImportProduct;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.RequestImportProduct;
using Banana_E_Commerce_API.CustomAttributes;
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

        // [HttpPut(ApiRoutes.RequestImportProduct.Update)]
        // public async Task<IActionResult> Update(
        //     [FromRoute] int requestImportProductId,
        //     [FromBody] UpdateRequestImportProductRequest updateModel
        // )
        // {
        //     var requestImportProduct = await _requestImportProductService
        //         .GetByIdAsync(requestImportProductId);
        //     if (requestImportProduct == null)
        //     {
        //         return NotFound();
        //     }

        //     var isUdpate
        // }
    }
}