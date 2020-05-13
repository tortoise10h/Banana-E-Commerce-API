using System;
using System.Collections.Generic;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public RoleNameEnum RoleName { get; set; }
        // public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<User> Users { get; set; }

        // public Manager Manager { get; set; }
    }


}