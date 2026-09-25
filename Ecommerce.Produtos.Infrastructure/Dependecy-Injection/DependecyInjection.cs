using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Ecommerce.Produtos.Infrastructure.Data;
using Ecommerce.Produtos.Domain.IRepository;
using Ecommerce.Produtos.Infrastructure.Repository;


namespace Ecommerce.Produtos.Infrastructure.Dependecy_Injection;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // Add your infrastructure services here
        services.AddDbContext<ProdutoDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("ProdutoConnection"),
                (b => b.MigrationsAssembly(typeof(ProdutoDbContext).Assembly.FullName)));
        });


        services.AddScoped<IProdutosRepository, ProdutoRepository>();
        services.AddScoped<ICategoriasRepository, CategoriaRepository>();

        return services;
    }
}
