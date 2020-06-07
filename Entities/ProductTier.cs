using System;
using System.Collections.Generic;
using Banana_E_Commerce_API.Enums;

namespace Banana_E_Commerce_API.Entities
{
    public class ProductTier
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int TierId { get; set; }
        public double Quantity { get; set; }
        public double PricePerKg { get; set; }
        public double SalePrice { get; set; }
        public double KgSale { get; set; }
        public int DiscountPercentage { get; set; }
        public double AfterDiscountPrice { get; set; }
        public PriceCurrency PriceCurrency { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public Product Product { get; set; }
        public Tier Tier { get; set; }
        public ICollection<Rating> Rates { get; set; }
        public ICollection<CartDetail> CartDetails { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<ProductFavorite> ProductFavorites { get; set; }
        public ICollection<ProductExportDetail> ProductExportDetails { get; set; }
        public ICollection<RequestExportDetail> RequestExportDetails { get; set; }
        public ICollection<RequestImportDetail> RequestImportDetails { get; set; }
        public ICollection<ProductTierTransferReport> ProductTierTransferReports { get; set; }
        public ICollection<RemoveProductQuantityReport> RemoveProductQuantityReports { get; set; }
        public ICollection<ImportBillDetail> ImportBillDetails { get; set; }
    }
}