namespace Exercicio_Salario.Exceptions;

public class ValorVendaNegativoException : Exception
{
    public ValorVendaNegativoException()
    {
    }
    
    public ValorVendaNegativoException(string message)
        : base(message)
    {
    }
    
    public ValorVendaNegativoException(string message, Exception inner)
        : base(message, inner)
    {
    }
}