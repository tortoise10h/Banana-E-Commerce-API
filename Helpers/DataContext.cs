using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Banana_E_Commerce_API.Entities;

namespace Banana_E_Commerce_API.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbSet<User> Users { get; set; }


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
            /** ========== CONFIG DB TABLES REQUIREMENT ========== */
            modelBuilder.Entity<User>()
                .Property(user => user.Email)
                    .IsRequired()
                    .HasMaxLength(255);

            /** ========== CONFIG DB TABLES RELATIONSHIP ========== */
            /** User and Role */
            modelBuilder.Entity<User>()
                .HasOne<Role>(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

        }

    }
}