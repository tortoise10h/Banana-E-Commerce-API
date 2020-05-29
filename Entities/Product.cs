using System;
using System.Collections.Generic;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double EntryPrice { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public ProductUnit ProductUnit { get; set; }
        public PriceCurrency PriceCurrency { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public int CategoryId { get; set; }
        public int StorageId { get; set; }

        public Admin Admin { get; set; }
        public Category Category { get; set; }
        public Storage Storage { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductTier> ProductTiers { get; set; }

    }


}