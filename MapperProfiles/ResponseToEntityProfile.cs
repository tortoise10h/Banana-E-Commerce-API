using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users;
using Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.MapperProfiles
{
    public class ResponseToEntityProfile : Profile
    {
        public ResponseToEntityProfile()
        {
            CreateMap<UserResponse, User>();
        }
    }
}