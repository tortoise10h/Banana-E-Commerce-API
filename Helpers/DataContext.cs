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
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }


        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to database
            options.UseSqlServer(Configuration.GetConnectionString("BananaFruitsEcommerceDBConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /** ========== CONFIG DB TABLES REQUIREMENT ========== */
            modelBuilder.Entity<User>()
                .Property(user => user.Email)
                    .IsRequired()
                    .HasMaxLength(255);

            modelBuilder.ConfigDBTablesRelationship();

            modelBuilder.Seed();
        }
    }
}