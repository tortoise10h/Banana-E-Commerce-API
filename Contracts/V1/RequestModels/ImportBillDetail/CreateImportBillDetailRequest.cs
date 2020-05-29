namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.ImportBillDetail
{
    public class CreateImportBillDetailRequest
    {
        public double Quantity { get; set; }
        public double Price { get; set; }
        public int ProductTierId { get; set; }
    }
}