using Ecommerce.Produtos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Produtos.Infrastructure.Data;

public class ProdutoDbContext : DbContext
{
    public ProdutoDbContext(DbContextOptions<ProdutoDbContext> options) : base(options)
    {
    }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
}
