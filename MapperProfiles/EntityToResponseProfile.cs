using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Admin;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Category;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Customer;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Manager;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Role;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Shipper;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Storage;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.StorageManager;
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

            CreateMap<Admin, AdminResponse>();

            CreateMap<Customer, CustomerResponse>();

            CreateMap<Manager, ManagerResponse>();

            CreateMap<StorageManager, StorageManagerResponse>();

            CreateMap<Shipper, ShipperResponse>();

            CreateMap<Role, RoleResponse>();
        }
    }
}