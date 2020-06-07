namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.ProductTierTransferReport
{
    public class CreateProductTierTransferReportRequest
    {
        public int FromTierId { get; set; }
        public int ToTierId { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
    }
}