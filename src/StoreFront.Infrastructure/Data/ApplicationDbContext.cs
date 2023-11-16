using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StoreFront.Domain.Entities;

namespace StoreFront.Infrastructure.Data
{
    public sealed class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Products = Set<Product>();
        }

        public DbSet<Product> Products { get; set; }

        // Configure the EF Core model here
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Model configuration code here
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(p => p.Id).ValueGeneratedOnAdd();
                entity.Property(p => p.Name).IsRequired().HasMaxLength(100);
                entity.Property(p => p.Description).IsRequired().HasMaxLength(1000);
                entity.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
                entity.HasKey(p => p.Id);
            });
            
            // Seed roles
            modelBuilder.Entity<IdentityRole<int>>().HasData(new IdentityRole<int>() { Id = 1, Name = "User" }, new IdentityRole<int>() { Id = 2, Name = "Admin" });

        }
    }
}