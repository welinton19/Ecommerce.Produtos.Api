using Pagamentos.Domain.Entities;

namespace Pagamentos.Domain.IRepository;

public interface IPagamentoCartaoRepository
{
    Task<PagamentoCartao> ObterPorIdAsync(Guid id);
    Task<IEnumerable<PagamentoCartao>> ObterTodosAsync();
    Task AdicionarAsync(PagamentoCartao pagamentoCartao);
    Task AtualizarAsync(PagamentoCartao pagamentoCartao);
    Task ExcluirAsync(PagamentoCartao pagamentoCartao);
}
