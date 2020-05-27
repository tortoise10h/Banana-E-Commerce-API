using System;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Entities
{
    public class RequestImportProduct
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int OrderId { get; set; }

        public Admin Admin { get; set; }
        public ICollection<RequestImportDetail> RequestImportDetails { get; set; }
        public ICollection<ImportBill> ImportBills { get; set; }
        public ICollection<ImportProductReport> ImportProductReports { get; set; }
    }
}