using Ecommerce.Produtos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Produtos.Infrastructure.Data;

public class ProdutoDbContext : DbContext
{
    public ProdutoDbContext(DbContextOptions<ProdutoDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Produto>().ToTable("Produtos");
        modelBuilder.Entity<Categoria>().ToTable("Categorias");
    }

    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
}
