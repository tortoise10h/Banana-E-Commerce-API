using System;

namespace Banana_E_Commerce_API.Entities
{
    public class CartDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public Cart Cart { get; set; }
        public int CartId { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}