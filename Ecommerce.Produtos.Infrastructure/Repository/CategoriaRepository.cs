using Ecommerce.Produtos.Domain.Entities;
using Ecommerce.Produtos.Domain.IRepository;
using Ecommerce.Produtos.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Produtos.Infrastructure.Repository;

public class CategoriaRepository : ICategoriasRepository
{
    private readonly ProdutoDbContext _context;

    public CategoriaRepository(ProdutoDbContext context)
    {
        _context = context;
    }

    public async Task<Categoria> CreateCategoriaAsync(Categoria categoria)
    {
        await _context.Categorias.AddAsync(categoria);
        await _context.SaveChangesAsync();
        return categoria;
    }

    public async Task<bool> DeleteCategoriaAsync (int id)
    {
        await _context.Categorias.FindAsync(id);
        var categoria = await _context.Categorias.FindAsync(id);
        if (categoria == null)
        {
            return false;
        }

        _context.Categorias.Remove(categoria);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<Categoria>> GetAllCategoriasAsync()
    {
        return await _context.Categorias.ToListAsync();
    }

    public async Task<IEnumerable<Categoria>> GetByCategoriaPaiIdAsync(int categoriaPaiId)
    {
        return await _context.Categorias.Where(c => c.CategoriaPaiId == categoriaPaiId).ToListAsync();
    }

    public async Task<Categoria> GetCategoriaByIdAsync(int id)
    {
        return await _context.Categorias.FindAsync(id);
    }
    

    public async Task<Categoria> UpdateCategoriaAsync(Categoria categoria)
    {
        _context.Categorias.Update(categoria);
        await _context.SaveChangesAsync();
        return categoria;
    }
}
