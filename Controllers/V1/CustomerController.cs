using AutoMapper;
using Banana_E_Commerce_API.Helpers;
using Banana_E_Commerce_API.Services;
using Banana_E_Commerce_API.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Banana_E_Commerce_API.CustomAttributes;
using Banana_E_Commerce_API.Contracts.V1;
using System.Threading.Tasks;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Customer;
using Banana_E_Commerce_API.Extensions;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Customer;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;

namespace Banana_E_Commerce_API.Controllers.V1
{
    [AuthorizeRoles(RoleNameEnum.Admin, RoleNameEnum.Customer)]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public CustomerController(
            ICustomerService customerService,
            IMapper mapper,
            IOptions<AppSettings> appSettings
        )
        {
            _customerService = customerService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        [HttpPut(ApiRoutes.Customer.Update)]
        public async Task<IActionResult> Update([FromRoute] int customerId, [FromBody] UpdateCustomerInfoRequest updateModel)
        {
            var customerEntity = await _customerService.GetByIdAsync(customerId);
            var userId = int.Parse(HttpContext.GetUserIdFromRequest());
            if (customerEntity == null)
            {
                return NotFound();
            }

            var isCustomerOwnInfo = await _customerService.IsCustomerOwnInfo(userId, customerId);
            if (!isCustomerOwnInfo)
            {   
                return Unauthorized("Bạn không có quyền truy cập");
            }

            _mapper.Map<UpdateCustomerInfoRequest, Customer>(updateModel, customerEntity);

            var isCustomerUpdated = await _customerService.UpdateAsync(customerEntity, userId);
            if (!isCustomerUpdated.IsSuccess)
            {
                return BadRequest(
                    isCustomerUpdated.Errors
                );
            }

            var customerResponse = _mapper.Map<CustomerResponse>(customerEntity);
            return Ok(new Response<CustomerResponse>(customerResponse));
        }
    }
}