using Xunit;

namespace Exercicio_Salario.tests.empresa;

public class EmpresaTests
{
    [Fact]
    public void DadoVendedor_QuandoAdicionarVendedor_DeveAdicionarVendedor()
    {
        // Arrange
        var empresa = new Empresa("123456789", "Empresa 1");
        var vendedor = new Vendedor("123456789", "123456789", "Vendedor 1", 0.15m, 1000, [], "");

        // Act
        empresa.AdicionarVendedor(vendedor);

        // Assert
        Assert.Contains(vendedor, empresa.Vendedores);
    }

    [Fact]
    public void DadoVendedor_QuandoRemoverVendedor_DeveRemoverVendedor()
    {
        // Arrange
        var empresa = new Empresa("123456789", "Empresa 1");
        var vendedor = new Vendedor("123456789", "123456789", "Vendedor 1", 0.15m, 1000, [], "");
        empresa.AdicionarVendedor(vendedor);

        // Act
        empresa.RemoverVendedor(vendedor);

        // Assert
        Assert.DoesNotContain(vendedor, empresa.Vendedores);
    }
    
    [Fact]
    public void DadoVendedor_QuandoListarVendedores_DeveRetornarInfosCorretas()
    {
        // Arrange
        var empresa = new Empresa("123456789", "Empresa 1");
        var vendedor1 = new Vendedor("123456789", "123456789", "Vendedor 1", 0.15m, 1000, new List<Vendas>(), "");
        var vendedor2 = new Vendedor("987654321", "123456789", "Vendedor 2", 0.15m, 1000, new List<Vendas>(), "");
        empresa.AdicionarVendedor(vendedor1);
        empresa.AdicionarVendedor(vendedor2);

        // Act
        var listaVendedores = empresa.ListarVendedores();
        const string resultadoEsperado = "Nome: Vendedor 1\n" +
                                         "CPF: 123456789\n" +
                                         "CNPJ da Empresa: 123456789\n" +
                                         "Salário Fixo: 1000\n" +
                                         "Percentual de Comissão: 0,15\n" +
                                         "Salário Total: R$ 1.000,00\n" +
                                         "Nome: Vendedor 2\n" +
                                         "CPF: 987654321\n" +
                                         "CNPJ da Empresa: 123456789\n" +
                                         "Salário Fixo: 1000\n" +
                                         "Percentual de Comissão: 0,15\n" +
                                         "Salário Total: R$ 1.000,00\n";

        // Assert
        Assert.Equal(resultadoEsperado, listaVendedores);
    }
}