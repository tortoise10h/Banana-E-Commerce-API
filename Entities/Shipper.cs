using System;
using System.Collections.Generic;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Entities
{
    public class Shipper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string IdentityId { get; set; }
        public ShipperStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public Admin Admin { get; set; }
        public int CreatedBy { get; set; }

        public ICollection<Shipment> Shipments { get; set; }
    }
}