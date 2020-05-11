using System;

namespace Banana_E_Commerce_API.Entities
{
    public class Shipment
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string StreetLocation { get; set; }
        public double ShippingCharge { get; set; }

        public Order Order { get; set; }
        public int OrderId { get; set; }

        public Admin Admin { get; set; }
        public int CreatedBy { get; set; }

        public Shipper Shipper { get; set; }
        public int ShipperId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public ProductExportBill ProductExportBill { get; set; }
        public int ProductExportBillId { get; set; }

        public Invoice Invoice { get; set; }
    }
}