using System;
using Banana_E_Commerce_API.Entities;
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

        public static void Seed(this ModelBuilder modelBuilder)
        {
            /** Role Seed Data */
            modelBuilder.Entity<Role>()
                .HasData(
                    new Role
                    {
                        Id = 1,
                        RoleName = RoleName.Customer,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false
                    },
                    new Role
                    {
                        Id = 2,
                        RoleName = RoleName.Shipper,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false
                    },
                    new Role
                    {
                        Id = 3,
                        RoleName = RoleName.Admin,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false
                    },
                    new Role
                    {
                        Id = 4,
                        RoleName = RoleName.StorageManager,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false
                    },
                    new Role
                    {
                        Id = 5,
                        RoleName = RoleName.Manager,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        IsDeleted = false
                    }
                );
        }
    }
}