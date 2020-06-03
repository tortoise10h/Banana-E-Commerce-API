using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ImportBill;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ImportBillDetail;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ImportBill;
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
    [AuthorizeRoles(RoleNameEnum.StorageManager, RoleNameEnum.Admin)]
    public class ImportBillController : ControllerBase
    {
        private readonly IImportBillService _importBillService;
        private readonly IUriService _uriService;
        private IMapper _mapper;
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IWebHostEnvironment _env;

        public ImportBillController(
            IImportBillService importBillService,
            IUriService uriService,
            IMapper mapper,
            IOptions<AppSettings> appSettings,
            IWebHostEnvironment env
        )
        {
            _importBillService = importBillService;
            _uriService = uriService;
            _mapper = mapper;
            _appSettings = appSettings;
            _env = env;
        }

        [AuthorizeRoles(RoleNameEnum.StorageManager)]
        [HttpPost(ApiRoutes.ImportBill.Create)]
        public async Task<IActionResult> Create(
                    [FromForm] CreateImportBillRequest createModel
                )
        {
            var requestedUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            ImportBill importBillEntity = new ImportBill
            {
                RequestImportProductId = createModel.RequestImportProductId
            };
            var importBillDetails = _mapper
                .Map<IEnumerable<CreateImportBillDetailRequest>, IEnumerable<ImportBillDetail>>(
                    createModel.ImportBillDetails);

            var result = await _importBillService.CreateAsync(
                importBillEntity,
                importBillDetails,
                requestedUserId,
                createModel.SupplierBillImage,
                createModel.StorageManagerBillImage,
                _appSettings.Value.ImportBillImageDir,
                _env.ContentRootPath
            );

            if (result.IsSuccess == false)
            {
                return BadRequest(result.Errors);
            }

            var locationUri = _uriService.GetByIdUri(
                ApiRoutes.ImportBill.GetById.Replace(
                    "{importBillId}",
                    result.ImportBill.Id.ToString())
            );
            var importBillResponse = _mapper.Map<ImportBillResponse>(result.ImportBill);

            return Created(locationUri,
                new Response<ImportBillResponse>(importBillResponse));
        }

        [HttpGet(ApiRoutes.ImportBill.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllImportBillsQuery filterModel,
            [FromQuery] PaginationQuery paginModel
        )
        {
            var pagination = _mapper.Map<PaginationFilter>(paginModel);
            var filter = _mapper.Map<GetAllImportBillsFilter>(filterModel);
            var importBills = await _importBillService
                .GetAllAsync(pagination, filter);
            int totalRequestImportProducts = await _importBillService
                .CountAllAsync(pagination, filter);
            var responseImportBills = _mapper
                .Map<List<ImportBillResponse>>(importBills);

            var paginationImportBillsResponse = PaginationHelpers
                .CreatePaginatedResponse(
                    _uriService,
                    pagination,
                    responseImportBills,
                    totalRequestImportProducts,
                    ApiRoutes.RequestImportProduct.GetAll
                );

            return Ok(paginationImportBillsResponse);
        }

        [HttpGet(ApiRoutes.ImportBill.GetById)]
        public async Task<IActionResult> GetById(
            [FromRoute] int importBillId
        )
        {
            var importBill = await _importBillService
                .GetByIdAsync(importBillId);
            if (importBill == null)
            {
                return NotFound();
            }

            var importBillResponse = _mapper
                .Map<ImportBillResponse>(importBill);

            return Ok(new Response<ImportBillResponse>(
                importBillResponse));
        }
    }
}