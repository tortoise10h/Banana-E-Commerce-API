namespace Banana_E_Commerce_API.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;

        public static class Users
        {
            public const string GetAll = Base + "/users";
            public const string Create = Base + "/users";
            public const string Update = Base + "/users/{userId}";
            public const string Delete = Base + "/users/{userId}";
            public const string Get = Base + "/users/{userId}";
        }

        public static class Customer
        {
            public const string Update = Base + "/customers/{customerId}";
            public const string GetById = Base + "/customers/{customerId}";
        }

        public static class Auth
        {
            public const string Login = Base + "/login";
            public const string Register = Base + "/register";
            public const string Refresh = Base + "/refresh";
        }

        public static class Cart
        {
        }

        public static class Product
        {
            public const string Create = Base + "/products";
            public const string GetAll = Base + "/products";
            public const string GetById = Base + "/products/{productId}";
            public const string Update = Base + "/products/{productId}";
            public const string Delete = Base + "/products/{productId}";
        }

        public static class Category
        {
            public const string Create = Base + "/categories";
            public const string GetAll = Base + "/categories";
            public const string GetById = Base + "/categories/{categoryId}";
            public const string Update = Base + "/categories/{categoryId}";
            public const string Delete = Base + "/categories/{categoryId}";
        }

        public static class Storage
        {
            public const string Create = Base + "/storages";
            public const string GetAll = Base + "/storages";
            public const string GetById = Base + "/storages/{storageId}";
            public const string Update = Base + "/storages/{storageId}";
            public const string Delete = Base + "/storages/{storageId}";
        }

        public static class CartDetail
        {
            public const string AddToCart = Base + "/cartDetails";
            public const string GetAll = Base + "/cartDetails";
            public const string GetById = Base + "/cartDetails/{cartDetailId}";
            public const string Update = Base + "/cartDetails/{cartDetailId}";
            public const string Delete = Base + "/cartDetails/{cartDetailId}";
            public const string DeleteAll = Base + "/cartDetails";
        }

        public static class Address
        {
            public const string Create = Base + "/addresses";
            public const string GetAll = Base + "/addresses";
            public const string GetById = Base + "/addresses/{addressId}";
            public const string Update = Base + "/addresses/{addressId}";
            public const string Delete = Base + "/addresses/{addressId}";
        }

        public static class ProductImage
        {
            public const string UploadMultiples = Base + "/productImages";
            public const string GetAll = Base + "/productImages";
            public const string GetById = Base + "/productImages/{productImageId}";
            public const string Update = Base + "/productImages/{productImageId}";
            public const string Delete = Base + "/productImages/{productImageId}";
        }

        public static class RequestImportProduct
        {
            public const string Create = Base + "/requestImportProducts";
            public const string GetAll = Base + "/requestImportProducts";
            public const string GetById = Base + "/requestImportProducts/{requestImportProductId}";
            public const string Update = Base + "/requestImportProducts/{requestImportProductId}";
            public const string Cancel = Base + "/requestImportProducts/{requestImportProductId}";
            public const string CalculateProductsPriceWeightedAverageMethod = Base + "/requestImportProducts/{requestImportProductId}/weightedaverage";
        }

        public static class ImportBill
        {
            public const string Create = Base + "/importBills";
            public const string GetAll = Base + "/importBills";
            public const string GetById = Base + "/importBills/{importBillId}";
            public const string Update = Base + "/importBills/{importBillId}";
            public const string Delete = Base + "/importBills/{importBillId}";
        }

        public static class ProductFavor
        {
            public const string Create = Base + "/productFavors";
            public const string GetAll = Base + "/productFavors";
            public const string GetById = Base + "/productFavors/{productFavorId}";
            public const string DeleteAll = Base + "/productFavors";
            public const string Delete = Base + "/productFavors/{productFavorId}";
        }

        public static class ProductTierTransferReport
        {
            public const string Create = Base + "/productTierTransferReport";
            public const string BulkCreate = Base + "/productTierTransferReport/bulk";
            public const string GetAll = Base + "/productTierTransferReport";
            public const string GetById = Base + "/productTierTransferReport/{productTierTransferReportId}";
            public const string Update = Base + "/productTierTransferReport/{productTierTransferReportId}";
            public const string Delete = Base + "/productTierTransferReport/{productTierTransferReportId}";

        }

        public static class ProductTier
        {
            public const string GetAll = Base + "/productTiers";
            public const string GetById = Base + "/productTiers/{productTierId}";
            public const string Update = Base + "/productTiers/{productTierId}";
        }

        public static class Order
        {
            public const string Create = Base + "/Orders";
            public const string GetAll = Base + "/Orders";
            public const string GetById = Base + "/Orders/{orderId}";
            public const string Update = Base + "/Orders/{orderId}";
            public const string Delete = Base + "/Orders/{orderId}";
            public const string HandOverOrderToStorageManager = Base + "/Orders/{orderId}/ProcessingStatus";
            public const string CancelOrder = Base + "/Orders/{orderId}/CanceledStatus";
            public const string ConfirmSucceeded = Base + "/Orders/{orderId}/SucceededStatus";
            public const string StripePaymentResponse = Base + "/Orders/StripePaymentResponse";
        }

        public static class Rating
        {
            public const string Create = Base + "/rates";
            public const string GetAll = Base + "/rates";
            public const string GetById = Base + "/rates/{ratingId}";
            public const string Delete = Base + "/rates/{ratingId}";
            public const string Update = Base + "/rates/{ratingId}";
        }

        public static class RatingImage
        {
            public const string UploadMultiples = Base + "/ratingImages";
        }

        public static class ProductExportBill
        {
            public const string Create = Base + "/ProductExportBills";
            public const string GetAll = Base + "/ProductExportBills";
            public const string GetById = Base + "/ProductExportBills/{productExportBillId}";
            public const string Update = Base + "/ProductExportBills/{productExportBillId}";
            public const string Delete = Base + "/ProductExportBills/{productExportBillId}";
        }
    }
}