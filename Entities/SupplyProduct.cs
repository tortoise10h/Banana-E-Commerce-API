using System;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Entities
{
    public class SupplyProduct
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public User User { get; set; }
        public int CreatedBy { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }

        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }

        public ICollection<ImportBillDetail> ImportBillDetails { get; set; }
    }
}