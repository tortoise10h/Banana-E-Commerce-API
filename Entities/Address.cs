using System;

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
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public Order Order { get; set; }
    }
}