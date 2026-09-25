using Ecommerce.Produtos.Domain.Entities;

namespace Ecommerce.Produtos.Domain.IRepository;

public interface ICategoriasRepository
{
    Task<Categoria> GetByIdAsync(int id);
    Task<IEnumerable<Categoria>> GetAllAsync();
    Task<IEnumerable<Categoria>> GetByCategoriaPaiIdAsync(int categoriaPaiId);
    Task<Categoria> CreateAsync(Categoria categoria);
    Task<Categoria> UpdateAsync(Categoria categoria);
    Task<bool> DeleteAsync(int id);
}
