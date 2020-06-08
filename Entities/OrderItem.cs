namespace Banana_E_Commerce_API.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double SinglePrice { get; set; }
        public int ProductTierId { get; set; }
        public int OrderId { get; set; }

        public Order Order { get; set; }
        public ProductTier ProductTier { get; set; }
    }
}