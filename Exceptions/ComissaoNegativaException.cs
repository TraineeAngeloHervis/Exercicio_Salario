namespace Exercicio_Salario.Exceptions;

public class ComissaoNegativaException : Exception
{
    public ComissaoNegativaException()
        : base("Comissão não pode ser negativa")
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