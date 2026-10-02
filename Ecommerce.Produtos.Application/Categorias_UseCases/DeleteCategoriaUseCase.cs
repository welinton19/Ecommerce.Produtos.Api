using Ecommerce.Produtos.Domain.IRepository;

namespace Ecommerce.Produtos.Application.Categorias_UseCases;

public class DeleteCategoriaUseCase
{
    private readonly ICategoriasRepository _categoriaRepository;

    public DeleteCategoriaUseCase(ICategoriasRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    public async Task ExecuteAsync(int categoriaId)
    {
        var categoria = await _categoriaRepository.GetCategoriaByIdAsync(categoriaId);
        if (categoria == null)
        {
            throw new Exception("Categoria não encontrada.");
        }
        await _categoriaRepository.DeleteCategoriaAsync(categoriaId);
    }
}
