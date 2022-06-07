using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbCodeFirstApproach.Models
{
    public class ProductShopContext : DbContext
    {
        public ProductShopContext(DbContextOptions<ProductShopContext> options) : base(options) { }
        public ProductShopContext()
        {

        }


        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<User> Users { get; set; } = null!;

        public DbSet<CategoryProduct> CategoryProducts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database = ProductShop; User Id = sa; Password = routesetit2022");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryProduct>(entity =>
            {
                entity.HasKey("CategoryId", "ProductId");
            
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasOne(e => e.Seller)
                      .WithMany(e => e.SoldProducts)
                      .HasForeignKey(e => e.SellerId)
                      .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(e => e.Buyer)
                      .WithMany(e => e.BoughtProducts)
                      .HasForeignKey(e => e.BuyerId)
                      .OnDelete(DeleteBehavior.ClientSetNull);
            
            });
        }

    }
}
