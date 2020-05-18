using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Product
{
    public class CreateProductRequest
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public ProductUnit ProductUnit { get; set; }
        public double SalePrice { get; set; }
        public PriceCurrency PriceCurrency { get; set; }
        public int CategoryId { get; set; }
        public int StorageId { get; set; }

    }
}