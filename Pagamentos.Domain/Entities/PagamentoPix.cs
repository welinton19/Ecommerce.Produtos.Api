namespace Pagamentos.Domain.Entities;

public class PagamentoPix
{
    public int PagamentoId { get; set; }
    public string ChavePix { get; set; }          // "chave-pix"
    public string QrCode { get; set; }            // "qr-code"
    public DateTime ExpiraEm { get; set; }        // "2023-12-31T23:59:59Z"
    public DateTime? PagoEm { get; set; }          // "2023-12-31T23:59:59Z"

    public PagamentoPix() { }

    public static PagamentoPix Criar(int pagamentoId, string chavePix, string qrCode, DateTime expiraEm)
    {
        return new PagamentoPix
        {
            PagamentoId = pagamentoId,
            ChavePix = chavePix,
            QrCode = qrCode,
            ExpiraEm = expiraEm,
            PagoEm = null
        };
    }
}
