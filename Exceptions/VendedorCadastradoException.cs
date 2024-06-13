namespace Exercicio_Salario.Exceptions;

public class VendedorCadastradoException : Exception
{
    public VendedorCadastradoException()
    {
    }
    
    public VendedorCadastradoException(string message)
        : base(message)
    {
    }
    
    public VendedorCadastradoException(string message, Exception inner)
        : base(message, inner)
    {
    }
}