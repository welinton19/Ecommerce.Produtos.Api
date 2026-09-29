namespace Ecommerce.Produtos.Application.Categorias_DTOs.Update;

public class UpdateCategoriaResponse
{
    public int CategoriaId { get; set; }
    public string? Name { get; set; }
    public string? Slug { get; set; }
    public int CategoriaPaiId { get; set; }
    public bool Ativo { get; set; } = true;
}
