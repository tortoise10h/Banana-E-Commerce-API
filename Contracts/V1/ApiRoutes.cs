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
            public const string Update = Base + "/users/{id}";
            public const string Delete = Base + "/users/{id}";
            public const string Get = Base + "/users/{id}";
        }

        public static class Auth
        {
            public const string Login = Base + "/login";
            public const string Register = Base + "/register";
        }

        public static class Cart
        {
            public const string AddToCart = Base + "/cart";
        }
    }
}