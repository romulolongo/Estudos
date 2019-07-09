using ProjetoModeloDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {

        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");

            builder.HasKey(c => c.ClientId);

            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(c => c.LastName)
                .IsRequired();

            builder.Property(c => c.DateRegister)
                .IsRequired();

            builder.Property(c => c.Email)
                .IsRequired();

            builder.Property(c => c.IsActive)
                .IsRequired()
                .HasColumnName("Active");
        }
    }
}
