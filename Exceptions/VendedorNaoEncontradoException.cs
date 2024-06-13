namespace Exercicio_Salario.Exceptions;

public class VendedorNaoEncontradoException : Exception
{
    public VendedorNaoEncontradoException()
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