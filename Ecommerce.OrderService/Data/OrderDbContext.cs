using Ecommerce.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.OrderService.Data;

public sealed class OrderDbContext: DbContext
{
    public OrderDbContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<OrderModel> Orders { get; set; }
}