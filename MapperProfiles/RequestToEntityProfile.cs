using AutoMapper;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Auth;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.CartDetail;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Category;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Product;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Storage;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Address;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Users;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductImage;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.RequestImportProduct;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.RequestImportDetail;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ImportBill;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ImportBillDetail;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Customer;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductFavor;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductTierTransferReport;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductTier;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Order;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.OrderItem;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.Rating;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.RatingImage;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductExportBill;
using Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductExportDetail;

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

            /** Cart Detail */
            CreateMap<AddProductToCartRequest, CartDetail>();
            CreateMap<UpdateCartDetailRequest, CartDetail>();

            /** Address */
            CreateMap<CreateAddressRequest, Address>();
            CreateMap<UpdateAddressRequest, Address>();

            /** Product Image */
            CreateMap<CreateProductImageRequest, ProductImage>();

            /** ProductTier */
            CreateMap<CreateProductRequest, ProductTier>();
            CreateMap<UpdateProductTierRequest, ProductTier>();

            /** RequestImportDetail */
            CreateMap<CreateRequestImportDetailRequest, RequestImportDetail>();
            CreateMap<CreateRequestImportProductRequest, RequestImportDetail>();

            /** RequestImportProduct */
            CreateMap<UpdateRequestImportProductRequest, RequestImportProduct>();

            /** ImportBill */
            CreateMap<CreateImportBillRequest, ImportBill>();

            /** ImportBillDetail */
            CreateMap<CreateImportBillDetailRequest, ImportBillDetail>();

            /** User **/
            CreateMap<UpdateUserPasswordRequest, User>();

            /** Customer **/
            CreateMap<UpdateCustomerInfoRequest, Customer>();

            /** ProductFavor **/
            CreateMap<CreateProductFavorRequest, ProductFavorite>();

            /** ProductTierTransferReport */
            CreateMap<CreateProductTierTransferReportRequest, ProductTierTransferReport>();

            /** Order */
            CreateMap<CreateOrderRequest, Order>();

            /** OrderItem */
            CreateMap<CreateOrderItemRequest, OrderItem>();

            /** Rating **/
            CreateMap<CreateRatingRequest, Rating>();
            CreateMap<UpdateRatingRequest, Rating>();

            /** Rating Image */
            CreateMap<CreateRatingImageRequest, RatingImage>();
            /** ProductExportBill */
            CreateMap<CreateProductExportBillRequest, ProductExportBill>();

            /** ProductExportDetail */
            CreateMap<CreateProductExportDetailRequest, ProductExportDetail>();

        }
    }
}
