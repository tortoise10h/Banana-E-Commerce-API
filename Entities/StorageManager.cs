using System;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Entities
{
    public class StorageManager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public Storage Storage { get; set; }
        public int StorageId { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public ICollection<ImportBill> ImportBills { get; set; }
        public ICollection<ProductExportBill> ProductExportBills { get; set; }

    }
}