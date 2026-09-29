using Ecommerce.Produtos.Application.Categorias_DTOs.Reade;
using Ecommerce.Produtos.Domain.IRepository;

namespace Ecommerce.Produtos.Application.Categorias_UseCases;

public class ReadCategoriaUseCase
{
    private readonly ICategoriasRepository _categoriaRepository;

    public ReadCategoriaUseCase(ICategoriasRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    public async Task<ReadCategoriaResponse> ExecuteAsync(ReadCategoriaRequest request)
    {
        var categoria = await _categoriaRepository.GetByIdAsync(request.CategoriaId);
        if (categoria == null)
        {
            throw new Exception("Categoria não encontrada.");
        }
        return new ReadCategoriaResponse
        {
            CategoriaId = categoria.CategoriaId,
            Name = categoria.Name,
            Slug = categoria.Slug,
            CategoriaPaiId = categoria.CategoriaPaiId,
            Ativo = categoria.Ativo
        };
    }
}
