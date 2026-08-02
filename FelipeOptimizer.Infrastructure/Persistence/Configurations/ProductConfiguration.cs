using FelipeOptimizer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FelipeOptimizer.Infrastructure.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Nome)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Descricao)
            .HasMaxLength(500);

        builder.Property(x => x.Preco)
            .HasPrecision(18, 2);

        builder.Property(x => x.Estoque)
            .IsRequired();

        builder.Property(x => x.DataCadastro)
            .IsRequired();
    }
}