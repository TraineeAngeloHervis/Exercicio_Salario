namespace Exercicio_Salario.Exceptions;

public class VendedorNaoEncontradoException : Exception
{
    public VendedorNaoEncontradoException()
        : base("Vendedor não encontrado")
    {
    }
    
    public VendedorNaoEncontradoException(string message)
        : base(message)
    {
    }
    
    public VendedorNaoEncontradoException(string message, Exception inner)
        : base(message, inner)
    {
    }
}