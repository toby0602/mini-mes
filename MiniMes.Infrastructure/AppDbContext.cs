using Microsoft.EntityFrameworkCore;
using MiniMes.Core;

namespace MiniMes.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<WorkOrder> WorkOrders => Set<WorkOrder>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WorkOrder>(e =>
        {
            e.Property(x => x.OrderNo).HasMaxLength(30).IsRequired();
            e.HasIndex(x => x.OrderNo).IsUnique();
            e.Property(x => x.ProductName).HasMaxLength(100).IsRequired();
            e.Property(x => x.Status).HasConversion<string>().HasMaxLength(20);
        });
    }
}