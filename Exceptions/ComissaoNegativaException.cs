namespace Exercicio_Salario.Exceptions;

public class ComissaoNegativaException : Exception
{
    public ComissaoNegativaException()
    {
    }
    
    public ComissaoNegativaException(string message)
        : base(message)
    {
    }
    
    public ComissaoNegativaException(string message, Exception inner)
        : base(message, inner)
    {
    }
}