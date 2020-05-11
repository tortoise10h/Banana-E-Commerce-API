using System;

namespace Banana_E_Commerce_API.Entities
{
    public class ImportBillDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public SupplyProduct SupplyProduct { get; set; }
        public int SupplyProductId { get; set; }

        public ImportBill ImportBill { get; set; }
        public int ImportBillId { get; set; }

    }
}