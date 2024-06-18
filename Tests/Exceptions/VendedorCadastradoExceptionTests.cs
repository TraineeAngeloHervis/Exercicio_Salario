using Exercicio_Salario.Exceptions;
using Xunit;

namespace Exercicio_Salario.Tests.Exceptions;

public class VendedorCadastradoExceptionTests
{
    [Fact]
    public void DadoVendedorCadastrado_QuandoInstanciar_DeveRetornarMensagemCorreta()
    {
        // Arrange
        const string mensagemEsperada = "Vendedor já cadastrado";

        // Act
        var exception = new VendedorCadastradoException();

        // Assert
        Assert.Equal(mensagemEsperada, exception.Message);
    }
}