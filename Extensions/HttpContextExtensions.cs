using Microsoft.AspNetCore.Http;

namespace Banana_E_Commerce_API.Extensions
{
    public static class HttpContextExtensions
    {
        public static string GenerateResouceOfCreatedObject(this HttpContext httpContext, string getItemUri)
        {
            var baseUrl = $"{httpContext.Request.Scheme}://{httpContext.Request.Host.ToUriComponent()}";
            var locationUri = baseUrl + "/" + getItemUri;

            return locationUri;
        }
    }
}