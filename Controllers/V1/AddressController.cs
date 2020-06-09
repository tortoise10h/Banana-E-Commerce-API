using System;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Address;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Address;
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
    [AuthorizeRoles(RoleNameEnum.Admin, RoleNameEnum.Customer)]
    public class AddressController : ControllerBase
    {
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IAddressService _addressService;
        private readonly IUriService _uriService;
        private readonly IMapper _mapper;

        public AddressController(
            IAddressService addressservice,
            IUriService uriService,
            IMapper mapper,
            IOptions<AppSettings> appSettings
        )
        {
            _addressService = addressservice;
            _uriService = uriService;
            _mapper = mapper;
            _appSettings = appSettings;
        }
        
        [HttpPost(ApiRoutes.Address.Create)]
        public async Task<IActionResult> Create([FromBody] CreateAddressRequest createModel)
        {
            var addressEntity = _mapper.Map<Address>(createModel);
            var createdCustomerId = int.Parse(HttpContext.GetUserIdFromRequest());

            var isCreateSuccess = await _addressService.CreateAsync(addressEntity, createdCustomerId);

            if (!isCreateSuccess)
            {
                return BadRequest("Create address failed");
            }

            var addressUri = _uriService.GetByIdUri(
                            ApiRoutes.Address.GetById.Replace("{addressId}", addressEntity.Id.ToString()));
            var addressResponse = _mapper.Map<AddressResponse>(addressEntity);
            return Created(
                addressUri,
                new Response<AddressResponse>(addressResponse));
        }

        [HttpGet(ApiRoutes.Address.GetById)]
        public async Task<IActionResult> GetById([FromRoute] int addressId)
        {
            var result = await _addressService.GetByIdAsync(addressId);
            var addressResponse = _mapper.Map<AddressResponse>(result);

            if (result != null)
            {
                return Ok(new Response<AddressResponse>(addressResponse));
            }
            return NotFound();
        }

        [HttpGet(ApiRoutes.Address.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllAddressesQuery filterModel,
            [FromQuery] PaginationQuery paginModel)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginModel);
            var filter = _mapper.Map<GetAllAddressesFilter>(filterModel);
            var userId = int.Parse(HttpContext.GetUserIdFromRequest());
            var addresses = await _addressService.GetAllAsync(userId, pagination, filter);
            int totalAddresses = await _addressService.CountAllAsync(pagination, filter);
            var responseAddress = _mapper.Map<List<AddressResponse>>(addresses);

            var paginationAddressesResponse = PaginationHelpers.CreatePaginatedResponse(
                _uriService,
                pagination,
                responseAddress,
                totalAddresses,
                ApiRoutes.Address.GetAll
            );

            return Ok(paginationAddressesResponse);
        }

        [HttpPut(ApiRoutes.Address.Update)]
        public async Task<IActionResult> Update([FromRoute] int addressId, [FromBody] UpdateAddressRequest updateModel)
        {
            var addressEntity = await _addressService.GetByIdAsync(addressId);
            var userId = int.Parse(HttpContext.GetUserIdFromRequest());
            if (addressEntity == null)
            {
                return NotFound();
            }

            // validate customer valid to update address
            var isCustomerValidUpdate = await _addressService.IsCustomerOwnAddress(userId, addressId);
            if (!isCustomerValidUpdate)
            {
                return Forbid();
            }

            _mapper.Map<UpdateAddressRequest, Address>(updateModel, addressEntity);

            var isAddressUpdated = await _addressService.UpdateAsync(addressEntity, userId);

            var addressResponse = _mapper.Map<AddressResponse>(addressEntity);
            if (isAddressUpdated)
            {
                return Ok(new Response<AddressResponse>(addressResponse));
            }

            return NotFound();
        }

        [HttpDelete(ApiRoutes.Address.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int addressId)
        {
            var addressEntity = await _addressService.GetByIdAsync(addressId);
            var userId = int.Parse(HttpContext.GetUserIdFromRequest());

            if (addressEntity == null)
            {
                return NotFound();
            }

            var isCustomerValidDelete = await _addressService.IsCustomerOwnAddress(userId, addressId);
            if (!isCustomerValidDelete)
            {   
                return Unauthorized("You don\'t have a permission");
            }

            var isDeleted = await _addressService.DeleteAsync(addressId);
            if (isDeleted)
            {
                return NoContent();
            }

            return NotFound();
        }

  }
}

