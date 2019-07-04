using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(p => p.ProductId);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(p => p.Value)
                .IsRequired();

            builder.HasOne(p => p.Client)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.ClientId)
                .IsRequired();
        }
    }
}
