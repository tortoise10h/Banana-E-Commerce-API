using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ImportBill;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ImportBillDetail;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ImportBill;
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
    [AuthorizeRoles(RoleNameEnum.StorageManager)]
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
    }
}