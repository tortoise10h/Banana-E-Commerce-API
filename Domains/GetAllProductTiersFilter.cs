namespace Banana_E_Commerce_API.Domains
{
    public class GetAllProductTiersFilter
    {
        public int ProductId { get; set; }
        public int TierId { get; set; }
        public double Quantity { get; set; }
        public int DiscountPercentage { get; set; }
        public double AfterDiscountPrice { get; set; }
    }
}