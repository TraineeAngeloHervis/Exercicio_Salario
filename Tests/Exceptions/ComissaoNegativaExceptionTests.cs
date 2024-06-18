using Exercicio_Salario.Exceptions;
using Xunit;

namespace Exercicio_Salario.Tests.Exceptions;

public class ComissaoNegativaExceptionTests
{
    [Fact]
    public void DadoComissaoNegativa_QuandoInstanciar_DeveRetornarMensagemCorreta()
    {
        // Arrange
        const string mensagemEsperada = "Comissão não pode ser negativa";

        // Act
        var exception = new ComissaoNegativaException();

        // Assert
        Assert.Equal(mensagemEsperada, exception.Message);
    }
}