using System;

namespace Banana_E_Commerce_API.Entities
{
    public class RefreshToken
    {
        public string Token { get; set; }
        public string JwtId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsUsed { get; set; }
        public bool IsValidated { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}