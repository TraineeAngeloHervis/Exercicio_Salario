using Exercicio_Salario.Tests.Builders;
using Xunit;

namespace Exercicio_Salario.Tests.Models;

public class VendedorTests
{
    [Fact]
    public void DadoVendedorComVendas_QuandoCalcularSalario_DeveRetornarSalarioCorreto()
    {
        // Arrange
        var vendedor = VendedorBuilder.Novo().ObterVendedorPadrao().Build();
        var venda1 = VendaBuilder.ObterVendaPadrao();

        // Act
        vendedor.Vendas.Add(venda1);
        var salario = vendedor.CalcularSalario();
        const int resultadoEsperado = 1150;

        // Assert
        Assert.Equal(resultadoEsperado, salario);
    }
    
    [Fact]
    public void DadoVendedorSemVendas_QuandoCalcularSalario_DeveRetornarSalarioFixo()
    {
        // Arrange
        var vendedor = VendedorBuilder.Novo().ObterVendedorPadrao().Build();

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
        var vendedor = VendedorBuilder.Novo().ObterVendedorPadrao().Build();
        var venda1 = VendaBuilder.ObterVendaPadrao();
        
        // Act
        vendedor.Vendas.Add(venda1);
        var infosVendedor = vendedor.ListarInfosVendedor();
        const string resultadoEsperado = "Nome: Vendedor 1\n" +
                                         "CPF: 12345678910\n" +
                                         "CNPJ da Empresa: 01234567000189\n" +
                                         "Salário Fixo: 1000\n" +
                                         "Percentual de Comissão: 15,00%\n" +
                                         "Salário Total: R$ 1.150,00";

        // Assert
        Assert.Equal(resultadoEsperado, infosVendedor);
    }
    
    [Fact]
    public void DadoVendedor_QuandoAdicionarVenda_DeveAdicionarVendaAoVendedor()
    {
        // Arrange
        var vendedor = VendedorBuilder.Novo().ObterVendedorPadrao().Build();
        var venda1 = VendaBuilder.ObterVendaPadrao();
        
        // Act
        vendedor.Vendas.Add(venda1);
        
        // Assert
        Assert.Contains(venda1, vendedor.Vendas);
    }
    
    [Fact]
    public void DadoVendedor_QuandoRemoverVenda_DeveRemoverVendaDoVendedor()
    {
        // Arrange
        var vendedor = VendedorBuilder.Novo().ObterVendedorPadrao().Build();
        var venda1 = VendaBuilder.ObterVendaPadrao();
        
        // Act
        vendedor.Vendas.Add(venda1);
        vendedor.Vendas.Remove(venda1);
        
        // Assert
        Assert.DoesNotContain(venda1, vendedor.Vendas);
    }
}