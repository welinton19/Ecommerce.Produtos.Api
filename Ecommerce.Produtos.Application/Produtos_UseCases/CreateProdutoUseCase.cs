using Ecommerce.Produtos.Application.DTOs.Create;
using Ecommerce.Produtos.Domain.Entities;
using Ecommerce.Produtos.Domain.IRepository;

namespace Ecommerce.Produtos.Application.UseCases;

public class CreateProdutoUseCase
{
    private readonly IProdutosRepository _produtosRepository;

    public CreateProdutoUseCase(IProdutosRepository produtosRepository)
    {
        _produtosRepository = produtosRepository;
    }

    public async Task<CreateProdutoResponse> ExecuteAsync(CreateProdutoRequest request)
    {
        var produto = new Produto
        {
            Name = request.Name,
            Preco = request.Preco,
            EstoqueQuantidade = request.EstoqueQuantidade,
            Quantidade = request.Quantidade,
            Descricao = request.Descricao,
            Imagem = request.Imagem,
            CategoriaId = request.CategoriaId,
            Categoria = request.Categoria
        };
        var createdProduto = await _produtosRepository.CreateAsync(produto);
        return new CreateProdutoResponse
        {
            Id = createdProduto.Id,
            Name = createdProduto.Name,
            Preco = createdProduto.Preco,
            EstoqueQuantidade = createdProduto.EstoqueQuantidade,
            Quantidade = createdProduto.Quantidade,
            Descricao = createdProduto.Descricao,
            Imagem = createdProduto.Imagem,
            CategoriaId = createdProduto.CategoriaId
        };
    }
}
