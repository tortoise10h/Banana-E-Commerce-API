namespace Banana_E_Commerce_API.Entities
{
    public class ProductFavorite
    {
        public int Id { get; set; }
        public int ProductTierId { get; set; }
        public int CustomerId { get; set; }


        public ProductTier ProductTier { get; set; }
        public Customer Customer { get; set; }
    }
}