namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Users
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}