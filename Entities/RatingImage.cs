using System;

namespace Banana_E_Commerce_API.Entities
{
    public class RatingImage
    {
        public int Id { get; set; }
        public string ImgLocation { get; set; }
        public string ImgName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int RatingId { get; set; }
        public int ProductTierId { get; set; }

        public Rating Rating { get; set; }
        public ProductTier ProductTier { get; set; }
    }
}