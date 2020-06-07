namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Queries
{
    public class GetAllProductTierTransferReportsQuery
    {
        public int FromTierId { get; set; }
        public int ToTierId { get; set; }
        public double FromQuantity { get; set; }
        public double ToQuantity { get; set; }
    }
}