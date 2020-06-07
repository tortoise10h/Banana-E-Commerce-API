using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductTierTransferReport;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTierTransferReport;
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
    [AuthorizeRoles(RoleNameEnum.StorageManager, RoleNameEnum.Admin)]
    public class ProductTierTransferReportController : ControllerBase
    {
        private readonly IProductTierTransferReportService _productTierTransferReportService;
        private readonly IUriService _uriService;
        private IMapper _mapper;
        private readonly IOptions<AppSettings> _appSettings;

        public ProductTierTransferReportController(
            IProductTierTransferReportService productTierTransferReportService,
            IUriService uriService,
            IMapper mapper,
            IOptions<AppSettings> appSettings
        )
        {
            _productTierTransferReportService = productTierTransferReportService;
            _uriService = uriService;
            _mapper = mapper;
            _appSettings = appSettings;
        }

        [AuthorizeRoles(RoleNameEnum.StorageManager)]
        [HttpPost(ApiRoutes.ProductTierTransferReport.Create)]
        public async Task<IActionResult> Create(
            [FromBody] CreateProductTierTransferReportRequest createModel
        )
        {
            int requestedUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            var productTierTransferReportEntity = _mapper
                .Map<ProductTierTransferReport>(createModel);
            var createResult = await _productTierTransferReportService
                .CreateAsync(
                    productTierTransferReportEntity,
                    requestedUserId);

            if (createResult.IsSuccess == false)
            {
                return BadRequest(createResult.Errors);
            }

            var locationUri = _uriService.GetByIdUri(
                ApiRoutes.ProductTierTransferReport.GetById
                    .Replace(
                        "{productTierTransferReportId}",
                        productTierTransferReportEntity.Id.ToString())
            );
            var productTierTransferReportResponse = _mapper
                .Map<ProductTierTransferReportResponse>(createResult.EntityReturn);

            return Created(locationUri,
                new Response<ProductTierTransferReportResponse>(productTierTransferReportResponse));
        }



        [AuthorizeRoles(RoleNameEnum.StorageManager)]
        public async Task<IActionResult> BulkCreate(
            [FromBody] BulkCreateProductTierTransferReportRequest createModel
        )
        {
            int requestedUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            var productTierTransferReports = _mapper
                .Map<IEnumerable<CreateProductTierTransferReportRequest>, IEnumerable<ProductTierTransferReport>>(
                    createModel.productTierTransferReports);
            var bulkCreateResults = await _productTierTransferReportService
                .BulkCreateAsync(
                    productTierTransferReports,
                    requestedUserId);

            /** Classify succeeded items and failed items in result to return*/
            List<ProductTierTransferReportResponse> successList = new List<ProductTierTransferReportResponse>();
            List<BulkCreateFailSingleResponse> failList = new List<BulkCreateFailSingleResponse>();

            foreach (var result in bulkCreateResults)
            {
                var entityResponse = _mapper
                        .Map<ProductTierTransferReportResponse>(
                            result.EntityReturn
                        );
                if (result.IsSuccess == false)
                {
                    var failItem = new BulkCreateFailSingleResponse
                    {
                        Errors = result.Errors,
                        ProductTierTransferReport = entityResponse
                    };

                    failList.Add(failItem);
                }

                successList.Add(entityResponse);
            }

            return Ok(new Response<BulkCreateResponse>(
                new BulkCreateResponse
                {
                    SuccessList = successList,
                    FailList = failList
                }
            ));
        }



        [HttpGet(ApiRoutes.ProductTierTransferReport.GetById)]
        public async Task<IActionResult> GetById(
            [FromRoute] int productTierTransferReportId
        )
        {
            var result = await _productTierTransferReportService
                .GetByIdAsync(productTierTransferReportId);

            if (result == null)
            {
                return NotFound();
            }

            var productTierTransferReportResponse = _mapper
                .Map<ProductTierTransferReportResponse>(result);

            return Ok(
                new Response<ProductTierTransferReportResponse>(
                    productTierTransferReportResponse));
        }


        [HttpGet(ApiRoutes.ProductTierTransferReport.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllProductTierTransferReportsQuery filterModel,
            [FromQuery] PaginationQuery paginModel
        )
        {
            var pagination = _mapper.Map<PaginationFilter>(paginModel);
            var filter = _mapper.Map<GetAllProductTierTransferReportsFilter>(filterModel);
            var productTierTransferReports = await _productTierTransferReportService
                .GetAllAsync(pagination, filter);
            int totalProductTierTransferReports = await _productTierTransferReportService
                .CountAllAsync(pagination, filter);
            var responseProductTierTransferReports = _mapper
                .Map<List<ProductTierTransferReportResponse>>(productTierTransferReports);

            var paginationProductTransferReportsResponse = PaginationHelpers
                .CreatePaginatedResponse(
                    _uriService,
                    pagination,
                    responseProductTierTransferReports,
                    totalProductTierTransferReports,
                    ApiRoutes.ProductTierTransferReport.GetAll
                );

            return Ok(paginationProductTransferReportsResponse);
        }


        [AuthorizeRoles(RoleNameEnum.StorageManager)]
        [HttpDelete(ApiRoutes.ProductTierTransferReport.Delete)]
        public async Task<IActionResult> Delete(
                    [FromRoute] int productTierTransferReportId
                )
        {
            var productTierTransferReport = await _productTierTransferReportService
                .GetByIdAsync(productTierTransferReportId);
            if (productTierTransferReport == null)
            {
                return NotFound();
            }

            var isDeleted = await _productTierTransferReportService
                .DeleteAsync(productTierTransferReport);

            if (!isDeleted)
            {
                return BadRequest("Lỗi xoá phiếu chuyển hàng, xin thử lại");
            }

            return NoContent();

        }
    }
}