namespace Ecommerce.Produtos.Domain.Entities;

public class Produto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Preco { get; set; }
    public int EstoqueQuantidade { get; set; }
    public int Quantidade { get; set; }
    public string? Descricao { get; set; }
    public string? Imagem { get; set; }
    public int CategoriaId { get; set; }
    public Categoria? Categoria { get; set; }

    public Produto()
    {

    }

    public static Produto Create(int id, string? name, decimal preco, int estoqueQuantidade, int quantidade, string? descricao, string? imagem, Categoria? categoria)
    {
        return new Produto
        {
            Id = id,
            Name = name,
            Preco = preco,
            EstoqueQuantidade = estoqueQuantidade,
            Quantidade = quantidade,
            Descricao = descricao,
            Imagem = imagem,
            Categoria = categoria
        };
    }
}
