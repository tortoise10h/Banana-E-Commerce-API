using System;
using System.Collections.Generic;

namespace Banana_E_Commerce_API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double SalePrice { get; set; }
        public double DiscountPrice { get; set; }
        public PriceCurrency PriceCurrentcy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public Admin Admin { get; set; }
        public int CreatedBy { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public Storage Storage { get; set; }
        public int StorageId { get; set; }

        public ICollection<ProductFavorite> ProductFavorites { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Rating> Rates { get; set; }
        public ICollection<CartDetail> CartDetails { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<SupplyProduct> SupplyProducts { get; set; }
        public ICollection<ProductExportDetail> ProductExportDetails { get; set; }

    }

    public enum PriceCurrency
    {
        Dollar,
        VND
    }
}