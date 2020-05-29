using System;
using System.Collections.Generic;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Entities
{
    public class RequestImportProduct
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public RequestImportProductStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public Admin Admin { get; set; }
        public ICollection<RequestImportDetail> RequestImportDetails { get; set; }
        public ICollection<ImportBill> ImportBills { get; set; }
        public ICollection<ImportProductReport> ImportProductReports { get; set; }
    }
}