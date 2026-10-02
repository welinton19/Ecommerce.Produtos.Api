using Ecommerce.Produtos.Application.Categorias_DTOs.Create;
using Ecommerce.Produtos.Application.Categorias_DTOs.Reade;
using Ecommerce.Produtos.Application.Categorias_DTOs.Update;

namespace Ecommerce.Produtos.Application.Interfaces;

public interface ICategoriaService
{
    Task<ReadCategoriaResponse> ReadCategoriaIdAsync(int categoriaId);
    Task<IEnumerable<ReadCategoriaResponse>> ReadAllCategoriasAsync();
    Task<ReadCategoriaResponse> CreateCategoriaAsync(CreateCategoriaRequest request);
    Task<ReadCategoriaResponse> UpdateCategoriaAsync(int categoriaId, UpdateCategoriaRequest request);
    Task<bool> DeleteCategoriaAsync(int categoriaId);
}
