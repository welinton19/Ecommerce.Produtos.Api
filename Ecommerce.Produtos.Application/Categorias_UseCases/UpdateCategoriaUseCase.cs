using Ecommerce.Produtos.Application.Categorias_DTOs.Update;
using Ecommerce.Produtos.Domain.IRepository;

namespace Ecommerce.Produtos.Application.Categorias_UseCases;

public class UpdateCategoriaUseCase
{
    private readonly ICategoriasRepository _categoriaRepository;

    public UpdateCategoriaUseCase(ICategoriasRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    public async Task ExecuteAsync(UpdateCategoriaRequest request)
    {
        var categoria = await _categoriaRepository.GetCategoriaByIdAsync(request.CategoriaId);
        if (categoria == null)
        {
            throw new Exception("Categoria não encontrada.");
        }
        categoria.Name = request.Name;
        //categoria.Slug = request.Slug;
        //categoria.CategoriaPaiId = request.CategoriaPaiId;
        //categoria.Ativo = request.Ativo;
        await _categoriaRepository.UpdateCategoriaAsync(categoria);
    }
}
