using Ecommerce.Produtos.Domain.Entities;

namespace Ecommerce.Produtos.Application.Categorias_DTOs.Create;

public class CreateCategoriaResponse
{
    public int CategoriaId { get; set; }
    public string? Name { get; set; }
    public string? Slug { get; set; }
    public int CategoriaPaiId { get; set; }
    public Categoria? CategoriaPai { get; set; }
    public bool Ativo { get; set; } = true;
}
