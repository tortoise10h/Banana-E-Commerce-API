namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.RequestImportDetail
{
    public class CreateRequestImportDetailRequest
    {
        public int ProductTierId { get; set; }
        public double Quantity { get; set; }
    }
}