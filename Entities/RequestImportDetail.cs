namespace Banana_E_Commerce_API.Entities
{
    public class RequestImportDetail
    {
        public int Id { get; set; }
        public int RequestImportProductId { get; set; }
        public int ProductTierId { get; set; }
        public double Quantity { get; set; }
        public double QuantityLeft { get; set; }

        public RequestImportProduct RequestImportProduct { get; set; }
        public ProductTier ProductTier { get; set; }
    }
}