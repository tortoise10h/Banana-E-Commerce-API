using System;

namespace Banana_E_Commerce_API.Entities
{
    public class ProductTierTransferReport
    {
        public int Id { get; set; }
        public int FromTierId { get; set; }
        public int ToTierId { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public bool IsDeleted { get; set; }

        public StorageManager StorageManager { get; set; }
        public ProductTier ProductTier { get; set; }

    }
}