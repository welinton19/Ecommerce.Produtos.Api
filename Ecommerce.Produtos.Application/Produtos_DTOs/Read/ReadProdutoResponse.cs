namespace Ecommerce.Produtos.Application.DTOs.Read;

public class ReadProdutoResponse
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Preco { get; set; }
    public int EstoqueQuantidade { get; set; }
    public int Quantidade { get; set; }
    public string? Descricao { get; set; }
    public string? Imagem { get; set; }
    public int CategoriaId { get; set; }
}
