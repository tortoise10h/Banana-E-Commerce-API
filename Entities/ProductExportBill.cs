using System;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Entities
{
    public class ProductExportBill
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int RequestExportProductId { get; set; }
        public int StorageManagerId { get; set; }

        public StorageManager StorageManager { get; set; }
        public RequestExportProduct RequestExportProduct { get; set; }

        public ICollection<ProductExportDetail> ProductExportDetails { get; set; }


    }
}