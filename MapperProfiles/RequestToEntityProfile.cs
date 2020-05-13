using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Auth;
using Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.MapperProfiles
{
    public class RequestToEntityProfile : Profile
    {
        public RequestToEntityProfile()
        {
            CreateMap<RegisterRequest, Customer>();
        }
    }
}