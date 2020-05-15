using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Extensions;

namespace Banana_E_Commerce_API.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ImportBillDetail> ImportBillDetails { get; set; }
        public DbSet<ImportBill> ImportBills { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<ProductExportBill> ProductExportBills { get; set; }
        public DbSet<ProductExportDetail> ProductExportDetails { get; set; }
        public DbSet<ProductFavorite> ProductFavorites { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Rating> Rates { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<StorageManager> StorageManagers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierPayment> SupplierPayments { get; set; }
        public DbSet<SupplyProduct> SupplyProducts { get; set; }


        public DataContext(DbContextOptions options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }

        public DataContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to database
            options.UseSqlServer(Configuration.GetConnectionString("BananaFruitsEcommerceDBConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigDBTablesRelationship();

            modelBuilder.ConfigTablesRequirements();

            modelBuilder.Seed();
        }
    }
}