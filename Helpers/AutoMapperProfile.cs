using System;
using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Users;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users;
using Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserResponse>();
            CreateMap<RegisterRequest, User>();
            CreateMap<UpdateRequest, User>();
        }
    }
}