using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductExportBill;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductExportDetail;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductExportBill;
using Banana_E_Commerce_API.CustomAttributes;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Banana_E_Commerce_API.Extensions;
using Banana_E_Commerce_API.Helpers;
using Banana_E_Commerce_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Banana_E_Commerce_API.Controllers.V1
{
    [AuthorizeRoles(RoleNameEnum.Admin, RoleNameEnum.StorageManager)]
    public class ProductExportBillController : ControllerBase
    {
        private readonly IProductExportBillService _productExportBillService;
        private readonly IUriService _uriService;
        private readonly IMapper _mapper;
        private readonly IOptions<AppSettings> _appSettings;

        public ProductExportBillController(
            IProductExportBillService productExportBillService,
            IUriService uriService,
            IMapper mapper,
            IOptions<AppSettings> appSettings
        )
        {
            _productExportBillService = productExportBillService;
            _uriService = uriService;
            _mapper = mapper;
            _appSettings = appSettings;
        }


        [AuthorizeRoles(RoleNameEnum.StorageManager)]
        [HttpPost(ApiRoutes.ProductExportBill.Create)]
        public async Task<IActionResult> Create(
                [FromBody] CreateProductExportBillRequest createModel
            )
        {
            var requestedUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            ProductExportBill productExportBill = new ProductExportBill
            {
                OrderId = createModel.OrderId
            };
            var productExportDetails = _mapper
                .Map<IEnumerable<CreateProductExportDetailRequest>, IEnumerable<ProductExportDetail>>(
                    createModel.ProductExportDetails);
            var result = await _productExportBillService.CreateAsync(
                productExportBill,
                productExportDetails,
                requestedUserId
            );

            if (result.IsSuccess == false)
            {
                return BadRequest(result.Errors);
            }

            var locationUri = _uriService.GetByIdUri(
                ApiRoutes.ProductExportBill.GetById.Replace(
                    "{productExportBillId}",
                    result.EntityReturn.Id.ToString())
            );
            var productExportBillResponse = _mapper.Map<ProductExportBillResponse>(
                result.EntityReturn);

            return Created(locationUri,
                new Response<ProductExportBillResponse>(productExportBillResponse));
        }
    }
}