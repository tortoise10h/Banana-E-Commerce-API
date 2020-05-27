using System;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Entities
{
    public class RequestExportProduct
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public Order Order { get; set; }
        public Admin Admin { get; set; }
        public ICollection<RequestExportDetail> RequestExportDetails { get; set; }
        public ICollection<ProductExportBill> ProductExportBills { get; set; }
    }
}