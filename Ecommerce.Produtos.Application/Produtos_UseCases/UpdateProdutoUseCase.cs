using Ecommerce.Produtos.Application.DTOs.Update;
using Ecommerce.Produtos.Domain.IRepository;

namespace Ecommerce.Produtos.Application.UseCases;

public class UpdateProdutoUseCase
{
    private readonly IProdutosRepository _produtosRepository;

    public UpdateProdutoUseCase(IProdutosRepository produtosRepository)
    {
        _produtosRepository = produtosRepository;
    }

    public async Task<UpdateProdutoResponse> ExecuteAsync(int id, UpdateProdutoRequest request)
    {
        var produto = await _produtosRepository.GetByIdAsync(id);
        if (produto == null)
        {
            throw new Exception($"Produto with id {id} not found.");
        }
        produto.Name = request.Name;
        produto.Preco = request.Preco;
        produto.EstoqueQuantidade = request.EstoqueQuantidade;
        produto.Quantidade = request.Quantidade;
        produto.Descricao = request.Descricao;
        produto.Imagem = request.Imagem;
        produto.CategoriaId = request.CategoriaId;
        var updatedProduto = await _produtosRepository.UpdateProdutoAsync(produto);
        return new UpdateProdutoResponse
        {
            Id = updatedProduto.Id,
            Name = updatedProduto.Name,
            Preco = updatedProduto.Preco,
            EstoqueQuantidade = updatedProduto.EstoqueQuantidade,
            Quantidade = updatedProduto.Quantidade,
            Descricao = updatedProduto.Descricao,
            Imagem = updatedProduto.Imagem,
            CategoriaId = updatedProduto.CategoriaId
        };
    }
}
