using Exercicio_Salario.Tests.Builders;
using Xunit;

namespace Exercicio_Salario.Tests.Models;

public class EmpresaTests
{
    [Fact]
    public void DadoEmpresa_QuandoAdicionarVendedor_DeveAdicionarVendedor()
    {
        // Arrange
        var empresa = EmpresaBuilder.ObterEmpresaPadrao();
        var vendedor = VendedorBuilder.ObterVendedorPadrao();

        // Act
        empresa.AdicionarVendedor(vendedor);

        // Assert
        Assert.Contains(vendedor, empresa.Vendedores);
    }

    [Fact]
    public void DadoEmpresa_QuandoRemoverVendedor_DeveRemoverVendedor()
    {
        // Arrange
        var empresa = EmpresaBuilder.ObterEmpresaPadrao();
        var vendedor = VendedorBuilder.ObterVendedorPadrao();
        empresa.AdicionarVendedor(vendedor);

        // Act
        empresa.RemoverVendedor(vendedor);

        // Assert
        Assert.DoesNotContain(vendedor, empresa.Vendedores);
    }
    
    [Fact]
    public void DadoEmpresa_QuandoListarVendedores_DeveRetornarInfosCorretas()
    {
        // Arrange
        var empresa = EmpresaBuilder.ObterEmpresaPadrao();
        var vendedor1 = VendedorBuilder.ObterVendedorPadrao();
        var vendedor2 = VendedorBuilder.ObterVendedorPadrao();
        
        vendedor2.Cpf = "10987654321";
        vendedor2.Nome = "Vendedor 2";
        
        empresa.AdicionarVendedor(vendedor1);
        empresa.AdicionarVendedor(vendedor2);
        const string resultadoEsperado = "Nome: Vendedor 1\n" +
                                         "CPF: 12345678910\n" +
                                         "CNPJ da Empresa: 01234567000189\n" +
                                         "Salário Fixo: 1000\n" +
                                         "Percentual de Comissão: 15,00%\n" +
                                         "Salário Total: R$ 1.000,00\r\n" +
                                         "Nome: Vendedor 2\n" +
                                         "CPF: 10987654321\n" +
                                         "CNPJ da Empresa: 01234567000189\n" +
                                         "Salário Fixo: 1000\n" +
                                         "Percentual de Comissão: 15,00%\n" +
                                         "Salário Total: R$ 1.000,00\r\n";

        // Act
        var listaVendedores = empresa.ListarVendedores();
        
        // Assert
        Assert.Equal(resultadoEsperado, listaVendedores);
    }
}