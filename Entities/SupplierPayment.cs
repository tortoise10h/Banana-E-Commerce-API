using System;

namespace Banana_E_Commerce_API.Entities
{
    public class SupplierPayment
    {
        public int Id { get; set; }
        public double TotalAmount { get; set; }
        public PriceCurrency Currency { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public Admin Admin { get; set; }
        public int CreatedBy { get; set; }

        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }
    }
}