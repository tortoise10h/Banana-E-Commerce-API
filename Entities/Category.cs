using System;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public Admin Admin { get; set; }
        public int CreatedBy { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}