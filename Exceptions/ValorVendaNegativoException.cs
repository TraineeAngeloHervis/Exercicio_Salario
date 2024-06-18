namespace Exercicio_Salario.Exceptions;

public class ValorVendaNegativoException : Exception
{
    public ValorVendaNegativoException()
        : base("Valor da venda não pode ser negativo")
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