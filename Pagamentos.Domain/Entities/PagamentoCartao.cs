namespace Pagamentos.Domain.Entities;

public class PagamentoCartao
{
    public int PagamentoId { get; set; }
    public string NumeroCartao { get; set; } = string.Empty;
    public string NomeTitular { get; set; } = string.Empty;
    public DateTime Validade { get; set; }
    public string CodigoSeguranca { get; set; } = string.Empty;
    public PagamentoCartao() { }
    public static PagamentoCartao Criar(int pagamentoId, string numeroCartao, string nomeTitular, DateTime validade, string codigoSeguranca)
    {
        return new PagamentoCartao
        {
            PagamentoId = pagamentoId,
            NumeroCartao = numeroCartao,
            NomeTitular = nomeTitular,
            Validade = validade,
            CodigoSeguranca = codigoSeguranca
        };
    }
}
