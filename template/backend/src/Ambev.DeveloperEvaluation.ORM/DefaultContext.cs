using Ambev.DeveloperEvaluation.Application.Configuration.Messaging;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using System.Reflection.Emit;

namespace Ambev.DeveloperEvaluation.ORM;

public class DefaultContext : DbContext
{
    private readonly MongoSeeder _mongoSeeder;

    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<SaleItem> SaleItems { get; set; }
    public DbSet<Branch> Branches { get; set; }

    public DefaultContext(DbContextOptions<DefaultContext> options, MongoSeeder mongoSeeder) : base(options)
    {
        _mongoSeeder = mongoSeeder;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<ValidationResult>();
        modelBuilder.Ignore<Event>();

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
        OnSeed(modelBuilder);
    }

    private async void OnSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(_mongoSeeder.GetProducts());
        modelBuilder.Entity<Branch>().HasData(_mongoSeeder.GetBranches());
    }
}
