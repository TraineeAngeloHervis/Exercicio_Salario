using Exercicio_Salario.Tests.Builders;
using Xunit;

namespace Exercicio_Salario.Tests.Models;

public class EmpresaTests
{
    [Fact]
    public void DadoEmpresa_QuandoAdicionarVendedor_DeveAdicionarVendedor()
    {
        // Arrange
        var empresa = EmpresaBuilder.Novo().Build();
        var vendedor = VendedorBuilder.Novo().Build();
        
        // Act
        empresa.AdicionarVendedor(vendedor);
        
        // Assert
        Assert.Contains(vendedor, empresa.Vendedores);
    }

    [Fact]
    public void DadoEmpresa_QuandoRemoverVendedor_DeveRemoverVendedor()
    {
        // Arrange
        var empresa = EmpresaBuilder.Novo().Build();
        var vendedor = VendedorBuilder.Novo().Build();
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
        var empresa = EmpresaBuilder.Novo().Build();
        var vendedor1 = VendedorBuilder.Novo().ComNome("Vendedor 1")
            .ComCpf("12345678910")
            .ComCnpjEmpresa("01234567000189")
            .ComSalarioFixo(1000)
            .ComPercentualComissao(0.15m)
            .Build();
        
        
        var vendedor2 = VendedorBuilder.Novo().ComNome("Vendedor 2")
            .ComCpf("10987654321")
            .ComCnpjEmpresa("01234567000189")
            .ComSalarioFixo(1000)
            .ComPercentualComissao(0.15m)
            .Build();

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