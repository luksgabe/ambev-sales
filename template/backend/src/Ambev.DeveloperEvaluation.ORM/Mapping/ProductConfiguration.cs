﻿using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

            builder.Property(u => u.Name).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Description).IsRequired().HasMaxLength(500);
            builder.Property(u => u.Size).HasMaxLength(20).IsRequired();
            builder.Property(u => u.Color).HasMaxLength(15);

            builder.Property(u => u.CreatedAt).IsRequired();
            builder.Property(u => u.UpdatedAt);
        }
    }
}
