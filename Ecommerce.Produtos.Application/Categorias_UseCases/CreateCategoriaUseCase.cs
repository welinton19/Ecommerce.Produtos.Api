using Ecommerce.Produtos.Application.Categorias_DTOs.Create;
using Ecommerce.Produtos.Domain.Entities;
using Ecommerce.Produtos.Domain.IRepository;

namespace Ecommerce.Produtos.Application.Categorias_UseCases;

public class CreateCategoriaUseCase
{
    private readonly ICategoriasRepository _categoriaRepository;

    public CreateCategoriaUseCase(ICategoriasRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    public async Task<CreateCategoriaResponse> ExecuteAsync(CreateCategoriaRequest request)
    {
        var categoria = new Categoria
        {
            Name = request.Name,
            Slug = request.Slug,
            CategoriaPaiId = request.CategoriaPaiId,
            Ativo = request.Ativo
        };

        await _categoriaRepository.CreateCategoriaAsync(categoria);

        return new CreateCategoriaResponse
        {
            CategoriaId = categoria.CategoriaId,
            Name = categoria.Name,
            Slug = categoria.Slug,
            CategoriaPaiId = categoria.CategoriaPaiId,
            Ativo = categoria.Ativo
        };
    }
}
