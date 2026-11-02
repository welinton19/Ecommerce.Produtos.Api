using Pagamentos.Domain.Entities;

namespace Pagamentos.Domain.IRepository;

public interface IPagamentoCryptoMoedaRepository
{
    Task<PagamentoCryptoMoeda> ObterPorIdAsync(Guid id);
    Task<IEnumerable<PagamentoCryptoMoeda>> ObterTodosAsync();
    Task AdicionarAsync(PagamentoCryptoMoeda pagamentoCryptoMoeda);
    Task AtualizarAsync(PagamentoCryptoMoeda pagamentoCryptoMoeda);
    Task ExcluirAsync(PagamentoCryptoMoeda pagamentoCryptoMoeda);
}
