namespace Exercicio_Salario.Exceptions;

public class VendedorCadastradoException : Exception
{
    public VendedorCadastradoException()
        : base("Vendedor já cadastrado")
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