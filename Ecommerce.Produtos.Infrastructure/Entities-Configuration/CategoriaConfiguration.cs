using Ecommerce.Produtos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Produtos.Infrastructure.Entities_Configuration;

public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.HasKey(c => c.CategoriaId);
        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(c => c.Slug)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(c => c.CategoriaPaiId)
            .IsRequired();
        builder.Property(c => c.Ativo)
            .IsRequired();
        builder.HasOne(c => c.CategoriaPai)
            .WithMany()
            .HasForeignKey(c => c.CategoriaPaiId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
