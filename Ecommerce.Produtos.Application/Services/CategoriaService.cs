using Ecommerce.Produtos.Application.Categorias_DTOs.Create;
using Ecommerce.Produtos.Application.Categorias_DTOs.Reade;
using Ecommerce.Produtos.Application.Interfaces;
using Ecommerce.Produtos.Domain.Entities;
using Ecommerce.Produtos.Domain.IRepository;

namespace Ecommerce.Produtos.Application.Services;

public class CategoriaService : ICategoriaService
{
    private readonly ICategoriasRepository _categoriaRepository;

    public CategoriaService(ICategoriasRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    public async Task<ReadCategoriaResponse> CreateCategoriaAsync(CreateCategoriaRequest request)
    {
        var categoria = new Categoria
        {
            Name = request.Name,
            Slug = request.Slug,
            CategoriaPaiId = request.CategoriaPaiId,
            Ativo = request.Ativo
        };

        var createdCategoria = await _categoriaRepository.CreateCategoriaAsync(categoria);
        return new ReadCategoriaResponse
        {
            CategoriaId = createdCategoria.CategoriaId,
            Name = createdCategoria.Name,
            Slug = createdCategoria.Slug,
            CategoriaPaiId = createdCategoria.CategoriaPaiId,
            Ativo = createdCategoria.Ativo
        };
    }

    public async Task<bool> DeleteCategoriaAsync(int categoriaId)
    {
        return await _categoriaRepository.DeleteCategoriaAsync(categoriaId);
    }

    public async Task<IEnumerable<ReadCategoriaResponse>> ReadAllCategoriasAsync()
    {
        var categorias = await _categoriaRepository.GetAllCategoriasAsync();
        return categorias.Select(c => new ReadCategoriaResponse
        {
            CategoriaId = c.CategoriaId,
            Name = c.Name,
            Slug = c.Slug,
            CategoriaPaiId = c.CategoriaPaiId,
            Ativo = c.Ativo
        });


    }

    public async Task<ReadCategoriaResponse> ReadCategoriaAsync(ReadCategoriaRequest request)
    {
        var categoria = await _categoriaRepository.GetCategoriaByIdAsync(request.CategoriaId);
        return new ReadCategoriaResponse
        {
            CategoriaId = categoria.CategoriaId,
            Name = categoria.Name,
            Slug = categoria.Slug,
            CategoriaPaiId = categoria.CategoriaPaiId,
            Ativo = categoria.Ativo
        };
    }

    public async Task<ReadCategoriaResponse> UpdateCategoriaAsync(int categoriaId, CreateCategoriaRequest request)
    {
        var categoria = await _categoriaRepository.GetCategoriaByIdAsync(categoriaId);
        if (categoria == null)
        {
            throw new InvalidOperationException("Categoria not found");
        }

        categoria.Name = request.Name;
        categoria.Slug = request.Slug;
        categoria.CategoriaPaiId = request.CategoriaPaiId;
        categoria.Ativo = request.Ativo;

        var updatedCategoria = await _categoriaRepository.UpdateCategoriaAsync(categoria);
        return new ReadCategoriaResponse
        {
            CategoriaId = updatedCategoria.CategoriaId,
            Name = updatedCategoria.Name,
            Slug = updatedCategoria.Slug,
            CategoriaPaiId = updatedCategoria.CategoriaPaiId,
            Ativo = updatedCategoria.Ativo
        };
    }
}
