using AutoMapper;
using Banana_E_Commerce_API.Helpers;
using Microsoft.Extensions.Options;

namespace Banana_E_Commerce_API.Controllers.V1
{
    public class AdminController
    {
        private readonly IMapper _mapper;
        private readonly IOptions<AppSettings> _appSettings;

        public AdminController(
            IMapper mapper,
            IOptions<AppSettings> appSettings
        )
        {
            _mapper = mapper;
            _appSettings = appSettings;
        }
    }
}