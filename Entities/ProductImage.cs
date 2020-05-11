using System;

namespace Banana_E_Commerce_API.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string ImgLocation { get; set; }
        public string ImgName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}