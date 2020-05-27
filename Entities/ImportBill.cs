using System;
using System.Collections.Generic;
using Banana_E_Commerce_API.Enums;

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
        public int RequestImportProductId { get; set; }
        public int StorageManagerId { get; set; }
        public int StorageId { get; set; }


        public Storage Storage { get; set; }
        public StorageManager StorageManager { get; set; }
        public RequestImportProduct RequestImportProduct { get; set; }

        public ICollection<ImportBillDetail> ImportBillDetails { get; set; }
    }
}