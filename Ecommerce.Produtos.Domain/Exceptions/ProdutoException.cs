namespace Ecommerce.Produtos.Domain.Exceptions;

public class ProdutoException : IOException
{
    public ProdutoException(string message) : base(message)
    {
    }
}
