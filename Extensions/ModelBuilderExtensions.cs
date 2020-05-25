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


            /** [Product] and [ProductFavorite] */
            modelBuilder.Entity<Product>()
                .HasMany<ProductFavorite>(p => p.ProductFavorites)
                .WithOne(pdf => pdf.Product)
                .HasForeignKey(pdf => pdf.ProductId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Product] and [OrderItem] */
            modelBuilder.Entity<Product>()
                .HasMany<OrderItem>(p => p.OrderItems)
                .WithOne(oi => oi.Product)
                .HasForeignKey(oi => oi.ProductId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Customer] and [Rating] */
            modelBuilder.Entity<Customer>()
                .HasMany<Rating>(c => c.Rates)
                .WithOne(r => r.Customer)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Product] and [Rating] */
            modelBuilder.Entity<Product>()
                .HasMany<Rating>(p => p.Rates)
                .WithOne(r => r.Product)
                .HasForeignKey(r => r.ProductId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Order] and [Shipment] */
            modelBuilder.Entity<Order>()
                .HasOne<Shipment>(o => o.Shipment)
                .WithOne(sm => sm.Order)
                .HasForeignKey<Shipment>(sm => sm.OrderId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Admin] and [PaymentMethod] */
            modelBuilder.Entity<Admin>()
                .HasMany<PaymentMethod>(a => a.PaymentMethods)
                .WithOne(pm => pm.Admin)
                .HasForeignKey(pm => pm.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Invoice] and [PaymentMethod] */
            modelBuilder.Entity<Invoice>()
                .HasOne<PaymentMethod>(i => i.PaymentMethod)
                .WithMany(pm => pm.Invoices)
                .HasForeignKey(i => i.PaymentMethodId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Invoice] and [Shipment] */
            modelBuilder.Entity<Invoice>()
                .HasOne<Shipment>(i => i.Shipment)
                .WithOne(sm => sm.Invoice)
                .HasForeignKey<Invoice>(i => i.ShipmentId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [User] and [Shipper] */
            modelBuilder.Entity<User>()
                .HasOne<Shipper>(u => u.Shipper)
                .WithOne(s => s.User)
                .HasForeignKey<Shipper>(s => s.UserId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Cart] and [CartDetail] */
            modelBuilder.Entity<Cart>()
                .HasMany<CartDetail>(c => c.CartDetails)
                .WithOne(cd => cd.Cart)
                .HasForeignKey(cd => cd.CartId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Product] and [CartDetail] */
            modelBuilder.Entity<Product>()
                .HasMany<CartDetail>(p => p.CartDetails)
                .WithOne(cd => cd.Product)
                .HasForeignKey(cd => cd.ProductId)
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


            /** [Shipper] and [Shipment] */
            modelBuilder.Entity<Shipper>()
                .HasMany<Shipment>(sp => sp.Shipments)
                .WithOne(sm => sm.Shipper)
                .HasForeignKey(sm => sm.ShipperId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Admin] and [Shipment] */
            modelBuilder.Entity<Admin>()
                .HasMany<Shipment>(a => a.Shipments)
                .WithOne(sm => sm.Admin)
                .HasForeignKey(sm => sm.CreatedBy)
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


            /** [Product] and [SupplyProduct] */
            modelBuilder.Entity<Product>()
                .HasMany<SupplyProduct>(p => p.SupplyProducts)
                .WithOne(sp => sp.Product)
                .HasForeignKey(sp => sp.ProductId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [StorageManager] and [ProductExportBill] */
            modelBuilder.Entity<StorageManager>()
                .HasMany<ProductExportBill>(sm => sm.ProductExportBills)
                .WithOne(peb => peb.StorageManager)
                .HasForeignKey(peb => peb.StorageManagerId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Product] and [ProductExportDetail] */
            modelBuilder.Entity<Product>()
                .HasMany<ProductExportDetail>(p => p.ProductExportDetails)
                .WithOne(ped => ped.Product)
                .HasForeignKey(ped => ped.ProductId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [ProductExportBill] and [ProductExportDetail] */
            modelBuilder.Entity<ProductExportBill>()
                .HasMany<ProductExportDetail>(peb => peb.ProductExportDetails)
                .WithOne(ped => ped.ProductExportBill)
                .HasForeignKey(ped => ped.ExportBillId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Supplier] and [SupplyProduct] */
            modelBuilder.Entity<Supplier>()
                .HasMany<SupplyProduct>(s => s.SupplyProducts)
                .WithOne(sp => sp.Supplier)
                .HasForeignKey(sp => sp.SupplierId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [SupplyProduct] and [ImportBillDetail] */
            modelBuilder.Entity<SupplyProduct>()
                .HasMany<ImportBillDetail>(s => s.ImportBillDetails)
                .WithOne(sp => sp.SupplyProduct)
                .HasForeignKey(sp => sp.SupplyProductId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [ImportBill] and [ImportBillDetail] */
            modelBuilder.Entity<ImportBill>()
                .HasMany<ImportBillDetail>(ib => ib.ImportBillDetails)
                .WithOne(ibd => ibd.ImportBill)
                .HasForeignKey(ibd => ibd.ImportBillId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Admin] and [SupplierPayment] */
            modelBuilder.Entity<Admin>()
                .HasMany<SupplierPayment>(s => s.SupplierPayments)
                .WithOne(sp => sp.Admin)
                .HasForeignKey(sp => sp.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Supplier] and [SupplierPayment] */
            modelBuilder.Entity<Supplier>()
                .HasMany<SupplierPayment>(s => s.SupplierPayments)
                .WithOne(sp => sp.Supplier)
                .HasForeignKey(sp => sp.SupplierId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [Supplier] and [ImportBill] */
            modelBuilder.Entity<Supplier>()
                .HasMany<ImportBill>(s => s.ImportBills)
                .WithOne(ib => ib.Supplier)
                .HasForeignKey(ib => ib.SupplierId)
                .OnDelete(DeleteBehavior.NoAction);


            /** [ProductExportBill] and [Shipment] */
            modelBuilder.Entity<ProductExportBill>()
                .HasOne<Shipment>(s => s.Shipment)
                .WithOne(peb => peb.ProductExportBill)
                .HasForeignKey<Shipment>(s => s.ProductExportBillId)
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
                        RoleName = RoleNameEnum.Shipper,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false
                    },
                    new Role
                    {
                        Id = 3,
                        RoleName = RoleNameEnum.Admin,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false
                    },
                    new Role
                    {
                        Id = 4,
                        RoleName = RoleNameEnum.StorageManager,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false
                    },
                    new Role
                    {
                        Id = 5,
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
                        CreatedBy = 3
                    }
                );

            // /** Category Seed Data */
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
                        Price = 100_000,
                        SalePrice = 90_000,
                        Quantity = 100,
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
                        Price = 90_000,
                        SalePrice = 70_000,
                        Quantity = 87,
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
                        Price = 160_000,
                        SalePrice = 140_000,
                        Quantity = 60,
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
                        Price = 110_000,
                        SalePrice = 90_000,
                        Quantity = 27,
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
                        Price = 40_000,
                        SalePrice = 30_000,
                        Quantity = 23,
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
                        Price = 80_000,
                        SalePrice = 70_000,
                        Quantity = 54,
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
                        Price = 75_000,
                        SalePrice = 60_000,
                        Quantity = 122,
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
                        Price = 50_000,
                        SalePrice = 38_000,
                        Quantity = 89,
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
                        Price = 55_000,
                        SalePrice = 45_000,
                        Quantity = 65,
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
                        Price = 40_000,
                        SalePrice = 30_000,
                        Quantity = 50,
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
                        Price = 200_000,
                        SalePrice = 180_000,
                        Quantity = 44,
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
                        Price = 70_000,
                        SalePrice = 60_000,
                        Quantity = 33,
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
                        Price = 150_000,
                        SalePrice = 120_000,
                        Quantity = 21,
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
                        Price = 750_000,
                        SalePrice = 700_000,
                        Quantity = 12,
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
                        Price = 900_000,
                        SalePrice = 800_000,
                        Quantity = 19,
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
                        Price = 400_000,
                        SalePrice = 300_000,
                        Quantity = 28,
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
                        Price = 450_000,
                        SalePrice = 400_000,
                        Quantity = 21,
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
                        Price = 300_000,
                        SalePrice = 260_000,
                        Quantity = 21,
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
                        Price = 610_000,
                        SalePrice = 600_000,
                        Quantity = 65,
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
                        Price = 1000_000,
                        SalePrice = 950_000,
                        Quantity = 150,
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
                        Price = 550_000,
                        SalePrice = 450_000,
                        Quantity = 20,
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
                        Price = 200_000,
                        SalePrice = 185_000,
                        Quantity = 30,
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
                        Price = 450_000,
                        SalePrice = 350_000,
                        Quantity = 51,
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
        }
    }
}