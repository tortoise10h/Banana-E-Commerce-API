namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductExportDetail
{
    public class CreateProductExportDetailRequest
    {
        public double Quantity { get; set; }
        public int ProductTierId { get; set; }
    }
}