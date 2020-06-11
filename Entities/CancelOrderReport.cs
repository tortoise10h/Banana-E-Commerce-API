using System;

namespace Banana_E_Commerce_API.Entities
{
    public class CancelOrderReport
    {
        public int Id { get; set; }
        public string CancelReason { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}