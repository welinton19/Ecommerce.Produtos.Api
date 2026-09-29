using Ecommerce.Produtos.Domain.Entities;

namespace Ecommerce.Produtos.Application.DTOs.Create;

public class CreateProdutoRequest
{
    public string? Name { get; set; }
    public decimal Preco { get; set; }
    public int EstoqueQuantidade { get; set; }
    public int Quantidade { get; set; }
    public string? Descricao { get; set; }
    public string? Imagem { get; set; }
    public int CategoriaId { get; set; }
    public Categoria? Categoria { get; set; }
}
