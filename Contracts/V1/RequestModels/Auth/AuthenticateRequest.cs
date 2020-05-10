using System.ComponentModel.DataAnnotations;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Auth
{
    public class AuthenticateRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}