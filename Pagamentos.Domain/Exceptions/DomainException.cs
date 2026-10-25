namespace Pagamentos.Domain.Exceptions;

public class DomainException : IOException
{
    public DomainException(string message) : base(message)
    {
    }
}
