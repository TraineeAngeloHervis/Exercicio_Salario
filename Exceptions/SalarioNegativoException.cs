namespace Exercicio_Salario.Exceptions;

public class SalarioNegativoException : Exception
{
    public SalarioNegativoException()
        : base("Salário não pode ser negativo")
    {
    }
    
    public SalarioNegativoException(string message)
        : base(message)
    {
    }
    
    public SalarioNegativoException(string message, Exception inner)
        : base(message, inner)
    {
    }
}