using Ecommerce.Produtos.Domain.Entities;
using Ecommerce.Produtos.Domain.IRepository;
using Ecommerce.Produtos.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Produtos.Infrastructure.Repository;

public class ProdutoRepository : IProdutosRepository
{
    private readonly ProdutoDbContext _context;

    public ProdutoRepository(ProdutoDbContext context)
    {
        _context = context;
    }

    public async Task<Produto> CreateAsync(Produto produto)
    {
        await _context.Produtos.AddAsync(produto);
        await _context.SaveChangesAsync();
        return produto;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        await _context.Produtos.FindAsync(id);
        var produto = await _context.Produtos.FindAsync(id);
        if (produto == null)
            return false;

        _context.Produtos.Remove(produto);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<Produto>> GetAllAsync()
    {
        return await _context.Produtos.ToListAsync();
    }

    public async Task<IEnumerable<Produto>> GetByCategoriaIdAsync(int categoriaId)
    {
        return await _context.Produtos.Where(p => p.CategoriaId == categoriaId).ToListAsync();
    }

    public async Task<Produto> GetByIdAsync(int id)
    {
        return await _context.Produtos.FindAsync(id);
    }

    public async Task<Produto> UpdateAsync(Produto produto)
    {
        _context.Produtos.Update(produto);
        await _context.SaveChangesAsync();
        return produto;
    }
    
}
