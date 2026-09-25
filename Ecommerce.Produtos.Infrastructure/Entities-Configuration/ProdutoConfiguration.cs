using Ecommerce.Produtos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Produtos.Infrastructure.Entities_Configuration;

public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(p => p.Preco)
            .IsRequired()
            .HasPrecision(18, 2);
        builder.Property(p => p.EstoqueQuantidade)
            .IsRequired();
        builder.Property(p => p.Quantidade)
            .IsRequired();
        builder.Property(p => p.Descricao)
            .HasMaxLength(500);
        builder.Property(p => p.Imagem)
            .HasMaxLength(200);
        builder.HasOne(p => p.Categoria)
            .WithMany() 
            .HasForeignKey(p => p.CategoriaId)
            .IsRequired();

    }
}
