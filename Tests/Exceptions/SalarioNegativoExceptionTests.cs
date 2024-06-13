using Exercicio_Salario.Exceptions;
using Xunit;

namespace Exercicio_Salario.Tests.Exceptions;

public class SalarioNegativoExceptionTests
{
    [Fact]
    public void DadoSalarioNegativo_QuandoInstanciar_DeveRetornarMensagemCorreta()
    {
        // Arrange
        const string mensagemEsperada = "Salário fixo não pode ser negativo";

        // Act
        var exception = new SalarioNegativoException();

        // Assert
        Assert.Equal(mensagemEsperada, exception.Message);
    }
}