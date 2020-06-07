namespace Banana_E_Commerce_API.Domains
{
    public class GetAllProductTierTransferReportsFilter
    {
        public int FromTierId { get; set; }
        public int ToTierId { get; set; }
        public double FromQuantity { get; set; }
        public double ToQuantity { get; set; }
    }
}