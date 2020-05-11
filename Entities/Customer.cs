using System;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public ICollection<Address> Addresses { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Rating> Rates { get; set; }
        public ICollection<ProductFavorite> ProductFavorites { get; set; }

        public Cart Cart { get; set; }

    }
}