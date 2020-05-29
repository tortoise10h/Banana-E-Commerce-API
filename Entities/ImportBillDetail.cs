using System;

namespace Banana_E_Commerce_API.Entities
{
    public class ImportBillDetail
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int ImportBillId { get; set; }
        public int ProductTierId { get; set; }

        public ImportBill ImportBill { get; set; }
        public ProductTier ProductTier { get; set; }

    }
}