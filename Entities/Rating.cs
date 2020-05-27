using System;

namespace Banana_E_Commerce_API.Entities
{
    public class Rating
    {
        public int Id { get; set; }
        public int StarNum { get; set; }
        public string Comment { get; set; }
        public int Like { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int ProductTierId { get; set; }
        public int CustomerId { get; set; }


        public Customer Customer { get; set; }
        public ProductTier ProductTier { get; set; }
    }
}