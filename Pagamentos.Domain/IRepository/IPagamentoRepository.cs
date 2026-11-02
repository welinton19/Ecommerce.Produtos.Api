using Pagamentos.Domain.Entities;

namespace Pagamentos.Domain.IRepository;

public interface IPagamentoRepository
{
    Task<Pagamento> ObterPorIdAsync(Guid id);
    Task<Pagamento> AdicionarPagamentoAsync(Pagamento pagamento);
    Task<IEnumerable<Pagamento>> ObterTodosAsync();
    Task AtualizarAsync(Pagamento pagamento);
    Task ExcluirAsync(Pagamento pagamento);
}
