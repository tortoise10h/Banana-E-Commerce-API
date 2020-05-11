namespace Banana_E_Commerce_API.Entities
{
    public class ProductFavorite
    {
        public int Id { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}