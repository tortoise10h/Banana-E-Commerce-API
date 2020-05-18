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

        public static class Auth
        {
            public const string Login = Base + "/login";
            public const string Register = Base + "/register";
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
        }
    }
}