using Ecommerce.Produtos.Domain.IRepository;

namespace Ecommerce.Produtos.Application.UseCases;

public class DeleteProdutoUseCase
{
    private readonly IProdutosRepository _produtosRepository;

    public DeleteProdutoUseCase(IProdutosRepository produtosRepository)
    {
        _produtosRepository = produtosRepository;
    }

    public async Task<bool> ExecuteAsync(int id)
    {
        var produto = await _produtosRepository.GetByIdAsync(id);
        if (produto == null)
        {
            throw new Exception($"Produto with id {id} not found.");
        }
        return await _produtosRepository.DeleteAsync(id);
    }
}
