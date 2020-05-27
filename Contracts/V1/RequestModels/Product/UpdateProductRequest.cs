using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Product
{
    public class UpdateProductRequest
    {
        public string Name { get; set; }
        public ProductUnit ProductUnit { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public PriceCurrency PriceCurrency { get; set; }
    }
}