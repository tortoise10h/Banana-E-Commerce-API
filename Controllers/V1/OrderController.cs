using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Order;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.OrderItem;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Order;
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
    [AuthorizeRoles(RoleNameEnum.Admin, RoleNameEnum.Customer, RoleNameEnum.StorageManager)]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IUriService _uriService;
        private IMapper _mapper;
        private readonly IOptions<AppSettings> _appSettings;

        public OrderController(
            IOrderService orderService,
            IUriService uriService,
            IMapper mapper,
            IOptions<AppSettings> appSettings
        )
        {
            _orderService = orderService;
            _uriService = uriService;
            _mapper = mapper;
            _appSettings = appSettings;
        }


        [AuthorizeRoles(RoleNameEnum.Customer)]
        [HttpPost(ApiRoutes.Order.Create)]
        public async Task<IActionResult> Create(
            [FromBody] CreateOrderRequest createModel
        )
        {
            var requestedUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            DateTime IdealShipTimeDate = string.IsNullOrEmpty(createModel.IdealShipTime) == false
                ? DateTime.ParseExact(createModel.IdealShipTime, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                : DateTime.UtcNow;
            Order orderEntity = new Order
            {
                IdealShipTime = IdealShipTimeDate,
                IsGift = createModel.IsGift,
                Notes = createModel.Notes,
                AddressId = createModel.AddressId,
                PaymentMethodId = createModel.PaymentMethodId
            };

            var createResult = await _orderService.CreateAsync(
                orderEntity,
                requestedUserId
            );

            if (createResult.IsSuccess == false)
            {
                return BadRequest(createResult.Errors);
            }

            var orderResponse = _mapper.Map<OrderResponse>(orderEntity);

            var locationUri = _uriService.GetByIdUri(
                ApiRoutes.Order.GetById.Replace("{orderId}", orderEntity.Id.ToString())
            );

            return Created(locationUri,
                new Response<OrderResponse>(orderResponse));

        }


        [HttpGet(ApiRoutes.Order.GetById)]
        public async Task<IActionResult> GetById(
            [FromRoute] int orderId
        )
        {
            int requestedUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            var result = await _orderService.GetByIdAsync(orderId, requestedUserId);

            if (result == null)
            {
                return NotFound();
            }

            var orderResponse = _mapper.Map<OrderResponse>(result);
            return Ok(new Response<OrderResponse>(orderResponse));
        }



        [HttpGet(ApiRoutes.Order.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllOrdersQuery filterModel,
            [FromQuery] PaginationQuery paginModel
        )
        {
            int requestedUserId = int.Parse(HttpContext.GetUserIdFromRequest());
            var pagination = _mapper.Map<PaginationFilter>(paginModel);
            var filter = _mapper.Map<GetAllOrdersFilter>(filterModel);
            var orders = await _orderService
                .GetAllAsync(pagination, filter, requestedUserId);
            int totalOrders = await _orderService
                .CountAllAsync(pagination, filter, requestedUserId);
            var responseOrders = _mapper
                .Map<List<OrderResponse>>(orders);

            var paginationOrdersResponse = PaginationHelpers
                .CreatePaginatedResponse(
                    _uriService,
                    pagination,
                    responseOrders,
                    totalOrders,
                    ApiRoutes.Order.GetAll
                );

            return Ok(paginationOrdersResponse);
        }
    }
}