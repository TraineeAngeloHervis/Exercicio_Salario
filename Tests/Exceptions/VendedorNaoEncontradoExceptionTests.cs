using Exercicio_Salario.Exceptions;
using Xunit;

namespace Exercicio_Salario.Tests.Exceptions;

public class VendedorNaoEncontradoExceptionTests
{
    [Fact]
    public void DadoVendedorNaoEncontrado_QuandoInstanciar_DeveRetornarMensagemCorreta()
    {
        // Arrange
        const string mensagemEsperada = "Vendedor não encontrado";

        // Act
        var exception = new VendedorNaoEncontradoException();

        // Assert
        Assert.Equal(mensagemEsperada, exception.Message);
    }
}