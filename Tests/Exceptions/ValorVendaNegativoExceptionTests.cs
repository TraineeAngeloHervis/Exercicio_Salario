using Exercicio_Salario.Exceptions;
using Xunit;

namespace Exercicio_Salario.Tests.Exceptions;

public class ValorVendaNegativoExceptionTests
{
    [Fact]
    public void DadoValorVendaNegativo_QuandoInstanciar_DeveRetornarMensagemCorreta()
    {
        // Arrange
        const string mensagemEsperada = "Valor da venda não pode ser negativo";

        // Act
        var exception = new ValorVendaNegativoException();

        // Assert
        Assert.Equal(mensagemEsperada, exception.Message);
    }
}