using System;
using System.Collections.Generic;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;

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
        public UserStatus Status { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public Manager Manager { get; set; }
        public Customer Customer { get; set; }
        public Admin Admin { get; set; }
        public StorageManager StorageManager { get; set; }
        public Shipper Shipper { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<RefreshToken> RefreshTokens { get; set; }

    }


}