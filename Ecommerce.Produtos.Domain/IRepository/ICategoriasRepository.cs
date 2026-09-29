using Ecommerce.Produtos.Domain.Entities;

namespace Ecommerce.Produtos.Domain.IRepository;

public interface ICategoriasRepository
{
    Task<Categoria> GetCategoriaByIdAsync(int id);
    Task<IEnumerable<Categoria>> GetAllCategoriasAsync();
    Task<IEnumerable<Categoria>> GetByCategoriaPaiIdAsync(int categoriaPaiId);
    Task<Categoria> CreateCategoriaAsync(Categoria categoria);
    Task<Categoria> UpdateCategoriaAsync(Categoria categoria);
    Task<bool> DeleteCategoriaAsync (int id);
}
