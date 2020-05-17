using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Auth;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Category;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Product;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Storage;
using Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.MapperProfiles
{
    public class RequestToEntityProfile : Profile
    {
        public RequestToEntityProfile()
        {
            /** Auth */
            CreateMap<RegisterRequest, Customer>();

            /** Product */
            CreateMap<CreateProductRequest, Product>();
            CreateMap<UpdateProductRequest, Product>();

            /** Category */
            CreateMap<CreateCategoryRequest, Category>();
            CreateMap<UpdateCategoryRequest, Category>();

            /** Storage */
            CreateMap<CreateStorageRequest, Storage>();
            CreateMap<UpdateStorageRequest, Storage>();
        }
    }
}
