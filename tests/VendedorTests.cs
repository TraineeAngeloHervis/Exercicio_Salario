using Xunit;

namespace Exercicio_Salario.tests;

public class VendedorTests
{
    [Fact]
    public void DadoVendedorComVendas_QuandoCalcularSalario_DeveRetornarSalarioCorreto()
    {
        // Arrange
        var vendedor = new Vendedor("123456789", "123456789", "Vendedor 1", 0.15m, 1000, [], "");
        var venda1 = new Vendas
        {
            ValorVenda = 1000,
            CpfVendedor = vendedor.Cpf
        };
        vendedor.ListaVendas.Add(venda1);

        // Act
        var salario = vendedor.CalcularSalario();
        const int resultadoEsperado = 1150;

        // Assert
        Assert.Equal(resultadoEsperado, salario);
    }
    
    [Fact]
    public void DadoVendedorSemVendas_QuandoCalcularSalario_DeveRetornarSalarioFixo()
    {
        // Arrange
        var vendedor = new Vendedor("123456789", "123456789", "Vendedor 1", 0.15m, 1000, [],"");

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
        var vendedor = new Vendedor("123456789", "123456789", "Vendedor 1", 0.15m, 1000, [], "");
        var venda1 = new Vendas
        {
            ValorVenda = 1000,
            CpfVendedor = vendedor.Cpf
        };
        vendedor.ListaVendas.Add(venda1);
        
        // Act
        var infosVendedor = vendedor.ListarInfosVendedor();
        const string resultadoEsperado = "Nome: Vendedor 1\n" +
                                         "CPF: 123456789\n" +
                                         "CNPJ da Empresa: 123456789\n" +
                                         "Salário Fixo: 1000\n" +
                                         "Percentual de Comissão: 0,15\n" +
                                         "Salário Total: R$ 1.150,00";

        // Assert
        Assert.Equal(resultadoEsperado, infosVendedor);
    }
    
    [Fact]
    public void DadoEmpresa_QuandoAdicionarVendedor_DeveAdicionarVendedorNaEmpresa()
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
    public void DadoEmpresa_QuandoRemoverVendedor_DeveRemoverVendedorDaEmpresa()
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
    public void DadoEmpresa_QuandoListarVendedores_DeveRetornarInfosCorretas()
    {
        // Arrange
        var empresa = new Empresa("123456789", "Empresa 1");
        var vendedor1 = new Vendedor("123456789", "123456789", "Vendedor 1", 0.15m, 1000, [], "");
        var vendedor2 = new Vendedor("987654321", "123456789", "Vendedor 2", 0.15m, 1000, [], "");
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
    
    [Fact]
    public void DadoVendedor_QuandoAdicionarVenda_DeveAdicionarVendaAoVendedor()
    {
        // Arrange
        var vendedor = new Vendedor("123456789", "123456789", "Vendedor 1", 0.15m, 1000, [], "");
        var venda = new Vendas
        {
            ValorVenda = 1000,
            CpfVendedor = vendedor.Cpf
        };
        
        // Act
        vendedor.ListaVendas.Add(venda);
        
        // Assert
        Assert.Contains(venda, vendedor.ListaVendas);
    }
    
    [Fact]
    public void DadoVendedor_QuandoRemoverVenda_DeveRemoverVendaDoVendedor()
    {
        // Arrange
        var vendedor = new Vendedor("123456789", "123456789", "Vendedor 1", 0.15m, 1000, [], "");
        var venda = new Vendas
        {
            ValorVenda = 1000,
            CpfVendedor = vendedor.Cpf
        };
        vendedor.ListaVendas.Add(venda);
        
        // Act
        vendedor.ListaVendas.Remove(venda);
        
        // Assert
        Assert.DoesNotContain(venda, vendedor.ListaVendas);
    }
}