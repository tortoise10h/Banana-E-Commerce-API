using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.ResponseModels.Product
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double SalePrice { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public PriceCurrency PriceCurrency { get; set; }
        public int CategoryId { get; set; }
        public int StorageId { get; set; }
        public int CreatedBy { get; set; }
    }
}