using Pagamentos.Domain.Entities;

namespace Pagamentos.Domain.IRepository;

public interface IPagamentoPixRepository
{
    Task<PagamentoPix> ObterPorIdAsync(Guid id);
    Task<IEnumerable<PagamentoPix>> ObterTodosAsync();
    Task AdicionarAsync(PagamentoPix pagamentoPix);
    Task AtualizarAsync(PagamentoPix pagamentoPix);
    Task ExcluirAsync(PagamentoPix pagamentoPix);
}
