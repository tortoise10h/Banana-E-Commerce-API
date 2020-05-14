using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Banana_E_Commerce_API.Extensions
{
    public static class GeneralExtensions
    {
        public static string GetUserIdFromRequest(this HttpContext httpContext)
        {
            if (httpContext.User == null)
            {
                return string.Empty;
            }

            return httpContext.User.Claims.Single(x => x.Type == "id").Value;
        }
    }
}