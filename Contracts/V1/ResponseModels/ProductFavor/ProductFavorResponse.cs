namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.ProductFavor
{
    public class ProductFavorResponse
    {
        public int Id { get; set; }
        public int ProductTierId { get; set; }
        public int CustomerId { get; set; }
        public ProductTierResponseOfProductFavor ProductTier { get; set; }
    }
}