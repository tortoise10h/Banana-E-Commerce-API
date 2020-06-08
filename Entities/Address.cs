using System;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string StreetLocation { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}