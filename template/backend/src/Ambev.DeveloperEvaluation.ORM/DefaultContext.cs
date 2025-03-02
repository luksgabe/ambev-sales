using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using System.Reflection.Emit;

namespace Ambev.DeveloperEvaluation.ORM;

public class DefaultContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleItem> SaleItems { get; set; }
    public DbSet<Branch> Branches { get; set; }

    public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
        OnSeed(modelBuilder);
    }

    private void OnSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = Guid.NewGuid(), Name = "Laptop", Description = "High-performance laptop", Color = "Silver", Size = "15-inch", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Wireless Mouse", Description = "Ergonomic wireless mouse", Color = "Black", Size = "Medium", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Mechanical Keyboard", Description = "RGB backlit keyboard", Color = "White", Size = "Full-size", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Gaming Monitor", Description = "144Hz refresh rate monitor", Color = "Black", Size = "27-inch", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "USB-C Hub", Description = "Multiport adapter", Color = "Grey", Size = "Compact", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "External Hard Drive", Description = "1TB storage drive", Color = "Black", Size = "Portable", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Smartphone", Description = "Latest model smartphone", Color = "Blue", Size = "6-inch", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Bluetooth Speaker", Description = "Portable wireless speaker", Color = "Red", Size = "Small", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Noise Cancelling Headphones", Description = "Wireless noise-canceling headphones", Color = "Black", Size = "Over-ear", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Smartwatch", Description = "Water-resistant smartwatch", Color = "Silver", Size = "40mm", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Tablet", Description = "High-resolution tablet", Color = "Gold", Size = "10-inch", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Graphic Tablet", Description = "Professional drawing tablet", Color = "Black", Size = "Large", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Webcam", Description = "1080p HD webcam", Color = "Black", Size = "Compact", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Microphone", Description = "Professional podcast microphone", Color = "Silver", Size = "Medium", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "VR Headset", Description = "Virtual reality headset", Color = "Black", Size = "Adjustable", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Drone", Description = "4K camera drone", Color = "White", Size = "Portable", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Portable SSD", Description = "Fast external SSD", Color = "Black", Size = "500GB", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "HDMI Cable", Description = "High-speed HDMI cable", Color = "Black", Size = "6ft", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Wireless Charger", Description = "Fast charging pad", Color = "White", Size = "Small", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Gaming Chair", Description = "Ergonomic gaming chair", Color = "Red", Size = "Large", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Smart Bulb", Description = "WiFi-enabled LED bulb", Color = "Multi-color", Size = "Standard", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Portable Power Bank", Description = "10000mAh fast-charging power bank", Color = "Black", Size = "Compact", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Fitness Tracker", Description = "Activity tracking smartwatch", Color = "Blue", Size = "Medium", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Coffee Maker", Description = "Automatic drip coffee maker", Color = "Silver", Size = "Medium", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Air Purifier", Description = "HEPA filter air purifier", Color = "White", Size = "Large", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Electric Toothbrush", Description = "Rechargeable electric toothbrush", Color = "White", Size = "Small", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Standing Desk", Description = "Adjustable height standing desk", Color = "Brown", Size = "Large", CreatedAt = DateTime.UtcNow },
            new Product { Id = Guid.NewGuid(), Name = "Robot Vacuum", Description = "Smart robotic vacuum cleaner", Color = "Black", Size = "Compact", CreatedAt = DateTime.UtcNow }
        );
    }
}
public class YourDbContextFactory : IDesignTimeDbContextFactory<DefaultContext>
{
    public DefaultContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<DefaultContext>();
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        builder.UseNpgsql(connectionString);

        

        return new DefaultContext(builder.Options);
    }


}