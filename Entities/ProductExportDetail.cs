namespace Banana_E_Commerce_API.Entities
{
    public class ProductExportDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public ProductExportBill ProductExportBill { get; set; }
        public int ExportBillId { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}