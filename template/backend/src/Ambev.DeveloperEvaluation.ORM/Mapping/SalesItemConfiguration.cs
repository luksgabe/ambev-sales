
using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class SalesItemConfiguration : IEntityTypeConfiguration<SaleItem>
    {
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.ToTable("SaleItems");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

            builder.Property(u => u.UnitPrice)
                .IsRequired();

            builder.Property(u => u.Discount);
            builder.Property(u => u.IsCancelled)
                .IsRequired();
            builder.Property(u => u.Quantity)
                .IsRequired();

            builder.Property(u => u.CreatedAt).IsRequired();
            builder.Property(u => u.UpdatedAt);

            builder.HasOne(builder => builder.Sale)
                .WithMany(sale => sale.SaleItens)
                .HasForeignKey(saleItem => saleItem.SaleId);

            builder.HasOne(builder => builder.Product)
                .WithMany()
                .HasForeignKey(saleItem => saleItem.ProductId);

            builder.Property(u => u.CreatedAt).IsRequired();
            builder.Property(u => u.UpdatedAt);
        }
    }
}
