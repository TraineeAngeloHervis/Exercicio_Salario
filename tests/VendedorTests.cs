using Xunit;

namespace Exercicio_Salario.tests;

public class VendedorTests
{
    [Fact]
    public void DadoVendedorComVendas_QuandoCalcularSalario_DeveRetornarSalarioCorreto()
    {
        // Arrange
        var vendedor = new Vendedor("123456789", "123456789", "Vendedor 1", 0.15m, 1000, []);
        var venda1 = new Vendas(1, 1000, vendedor.Cpf);
        vendedor.ListaVendas.Add(venda1);

        // Act
        var salario = vendedor.CalcularSalario();
        var resultadoEsperado = vendedor.SalarioFixo + (venda1.ValorVenda * vendedor.PercentualComissao);

        // Assert
        Assert.Equal(resultadoEsperado, salario);
    }
    
    [Fact]
    public void DadoVendedorSemVendas_QuandoCalcularSalario_DeveRetornarSalarioFixo()
    {
        // Arrange
        var vendedor = new Vendedor("123456789", "123456789", "Vendedor 1", 0.15m, 1000, []);

        // Act
        var salario = vendedor.CalcularSalario();
        const int resultadoEsperado = 1000;

        // Assert
        Assert.Equal(resultadoEsperado, salario);
    }
    
    [Fact]
    public void DadoVendedorComInfosCorretas_QuandoListarInfosVendedor_DeveRetornarInfosCorretas()
    {
        // Arrange
        var vendedor = new Vendedor("123456789", "123456789", "Vendedor 1", 0.15m, 1000, []);
        var venda1 = new Vendas(1, 1000, vendedor.Cpf);
        var venda2 = new Vendas(2, 2000, vendedor.Cpf);
        var venda3 = new Vendas(3, 3000, vendedor.Cpf);
        vendedor.ListaVendas.Add(venda1);
        vendedor.ListaVendas.Add(venda2);
        vendedor.ListaVendas.Add(venda3);

        // Act
        var infosVendedor = vendedor.ListarInfosVendedor();
        const string resultadoEsperado = "Nome: Vendedor 1\n" +
                                         "CPF: 123456789\n" +
                                         "CNPJ da Empresa: 123456789\n" +
                                         "Salário Fixo: 1000\n" +
                                         "Percentual de Comissão: 0,15\n" +
                                         "Salário Total: 1900";

        // Assert
        Assert.Equal(resultadoEsperado, infosVendedor);
    }
}