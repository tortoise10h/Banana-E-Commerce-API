using System;
using Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int BannedBy { get; set; }
        public UserStatus Status { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }

    public enum UserStatus
    {
        Banned,
        Available
    }
}