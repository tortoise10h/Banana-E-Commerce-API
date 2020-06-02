using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries;
using Banana_E_Commerce_API.Domains;

namespace Banana_E_Commerce_API.MapperProfiles
{
    public class RequestToDomainProfile : Profile
    {
        public RequestToDomainProfile()
        {
            CreateMap<PaginationQuery, PaginationFilter>();
            CreateMap<GetAllCategoriesQuery, GetAllCategoriesFilter>();
            CreateMap<GetAllProductsQuery, GetAllProductsFilter>();
            CreateMap<GetAllCartDetailsQuery, GetAllCartDetailsFilter>();
            CreateMap<GetAllUsersQuery, GetAllUserFilter>();
            CreateMap<GetAllAddressesQuery, GetAllAddressesFilter>();
            CreateMap<GetAllRequestImportProductsQuery, GetAllRequestImportProductsFilter>();
            CreateMap<GetAllImportBillsQuery, GetAllImportBillsFilter>();
            CreateMap<GetAllProductFavoritesQuery, GetAllProductFavoritesFilter>();
        }
    }
}