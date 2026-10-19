namespace Pagamentos.Domain.Entities;

public class PagamentoCryptoMoeda
{
    public int PagamentoId { get; set; }
    public string Moeda { get; set; }              // "BTC"
    public string EnderecoCarteira { get; set; }   
    public decimal ValorCripto { get; set; }       
    public decimal CotacaoNoMomento { get; set; }  
    public string? HashTransacao { get; set; }     
    public int Confirmacoes { get; set; }

    public PagamentoCryptoMoeda() { }

    public static PagamentoCryptoMoeda Criar(int pagamentoId, string moeda, string enderecoCarteira, decimal valorCripto, decimal cotacaoNoMomento)
    {
        return new PagamentoCryptoMoeda
        {
            PagamentoId = pagamentoId,
            Moeda = moeda,
            EnderecoCarteira = enderecoCarteira,
            ValorCripto = valorCripto,
            CotacaoNoMomento = cotacaoNoMomento,
            Confirmacoes = 0
        };
    }
}
