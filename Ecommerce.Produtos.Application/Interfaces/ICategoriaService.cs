using Ecommerce.Produtos.Application.Categorias_DTOs.Create;
using Ecommerce.Produtos.Application.Categorias_DTOs.Reade;

namespace Ecommerce.Produtos.Application.Interfaces;

public interface ICategoriaService
{
    Task<ReadCategoriaResponse> ReadCategoriaAsync(ReadCategoriaRequest request);
    Task<IEnumerable<ReadCategoriaResponse>> ReadAllCategoriasAsync();
    Task<ReadCategoriaResponse> CreateCategoriaAsync(CreateCategoriaRequest request);
    Task<ReadCategoriaResponse> UpdateCategoriaAsync(int categoriaId, CreateCategoriaRequest request);
    Task<bool> DeleteCategoriaAsync(int categoriaId);
}
