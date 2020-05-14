using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Category;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Storage;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users;
using Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.MapperProfiles
{
    public class EntityToResponseProfile : Profile
    {
        public EntityToResponseProfile()
        {
            CreateMap<User, UserResponse>();
            CreateMap<Product, ProductResponse>();
            CreateMap<Category, CategoryResponse>();
            CreateMap<Storage, StorageResponse>();
        }
    }
}