

using System;

namespace Banana_E_Commerce_API.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
        public int PaymentMethodId { get; set; }

        public Shipment Shipment { get; set; }
        public int ShipmentId { get; set; }
    }
}