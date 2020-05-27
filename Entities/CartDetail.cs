using System;

namespace Banana_E_Commerce_API.Entities
{
    public class CartDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductTierId { get; set; }
        public int CartId { get; set; }

        public Cart Cart { get; set; }
        public ProductTier ProductTier { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}