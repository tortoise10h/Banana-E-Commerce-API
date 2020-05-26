namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Users
{
    public class UpdateUserPasswordRequest
    {
        public string oldPassword { get; set; }
        public string newPassword { get; set; }
        public string confirmPassword { get; set; }

    }
}