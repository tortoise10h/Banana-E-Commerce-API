using System;
using System.Collections.Generic;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Entities
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public ICollection<PaymentMethod> PaymentMethods { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Shipment> Shipments { get; set; }
        public ICollection<SupplierPayment> SupplierPayments { get; set; }
    }
}