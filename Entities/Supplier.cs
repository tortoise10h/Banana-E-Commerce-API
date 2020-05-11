using System;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<SupplyProduct> SupplyProducts { get; set; }
        public ICollection<SupplierPayment> SupplierPayments { get; set; }
        public ICollection<ImportBill> ImportBills { get; set; }

    }
}