using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Cart;
using Banana_E_Commerce_API.Helpers;
using Banana_E_Commerce_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Banana_E_Commerce_API.Controllers.V1
{
    public class CartController : ControllerBase
    {
        private ICartService _cartService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public CartController(
            ICartService cartService,
            IMapper mapper,
            IOptions<AppSettings> appSettings
        )
        {
            _cartService = cartService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }
    }
}