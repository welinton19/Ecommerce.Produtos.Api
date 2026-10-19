using Pagamentos.Domain.Enum;

namespace Pagamentos.Domain.Entities;

public class Pagamento
{
    public int Id { get; set; }
    public int PedidoId { get; set; }
    public decimal Valor { get; set; }
    public FormasPagamentos FormaPagamento { get; set; }
    public StatusPagamento Status { get; set; }
    public DateTime CriadoEm { get; set; }
    public DateTime? ExpiraEm { get; set; }
    public DateTime? PagoEm { get; set; }

    public PagamentoCryptoMoeda? Criptomoeda { get; set; }
    public PagamentoPix? Pix { get; set; }
    public PagamentoBoleto? Boleto { get; set; }
    public PagamentoCartao? Cartao { get; set; }
}
