using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Cart;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Admin;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.CartDetailModels;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Category;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Customer;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Manager;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Role;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Shipper;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Storage;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.StorageManager;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Address;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductImage;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.Tier;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTier;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.RequestImportProduct;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.RequestImportDetail;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ImportBill;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ImportBillDetail;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductFavor;
using Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductTierTransferReport;

namespace Banana_E_Commerce_API.MapperProfiles
{
    public class EntityToResponseProfile : Profile
    {
        public EntityToResponseProfile()
        {
            /** User */
            CreateMap<User, UserResponse>();

            /** Product */
            CreateMap<Product, ProductResponse>();
            CreateMap<Product, ProductResponseOfCartDetail>();
            CreateMap<Product, ProductResponseOfImportBillDetail>();
            CreateMap<Product, ProductResponseOfRequestImportDetail>();
            CreateMap<Product, ProductResponseOfProductFavor>();
            CreateMap<Product, ProductResponseWithoutIncludeProductTier>();

            /** Category */
            CreateMap<Category, CategoryResponse>();

            /** Storage */
            CreateMap<Storage, StorageResponse>();

            /** Admin */
            CreateMap<Admin, AdminResponse>();

            /** Customer */
            CreateMap<Customer, CustomerResponse>();

            /** Manager */
            CreateMap<Manager, ManagerResponse>();

            /** StorageManager */
            CreateMap<StorageManager, StorageManagerResponse>();

            /** Shipper */
            CreateMap<Shipper, ShipperResponse>();

            /** Role */
            CreateMap<Role, RoleResponse>();

            /** Cart */
            CreateMap<Cart, CartResponse>();

            /** CartDetail */
            CreateMap<CartDetail, CartDetailResponse>();

            /** Address */
            CreateMap<Address, AddressResponse>();

            /** ProductImage */
            CreateMap<ProductImage, ProductImageResponse>();

            /** Tier */
            CreateMap<Tier, TierResponse>();

            /** ProductTier */
            CreateMap<ProductTier, ProductTierResponse>();
            CreateMap<ProductTier, ProductTierResponseOfCartDetail>();
            CreateMap<ProductTier, ProductTierResponseOfImportBillDetail>();
            CreateMap<ProductTier, ProductTierResponseOfProduct>();
            CreateMap<ProductTier, ProductTierResponseOfRequestImportDetail>();
            CreateMap<ProductTier, ProductTierResponseOfProductFavor>();

            /** ProductFavor */
            CreateMap<ProductFavorite, ProductFavorResponse>();

            /** RequestImportProduct */
            CreateMap<RequestImportProduct, RequestImportProductResponse>();

            /** RequestImportDetail */
            CreateMap<RequestImportDetail, RequestImportDetailResponse>();

            /** ImportBill */
            CreateMap<ImportBill, ImportBillResponse>();

            /** ImportBillDetail */
            CreateMap<ImportBillDetail, ImportBillDetailResponse>();

            /** ProductTierTransferReport */
            CreateMap<ProductTierTransferReport, ProductTierTransferReportResponse>();
        }
    }
}