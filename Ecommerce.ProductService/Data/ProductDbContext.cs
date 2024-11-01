using Ecommerce.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.ProductService.Data;

public sealed class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 1, Name = "Apple", Quantity = 20, Price = 10 });
        modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 2, Name = "Orange", Quantity = 15, Price = 15 });
        modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 3, Name = "Banana", Quantity = 5, Price = 20 });
        
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<ProductModel> Products { get; set; }
}