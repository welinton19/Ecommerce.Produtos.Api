using Ecommerce.Produtos.Application.DTOs.Create;
using Ecommerce.Produtos.Application.DTOs.Read;
using Ecommerce.Produtos.Application.DTOs.Update;

namespace Ecommerce.Produtos.Application.Interfaces;

public interface IProdutoService
{
    Task<ReadProdutoResponse> ReadProdutoAsync(int produtoId);
    Task<IEnumerable<ReadProdutoResponse>> ReadAllProdutosAsync();
    Task<CreateProdutoResponse> CreateProdutoAsync(CreateProdutoRequest request);
    Task<ReadProdutoResponse> UpdateProdutoAsync(int produtoId, UpdateProdutoRequest request);
    Task<bool> DeleteProdutoAsync(int produtoId);
}
