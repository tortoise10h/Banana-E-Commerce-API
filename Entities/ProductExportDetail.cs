namespace Banana_E_Commerce_API.Entities
{
    public class ProductExportDetail
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public int ExportBillId { get; set; }
        public int ProductTierId { get; set; }

        public ProductExportBill ProductExportBill { get; set; }
        public ProductTier ProductTier { get; set; }
    }
}