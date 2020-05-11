using System;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Entities
{
    public class ImportBill
    {
        public int Id { get; set; }
        public double TotalAmount { get; set; }
        public PriceCurrency Currency { get; set; }
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public Storage Storage { get; set; }
        public int StorageId { get; set; }
        public StorageManager StorageManager { get; set; }
        public int StorageManagerId { get; set; }

        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }

        public ICollection<ImportBillDetail> ImportBillDetails { get; set; }
    }
}