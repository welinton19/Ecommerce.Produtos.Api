using Ecommerce.Produtos.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Ecommerce.Produtos.Infrastructure.Factory;

public class ProdutoDbContextFactory : IDesignTimeDbContextFactory<ProdutoDbContext>
{
    public ProdutoDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ProdutoDbContext>();
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=EcommerceProdutoDb;Username=postgres;Password=25bbg20lk@W;");
        return new ProdutoDbContext(optionsBuilder.Options);
    }
}
