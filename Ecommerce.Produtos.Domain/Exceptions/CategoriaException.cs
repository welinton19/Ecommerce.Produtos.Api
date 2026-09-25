namespace Ecommerce.Produtos.Domain.Exceptions;

public class CategoriaException : IOException
{
    public CategoriaException(string message) : base(message)
    {
    }
}
