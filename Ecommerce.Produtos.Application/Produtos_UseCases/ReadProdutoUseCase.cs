using Ecommerce.Produtos.Application.DTOs.Read;
using Ecommerce.Produtos.Domain.IRepository;

namespace Ecommerce.Produtos.Application.UseCases;

public class ReadProdutoUseCase
{
    private readonly IProdutosRepository _produtosRepository;

    public ReadProdutoUseCase(IProdutosRepository produtosRepository)
    {
        _produtosRepository = produtosRepository;
    }

    public async Task<ReadProdutoResponse> ExecuteAsync(int id)
    {
        var produto = await _produtosRepository.GetByIdAsync(id);
        if (produto == null)
        {
            throw new Exception($"Produto with id {id} not found.");
        }
        return new ReadProdutoResponse
        {
            Id = produto.Id,
            Name = produto.Name,
            Preco = produto.Preco,
            EstoqueQuantidade = produto.EstoqueQuantidade,
            Quantidade = produto.Quantidade,
            Descricao = produto.Descricao,
            Imagem = produto.Imagem,
            CategoriaId = produto.CategoriaId
        };
    }
}
