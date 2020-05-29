using System;
using System.Collections;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Entities
{
    public class Storage
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public double Size { get; set; }
        public string SizeUnit { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<StorageManager> StorageManagers { get; set; }
        public ICollection<ImportBill> ImportBills { get; set; }
    }
}