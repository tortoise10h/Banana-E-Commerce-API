using System;

namespace Banana_E_Commerce_API.Entities
{
    public class RemoveProductQuantityReport
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Quantity { get; set; }
        public int ProductTierId { get; set; }
        public int CreatedBy { get; set; }

        public ProductTier ProductTier { get; set; }
        public StorageManager StorageManager { get; set; }
    }
}