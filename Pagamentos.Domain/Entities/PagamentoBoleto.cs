namespace Pagamentos.Domain.Entities;

public class PagamentoBoleto
{
    public int PagamentoId { get; set; }
    public string CodigoBarras { get; set; } = string.Empty;
    public DateTime Vencimento { get; set; }
    public decimal Valor { get; set; }

    public PagamentoBoleto() { }

    public static PagamentoBoleto Criar(int pagamentoId, string codigoBarras, DateTime vencimento, decimal valor)
    {
        return new PagamentoBoleto
        {
            PagamentoId = pagamentoId,
            CodigoBarras = codigoBarras,
            Vencimento = vencimento,
            Valor = valor
        };
    }
}
