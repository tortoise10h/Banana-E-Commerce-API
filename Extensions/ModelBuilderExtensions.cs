using System;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Banana_E_Commerce_API.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void ConfigDBTablesRelationship(this ModelBuilder modelBuilder)
        {
            /** [User] and [Role] */
            modelBuilder.Entity<User>()
                .HasOne<Role>(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [User] and [RefreshToken] */
            modelBuilder.Entity<RefreshToken>()
                .HasOne<User>(x => x.User)
                .WithMany(x => x.RefreshTokens)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RefreshToken>()
                .HasKey(r => r.Token);

            /** [User] and [Manager] */
            modelBuilder.Entity<User>()
                .HasOne<Manager>(u => u.Manager)
                .WithOne(m => m.User)
                .HasForeignKey<Manager>(m => m.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [User] and [Admin] */
            modelBuilder.Entity<User>()
                .HasOne<Admin>(u => u.Admin)
                .WithOne(m => m.User)
                .HasForeignKey<Admin>(a => a.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // /** [Role] and [Manager] */
            // modelBuilder.Entity<Manager>()
            //     .HasMany<Role>(m => m.Roles)
            //     .WithOne(r => r.Manager)
            //     .HasForeignKey(r => r.CreatedBy)
            //     .OnDelete(DeleteBehavior.NoAction);


            /** [User] and [Customer] */
            modelBuilder.Entity<User>()
                .HasOne<Customer>(u => u.Customer)
                .WithOne(m => m.User)
                .HasForeignKey<Customer>(m => m.UserId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Customer] and [Address] */
            modelBuilder.Entity<Address>()
                .HasOne<Customer>(ad => ad.Customer)
                .WithMany(c => c.Addresses)
                .HasForeignKey(ad => ad.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Customer] and [Cart] */
            modelBuilder.Entity<Customer>()
                .HasOne<Cart>(c => c.Cart)
                .WithOne(c => c.Customer)
                .HasForeignKey<Cart>(c => c.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Address] and [Order] */
            modelBuilder.Entity<Address>()
                .HasOne<Order>(ad => ad.Order)
                .WithOne(o => o.Address)
                .HasForeignKey<Order>(o => o.AddressId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Customer] and [Order] */
            modelBuilder.Entity<Customer>()
                .HasMany<Order>(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Customer] and [ProductFavorite] */
            modelBuilder.Entity<Customer>()
                .HasMany<ProductFavorite>(c => c.ProductFavorites)
                .WithOne(pf => pf.Customer)
                .HasForeignKey(pf => pf.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Order] and [OrderItem] */
            modelBuilder.Entity<Order>()
                .HasMany<OrderItem>(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [ProductTier] and [ProductFavorite] */
            modelBuilder.Entity<ProductTier>()
                .HasMany<ProductFavorite>(p => p.ProductFavorites)
                .WithOne(pdf => pdf.ProductTier)
                .HasForeignKey(pdf => pdf.ProductTierId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [ProductTier] and [OrderItem] */
            modelBuilder.Entity<ProductTier>()
                .HasMany<OrderItem>(p => p.OrderItems)
                .WithOne(oi => oi.ProductTier)
                .HasForeignKey(oi => oi.ProductTierId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Customer] and [Rating] */
            modelBuilder.Entity<Customer>()
                .HasMany<Rating>(c => c.Rates)
                .WithOne(r => r.Customer)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [ProductTier] and [Rating] */
            modelBuilder.Entity<ProductTier>()
                .HasMany<Rating>(p => p.Rates)
                .WithOne(r => r.ProductTier)
                .HasForeignKey(r => r.ProductTierId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Admin] and [PaymentMethod] */
            modelBuilder.Entity<Admin>()
                .HasMany<PaymentMethod>(a => a.PaymentMethods)
                .WithOne(pm => pm.Admin)
                .HasForeignKey(pm => pm.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Cart] and [CartDetail] */
            modelBuilder.Entity<Cart>()
                .HasMany<CartDetail>(c => c.CartDetails)
                .WithOne(cd => cd.Cart)
                .HasForeignKey(cd => cd.CartId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [ProductTier] and [CartDetail] */
            modelBuilder.Entity<ProductTier>()
                .HasMany<CartDetail>(p => p.CartDetails)
                .WithOne(cd => cd.ProductTier)
                .HasForeignKey(cd => cd.ProductTierId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Admin] and [Notification] */
            modelBuilder.Entity<Admin>()
                .HasMany<Notification>(a => a.Notifications)
                .WithOne(n => n.Admin)
                .HasForeignKey(n => n.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);


            /** [User] and [Notification] */
            modelBuilder.Entity<User>()
                .HasMany<Notification>(u => u.Notifications)
                .WithOne(n => n.User)
                .HasForeignKey(n => n.NotificationTo)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Product] and [ProductImage] */
            modelBuilder.Entity<Product>()
                .HasMany<ProductImage>(p => p.ProductImages)
                .WithOne(pi => pi.Product)
                .HasForeignKey(pi => pi.ProductId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Admin] and [Product] */
            modelBuilder.Entity<Admin>()
                .HasMany<Product>(a => a.Products)
                .WithOne(p => p.Admin)
                .HasForeignKey(p => p.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Storage] and [Product] */
            modelBuilder.Entity<Storage>()
                .HasMany<Product>(s => s.Products)
                .WithOne(p => p.Storage)
                .HasForeignKey(p => p.StorageId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Category] and [Product] */
            modelBuilder.Entity<Category>()
                .HasMany<Product>(s => s.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Category] and [Admin] */
            modelBuilder.Entity<Admin>()
                .HasMany<Category>(a => a.Categories)
                .WithOne(c => c.Admin)
                .HasForeignKey(c => c.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Storage] and [StorageManager] */
            modelBuilder.Entity<Storage>()
                .HasMany<StorageManager>(s => s.StorageManagers)
                .WithOne(sm => sm.Storage)
                .HasForeignKey(sm => sm.StorageId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [StorageManager] and [ImportBill] */
            modelBuilder.Entity<StorageManager>()
                .HasMany<ImportBill>(sm => sm.ImportBills)
                .WithOne(ib => ib.StorageManager)
                .HasForeignKey(ib => ib.StorageManagerId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Storage] and [ImportBill] */
            modelBuilder.Entity<Storage>()
                .HasMany<ImportBill>(s => s.ImportBills)
                .WithOne(ib => ib.Storage)
                .HasForeignKey(ib => ib.StorageId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [StorageManager] and [ProductExportBill] */
            modelBuilder.Entity<StorageManager>()
                .HasMany<ProductExportBill>(sm => sm.ProductExportBills)
                .WithOne(peb => peb.StorageManager)
                .HasForeignKey(peb => peb.StorageManagerId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [ProductTier] and [ProductExportDetail] */
            modelBuilder.Entity<ProductTier>()
                .HasMany<ProductExportDetail>(p => p.ProductExportDetails)
                .WithOne(ped => ped.ProductTier)
                .HasForeignKey(ped => ped.ProductTierId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [ProductExportBill] and [ProductExportDetail] */
            modelBuilder.Entity<ProductExportBill>()
                .HasMany<ProductExportDetail>(peb => peb.ProductExportDetails)
                .WithOne(ped => ped.ProductExportBill)
                .HasForeignKey(ped => ped.ExportBillId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [ImportBill] and [ImportBillDetail] */
            modelBuilder.Entity<ImportBill>()
                .HasMany<ImportBillDetail>(ib => ib.ImportBillDetails)
                .WithOne(ibd => ibd.ImportBill)
                .HasForeignKey(ibd => ibd.ImportBillId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [ProductTier] and [ImportBillDetail] */
            modelBuilder.Entity<ProductTier>()
                .HasMany<ImportBillDetail>(pt => pt.ImportBillDetails)
                .WithOne(ibd => ibd.ProductTier)
                .HasForeignKey(ibd => ibd.ProductTierId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Product] and [ProductTier] */
            modelBuilder.Entity<Product>()
                .HasMany<ProductTier>(p => p.ProductTiers)
                .WithOne(pt => pt.Product)
                .HasForeignKey(pt => pt.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Tier] and [ProductTier] */
            modelBuilder.Entity<Tier>()
                .HasMany<ProductTier>(p => p.ProductTiers)
                .WithOne(pt => pt.Tier)
                .HasForeignKey(pt => pt.TierId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Order] and [RequestExportProduct] */
            modelBuilder.Entity<Order>()
                .HasOne<RequestExportProduct>(o => o.RequestExportProduct)
                .WithOne(rep => rep.Order)
                .HasForeignKey<RequestExportProduct>(rep => rep.OrderId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Admin] and [RequestExportProduct] */
            modelBuilder.Entity<Admin>()
                .HasMany<RequestExportProduct>(a => a.RequestExportProducts)
                .WithOne(rep => rep.Admin)
                .HasForeignKey(rep => rep.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            /** [RequestExportProduct] and [RequestExportDetail] */
            modelBuilder.Entity<RequestExportProduct>()
                .HasMany<RequestExportDetail>(rep => rep.RequestExportDetails)
                .WithOne(red => red.RequestExportProduct)
                .HasForeignKey(rep => rep.RequestExportProductId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [ProductTier] and [RequestExportDetail] */
            modelBuilder.Entity<ProductTier>()
                .HasMany<RequestExportDetail>(pt => pt.RequestExportDetails)
                .WithOne(rep => rep.ProductTier)
                .HasForeignKey(rep => rep.ProductTierId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [RequestExportProduct] and [ProductExportBill] */
            modelBuilder.Entity<RequestExportProduct>()
                .HasMany<ProductExportBill>(rep => rep.ProductExportBills)
                .WithOne(reb => reb.RequestExportProduct)
                .HasForeignKey(rep => rep.RequestExportProductId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Admin] and [RequestImportProduct] */
            modelBuilder.Entity<Admin>()
                .HasMany<RequestImportProduct>(a => a.RequestImportProducts)
                .WithOne(rip => rip.Admin)
                .HasForeignKey(rep => rep.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            /** [ProductTier] and [RequestImportDetail] */
            modelBuilder.Entity<ProductTier>()
                .HasMany<RequestImportDetail>(pt => pt.RequestImportDetails)
                .WithOne(rid => rid.ProductTier)
                .HasForeignKey(rep => rep.ProductTierId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [RequestImportProduct] and [RequestImportDetail] */
            modelBuilder.Entity<RequestImportProduct>()
                .HasMany<RequestImportDetail>(a => a.RequestImportDetails)
                .WithOne(rip => rip.RequestImportProduct)
                .HasForeignKey(rep => rep.RequestImportProductId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [RequestImportProduct] and [ImportBill] */
            modelBuilder.Entity<RequestImportProduct>()
                .HasMany<ImportBill>(rip => rip.ImportBills)
                .WithOne(ib => ib.RequestImportProduct)
                .HasForeignKey(ib => ib.RequestImportProductId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [StorageManager] and [ImportProductReport] */
            modelBuilder.Entity<StorageManager>()
                .HasMany<ImportProductReport>(sm => sm.ImportProductReports)
                .WithOne(ipr => ipr.StorageManager)
                .HasForeignKey(ipr => ipr.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            /** [RequestImportProduct] and [ImportProductReport] */
            modelBuilder.Entity<RequestImportProduct>()
                .HasMany<ImportProductReport>(rip => rip.ImportProductReports)
                .WithOne(ipr => ipr.RequestImportProduct)
                .HasForeignKey(ipr => ipr.RequestImportProductId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [StorageManager] and [ClassifyProductReport] */
            modelBuilder.Entity<StorageManager>()
                .HasMany<ProductTierTransferReport>(sm => sm.ProductTierTransferReports)
                .WithOne(cpr => cpr.StorageManager)
                .HasForeignKey(cpr => cpr.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            /** [ProductTier] and [ProductTierTransferReport] - Source*/
            modelBuilder.Entity<ProductTier>()
                .HasMany<ProductTierTransferReport>(pt => pt.ProductTierTransferReports)
                .WithOne(cpr => cpr.ProductTier)
                .HasForeignKey(cpr => cpr.FromTierId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [ProductTier] and [ProductTierTransferReport] - Destination */
            modelBuilder.Entity<ProductTier>()
                .HasMany<ProductTierTransferReport>(pt => pt.ProductTierTransferReports)
                .WithOne(cpr => cpr.ProductTier)
                .HasForeignKey(cpr => cpr.ToTierId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [ProductTier] and [RemoveProductQuantityReport] */
            modelBuilder.Entity<ProductTier>()
                .HasMany<RemoveProductQuantityReport>(pt => pt.RemoveProductQuantityReports)
                .WithOne(rpqr => rpqr.ProductTier)
                .HasForeignKey(rpqr => rpqr.ProductTierId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [StorageManager] and [RemoveProductQuantityReport] */
            modelBuilder.Entity<StorageManager>()
                .HasMany<RemoveProductQuantityReport>(sm => sm.RemoveProductQuantityReports)
                .WithOne(rpqr => rpqr.StorageManager)
                .HasForeignKey(rpqr => rpqr.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

        }

        public static void ConfigTablesRequirements(this ModelBuilder modelBuilder)
        {
            /** User */
            modelBuilder.Entity<User>()
                .Property(user => user.Email)
                    .IsRequired()
                    .HasMaxLength(255);

        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            /** Role Seed Data */
            modelBuilder.Entity<Role>()
                .HasData(
                    new Role
                    {
                        Id = 1,
                        RoleName = RoleNameEnum.Customer,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false
                    },
                    new Role
                    {
                        Id = 2,
                        RoleName = RoleNameEnum.Admin,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false
                    },
                    new Role
                    {
                        Id = 3,
                        RoleName = RoleNameEnum.StorageManager,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false
                    },
                    new Role
                    {
                        Id = 4,
                        RoleName = RoleNameEnum.Manager,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false
                    }
                );

            /** Storage Seed Data */
            modelBuilder.Entity<Storage>()
                .HasData(
                    new Storage
                    {
                        Id = 1,
                        Location = "Tiểu Vương Quốc Bình Chánh",
                        Size = 1000.2,
                        SizeUnit = "m2",
                        Name = "Hoàng Khố",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    }
                );

            /** Category Seed Data */
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Trái Cây Việt",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 1
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Trái Cây Nhập",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 2
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Trái Cây Sấy Khô",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 3
                    },
                    new Category
                    {
                        Id = 4,
                        Name = "Mứt Trái Cây>",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 4
                    }
                );

            /** Product Seed Data */
            modelBuilder.Entity<Product>()
                .HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "Bơ 034",
                        EntryPrice = 60_000,
                        Description = "Bơ 034 từ Việt Nam, Đắk Lắk",
                        Origin = "Việt Nam, Đắk Lắk",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 1,
                        CategoryId = 1,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Bơ Sáp",
                        EntryPrice = 58_000,
                        Description = "Bơ Sáp từ Việt Nam, Đắk Lắk",
                        Origin = "Việt Nam, Đắk Lắk",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 2,
                        CategoryId = 1,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Bưởi Da Xanh",
                        EntryPrice = 30_000,
                        Description = "Bưởi Da Xanh từ Việt Nam, Đồng Nai, Tân Triều",
                        Origin = "Việt Nam, Đồng Nai, Tân Triều",
                        ProductUnit = ProductUnit.BundleOfThree,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 3,
                        CategoryId = 1,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "Cà Chua Đen",
                        EntryPrice = 65_000,
                        Description = "Có sắc tố đặc biệt, rất hiệu dụng trong quá trình chống oxy hóa",
                        Origin = "Hà Nội",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 3,
                        CategoryId = 1,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 5,
                        Name = "Cam Sành",
                        EntryPrice = 15_000,
                        Description = "Cam Sành Miền Tây",
                        Origin = "Miền Tây",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 4,
                        CategoryId = 1,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 6,
                        Name = "Chanh Đào Tươi",
                        EntryPrice = 40_000,
                        Description = "Chanh đào tươi Đà Lạt",
                        Origin = "Đà Lạt",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 1,
                        CategoryId = 1,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 7,
                        Name = "Chôm Chôm Nhãn",
                        EntryPrice = 35_000,
                        Description = "Chôm chôm nhãn",
                        Origin = "Đồng Bằng Sông Cửu Long",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 2,
                        CategoryId = 1,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 8,
                        Name = "Nhãn Lồng",
                        EntryPrice = 25_000,
                        Description = "Nhãn Lồng",
                        Origin = "Hưng Yên",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 3,
                        CategoryId = 1,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 9,
                        Name = "Thanh Long Ruột Đỏ",
                        EntryPrice = 22_000,
                        Description = "Thanh Long Ruột Đỏ",
                        Origin = "Bình Thuận",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 4,
                        CategoryId = 1,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 10,
                        Name = "Thanh Long Ruột Trắng",
                        EntryPrice = 25_000,
                        Description = "Thanh long ruột trắng",
                        Origin = "Bình Thuận",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 1,
                        CategoryId = 1,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 11,
                        Name = "Dâu Tây Đà Lạt",
                        EntryPrice = 120_000,
                        Description = "Dâu tây đà lạt giống Mỹ",
                        Origin = "Đà Lạt",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 2,
                        CategoryId = 1,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 12,
                        Name = "Dưa Lưới",
                        EntryPrice = 30_000,
                        Description = "Dưa lưới Bình Dương",
                        Origin = "Bình Dương",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 3,
                        CategoryId = 1,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 13,
                        Name = "Dưới Pepino",
                        EntryPrice = 45_000,
                        Description = "Dưa Pepino Mexico",
                        Origin = "Mexico",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 4,
                        CategoryId = 2,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 14,
                        Name = "Cherry Mỹ",
                        EntryPrice = 310_000,
                        Description = "Cherry Mỹ",
                        Origin = "Mỹ",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 1,
                        CategoryId = 2,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 15,
                        Name = "Việt Quất Mỹ",
                        EntryPrice = 380_000,
                        Description = "Việt Quất Mỹ",
                        Origin = "Mỹ",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 2,
                        CategoryId = 2,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 16,
                        Name = "Dưa Lê Hàn",
                        EntryPrice = 180_000,
                        Description = "Dưa Lê Hàn",
                        Origin = "Hàn Quốc",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 3,
                        CategoryId = 2,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 17,
                        Name = "Táo New Zealand",
                        EntryPrice = 200_000,
                        Description = "Táo New Zealand",
                        Origin = "New Zealand",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 4,
                        CategoryId = 2,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 18,
                        Name = "Kiwi Vàng New Zealand ",
                        EntryPrice = 130_000,
                        Description = "Kiwi Vàng New Zealand ",
                        Origin = "New Zealand",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 1,
                        CategoryId = 2,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 19,
                        Name = "Nho xanh Úc",
                        EntryPrice = 320_000,
                        Description = "Nho xanh Úc",
                        Origin = "Úc",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 2,
                        CategoryId = 2,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 20,
                        Name = "Dâu Anh Đào Nhật",
                        EntryPrice = 610_000,
                        Description = "Dâu Anh Đào Nhật",
                        Origin = "Nhật Bản",
                        ProductUnit = ProductUnit.Pack,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 3,
                        CategoryId = 2,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 21,
                        Name = "Dưa Hấu Luna Piena Nhật",
                        EntryPrice = 170_000,
                        Description = "Dưa Hấu Luna Piena Nhật",
                        Origin = "Nhật Bản",
                        ProductUnit = ProductUnit.BundleOfThree,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 4,
                        CategoryId = 2,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 22,
                        Name = "Sầu Riêng Muthong Thái",
                        EntryPrice = 100_000,
                        Description = "Sầu Riêng Muthong Thái",
                        Origin = "Thái Lan",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 1,
                        CategoryId = 2,
                        StorageId = 1,
                    },
                    new Product
                    {
                        Id = 23,
                        Name = "Bơ Úc (Bơ Hass)",
                        EntryPrice = 140_000,
                        Description = "Bơ Úc (Bơ Hass)",
                        Origin = "Úc",
                        ProductUnit = ProductUnit.Kg,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = 2,
                        CategoryId = 2,
                        StorageId = 1,
                    }
                );

            /** Tier Seed Data */
            modelBuilder.Entity<Tier>()
                .HasData(
                    new Tier
                    {
                        Id = 1,
                        IsDeleted = false,
                        TierOption = TierEnum.tier1
                    },
                    new Tier
                    {
                        Id = 2,
                        IsDeleted = false,
                        TierOption = TierEnum.tier2
                    }
                );

            /** Product Tier Seed Data */
            modelBuilder.Entity<ProductTier>()
                .HasData(
                    /** Product Tier 1 */
                    new ProductTier
                    {
                        Id = 1,
                        ProductId = 1,
                        TierId = 1,
                        Quantity = 57,
                        PricePerKg = 100_000,
                        SalePrice = 100_000,
                        KgSale = 1,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 100_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 2,
                        ProductId = 2,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 110_000,
                        SalePrice = 110_000,
                        KgSale = 1,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 100_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 3,
                        ProductId = 3,
                        TierId = 1,
                        Quantity = 62,
                        PricePerKg = 90_000,
                        KgSale = 2.7,
                        SalePrice = 243_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 243_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 4,
                        ProductId = 4,
                        TierId = 1,
                        Quantity = 39,
                        PricePerKg = 130_000,
                        KgSale = 1,
                        SalePrice = 130_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 130_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 5,
                        ProductId = 5,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 45_000,
                        KgSale = 1,
                        SalePrice = 45_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 45_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 6,
                        ProductId = 6,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 80_000,
                        KgSale = 1,
                        SalePrice = 80_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 80_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 7,
                        ProductId = 7,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 75_000,
                        KgSale = 1,
                        SalePrice = 75_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 75_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 8,
                        ProductId = 8,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 65_000,
                        KgSale = 1,
                        SalePrice = 65_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 65_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 9,
                        ProductId = 9,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 66_000,
                        KgSale = 1,
                        SalePrice = 66_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 66_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 10,
                        ProductId = 10,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 58_000,
                        KgSale = 1,
                        SalePrice = 58_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 58_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 11,
                        ProductId = 11,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 260_000,
                        KgSale = 1,
                        SalePrice = 260_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 260_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 12,
                        ProductId = 12,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 70_000,
                        KgSale = 1,
                        SalePrice = 70_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 70_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 13,
                        ProductId = 13,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 100_000,
                        KgSale = 1,
                        SalePrice = 100_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 100_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 14,
                        ProductId = 14,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 620_000,
                        KgSale = 1,
                        SalePrice = 620_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 620_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 15,
                        ProductId = 15,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 700_000,
                        KgSale = 1,
                        SalePrice = 700_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 700_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 16,
                        ProductId = 16,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 400_000,
                        KgSale = 1,
                        SalePrice = 400_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 400_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 17,
                        ProductId = 17,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 480_000,
                        KgSale = 1,
                        SalePrice = 480_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 480_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 18,
                        ProductId = 18,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 330_000,
                        KgSale = 1,
                        SalePrice = 330_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 330_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 19,
                        ProductId = 19,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 700_000,
                        KgSale = 1,
                        SalePrice = 700_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 700_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 20,
                        ProductId = 20,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 400_000,
                        KgSale = 0.5,
                        SalePrice = 400_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 400_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 21,
                        ProductId = 21,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 900_000,
                        KgSale = 3,
                        SalePrice = 900_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 900_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 22,
                        ProductId = 22,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 230_000,
                        KgSale = 1,
                        SalePrice = 230_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 230_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 23,
                        ProductId = 23,
                        TierId = 1,
                        Quantity = 50,
                        PricePerKg = 300_000,
                        KgSale = 1,
                        SalePrice = 300_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 300_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    /** Product Tier 2 */
                    new ProductTier
                    {
                        Id = 24,
                        ProductId = 1,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 100_000,
                        SalePrice = 100_000,
                        KgSale = 1,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 100_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 25,
                        ProductId = 2,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 110_000,
                        SalePrice = 110_000,
                        KgSale = 1,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 100_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 26,
                        ProductId = 3,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 90_000,
                        KgSale = 2.7,
                        SalePrice = 243_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 243_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 27,
                        ProductId = 4,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 130_000,
                        KgSale = 1,
                        SalePrice = 130_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 130_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 28,
                        ProductId = 5,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 45_000,
                        KgSale = 1,
                        SalePrice = 45_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 45_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 29,
                        ProductId = 6,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 80_000,
                        KgSale = 1,
                        SalePrice = 80_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 80_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 30,
                        ProductId = 7,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 75_000,
                        KgSale = 1,
                        SalePrice = 75_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 75_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 31,
                        ProductId = 8,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 65_000,
                        KgSale = 1,
                        SalePrice = 65_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 65_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 32,
                        ProductId = 9,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 66_000,
                        KgSale = 1,
                        SalePrice = 66_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 66_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 33,
                        ProductId = 10,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 58_000,
                        KgSale = 1,
                        SalePrice = 58_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 58_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 34,
                        ProductId = 11,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 260_000,
                        KgSale = 1,
                        SalePrice = 260_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 260_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 35,
                        ProductId = 12,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 70_000,
                        KgSale = 1,
                        SalePrice = 70_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 70_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 36,
                        ProductId = 13,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 100_000,
                        KgSale = 1,
                        SalePrice = 100_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 100_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 37,
                        ProductId = 14,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 620_000,
                        KgSale = 1,
                        SalePrice = 620_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 620_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 38,
                        ProductId = 15,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 700_000,
                        KgSale = 1,
                        SalePrice = 700_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 700_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 39,
                        ProductId = 16,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 400_000,
                        KgSale = 1,
                        SalePrice = 400_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 400_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 40,
                        ProductId = 17,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 480_000,
                        KgSale = 1,
                        SalePrice = 480_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 480_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 41,
                        ProductId = 18,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 330_000,
                        KgSale = 1,
                        SalePrice = 330_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 330_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 42,
                        ProductId = 19,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 700_000,
                        KgSale = 1,
                        SalePrice = 700_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 700_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 43,
                        ProductId = 20,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 400_000,
                        KgSale = 0.5,
                        SalePrice = 400_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 400_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 44,
                        ProductId = 21,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 900_000,
                        KgSale = 3,
                        SalePrice = 900_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 900_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 45,
                        ProductId = 22,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 230_000,
                        KgSale = 1,
                        SalePrice = 230_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 230_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    },
                    new ProductTier
                    {
                        Id = 46,
                        ProductId = 23,
                        TierId = 2,
                        Quantity = 0,
                        PricePerKg = 300_000,
                        KgSale = 1,
                        SalePrice = 300_000,
                        DiscountPercentage = 0,
                        AfterDiscountPrice = 300_000,
                        PriceCurrency = PriceCurrency.VND,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false,
                    }
                );
        }
    }
}