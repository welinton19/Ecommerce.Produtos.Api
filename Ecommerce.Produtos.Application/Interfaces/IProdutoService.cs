using Ecommerce.Produtos.Application.DTOs.Create;
using Ecommerce.Produtos.Application.DTOs.Read;

namespace Ecommerce.Produtos.Application.Interfaces;

public interface IProdutoService
{
    
    Task<IEnumerable<ReadProdutoResponse>> ReadAllProdutosAsync();
    Task<CreateProdutoResponse> CreateProdutoAsync(CreateProdutoRequest request);
    Task<ReadProdutoResponse> UpdateProdutoAsync(int produtoId, CreateProdutoRequest request);
    Task<bool> DeleteProdutoAsync(int produtoId);
}
