namespace Banana_E_Commerce_API.Entities
{
    public class RequestExportDetail
    {
        public int Id { get; set; }
        public int RequestExportProductId { get; set; }
        public int ProductTierId { get; set; }
        public double Quantity { get; set; }

        public RequestExportProduct RequestExportProduct { get; set; }
        public ProductTier ProductTier { get; set; }
    }
}