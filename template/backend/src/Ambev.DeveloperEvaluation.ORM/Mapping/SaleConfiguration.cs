﻿using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sales");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

            builder.Property(u => u.SaleDate)
                .IsRequired();

            builder.Property(u => u.TotalSaleAmount)
               .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder.Property(u => u.CreatedAt).IsRequired();
            builder.Property(u => u.UpdatedAt);

            builder.HasOne(u => u.Customer)
                .WithMany()
                .HasForeignKey(u => u.CustomerId);

            builder.HasOne(u => u.Branch)
                .WithMany(b => b.Sales)
                .HasForeignKey(u => u.BranchId);

            builder.HasMany(u => u.SaleItens)
                .WithOne(u => u.Sale)
                .HasForeignKey(u => u.SaleId);
        }
    }
}
