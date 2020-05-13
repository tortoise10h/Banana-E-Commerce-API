using AutoMapper;
using Banana_E_Commerce_API.Helpers;
using Banana_E_Commerce_API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Banana_E_Commerce_API.Controllers.V1
{
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
    }
}