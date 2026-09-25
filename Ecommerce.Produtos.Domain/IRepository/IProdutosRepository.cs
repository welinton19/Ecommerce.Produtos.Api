using Ecommerce.Produtos.Domain.Entities;
namespace Ecommerce.Produtos.Domain.IRepository;


public interface IProdutosRepository
{
    Task<Produto> GetByIdAsync(int id);
    Task<IEnumerable<Produto>> GetAllAsync();
    Task<IEnumerable<Produto>> GetByCategoriaIdAsync(int categoriaId);
    Task<Produto> CreateAsync(Produto produto);
    Task<Produto> UpdateAsync(Produto produto);
    Task<bool> DeleteAsync(int id);
}
