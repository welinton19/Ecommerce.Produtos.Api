namespace Ecommerce.Produtos.Domain.Entities;

public class Categoria
{
    public int CategoriaId { get; set; }
    public string? Name { get; set; }
    public string? Slug { get; set; }
    public int CategoriaPaiId { get; set; }
    public Categoria? CategoriaPai { get; set; }
    public bool Ativo { get; set; } = true;


    public Categoria()
    {
        
    }


    public static Categoria Create(int categoriaId, string? name, string? slug, int categoriaPaiId, bool ativo)
    {
        return new Categoria
        {
            CategoriaId = categoriaId,
            Name = name,
            Slug = slug,
            CategoriaPaiId = categoriaPaiId,
            Ativo = ativo
        };
    }
}
