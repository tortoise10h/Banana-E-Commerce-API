namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.RequestImportDetail
{
    public class RequestImportDetailResponse
    {
        public int Id { get; set; }
        public int RequestImportProductId { get; set; }
        public int ProductTierId { get; set; }
        public double Quantity { get; set; }
    }
}