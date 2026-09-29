using Ecommerce.Produtos.Application.DTOs.Create;
using Ecommerce.Produtos.Application.DTOs.Read;
using Ecommerce.Produtos.Application.Interfaces;
using Ecommerce.Produtos.Domain.Entities;
using Ecommerce.Produtos.Domain.IRepository;

namespace Ecommerce.Produtos.Application.Services;

public class ProdutoService : IProdutoService
{
    private readonly IProdutosRepository _produtoRepository;

    public ProdutoService(IProdutosRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public async Task<CreateProdutoResponse> CreateProdutoAsync(CreateProdutoRequest request)
    {
        var produto = new Produto
        {
            Name = request.Name,
            Preco = request.Preco,
            EstoqueQuantidade = request.EstoqueQuantidade,
            Quantidade = request.Quantidade,
            Descricao = request.Descricao,
            Imagem = request.Imagem,
            CategoriaId = request.CategoriaId
        };

        var createdProduto = await _produtoRepository.CreateProdutoAsync(produto);
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

    public async Task<bool> DeleteProdutoAsync(int produtoId)
    {
        return await _produtoRepository.DeleteAsync(produtoId);
    }

    public async Task<IEnumerable<ReadProdutoResponse>> ReadAllProdutosAsync()
    {
        return await _produtoRepository.GetAllAsync()
            .ContinueWith(task => task.Result.Select(produto => new ReadProdutoResponse
            {
                Id = produto.Id,
                Name = produto.Name,
                Preco = produto.Preco,
                EstoqueQuantidade = produto.EstoqueQuantidade,
                Quantidade = produto.Quantidade,
                Descricao = produto.Descricao,
                Imagem = produto.Imagem,
                CategoriaId = produto.CategoriaId
            }));
    }

    public async Task<ReadProdutoResponse> UpdateProdutoAsync(int produtoId, CreateProdutoRequest request)
    {
        var produto = await _produtoRepository.GetByIdAsync(produtoId);
        if (produto == null)
        {
            throw new Exception($"Produto with ID {produtoId} not found.");
        }

        await _produtoRepository.UpdateProdutoAsync(produto);

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
