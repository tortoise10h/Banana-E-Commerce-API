using System.Collections.Generic;

namespace Banana_E_Commerce_API.Entities
{
    public class Cart
    {
        public int Id { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public ICollection<CartDetail> CartDetails { get; set; }
    }
}