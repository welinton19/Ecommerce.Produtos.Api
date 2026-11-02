using Pagamentos.Domain.Entities;

namespace Pagamentos.Domain.IRepository;

public interface IPagamentoBoletoRepository
{
    Task<PagamentoBoleto> ObterPorIdAsync(Guid id);
    Task<IEnumerable<PagamentoBoleto>> ObterTodosAsync();
    Task AdicionarAsync(PagamentoBoleto pagamentoBoleto);
    Task AtualizarAsync(PagamentoBoleto pagamentoBoleto);
    Task ExcluirAsync(PagamentoBoleto pagamentoBoleto);
}
