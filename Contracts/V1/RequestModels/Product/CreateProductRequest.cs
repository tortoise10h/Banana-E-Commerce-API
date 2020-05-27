using System.Collections.Generic;
using Banana_E_Commerce_API.Enums;
using Microsoft.AspNetCore.Http;

namespace Banana_E_Commerce_API.Contracts.V1.RequestModels.Product
{
    public class CreateProductRequest
    {
        public string Name { get; set; }
        public double EntryPrice { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public ProductUnit ProductUnit { get; set; }
        public PriceCurrency PriceCurrency { get; set; }
        public int CategoryId { get; set; }
        public int StorageId { get; set; }
        public double PricePerKg { get; set; }
        public double SalePrice { get; set; }
        public double KgSale { get; set; }
        public int DiscountPercentage { get; set; }
        public double AfterDiscountPrice { get; set; }
        public IEnumerable<IFormFile> Images { get; set; }

    }
}