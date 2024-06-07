using Xunit;

namespace Exercicio_Salario.tests;

public class EmpresaTests
{
    [Fact]
    public void DadoVendedor_QuandoAdicionarVendedor_DeveAdicionarVendedor()
    {
        // Arrange
        var empresa = new Empresa("123456789", "Empresa 1");
        var vendedor = new Vendedor("123456789", "123456789", "Vendedor 1", 0.15m, 1000, []);

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
        var vendedor = new Vendedor("123456789", "123456789", "Vendedor 1", 0.15m, 1000, []);
        empresa.AdicionarVendedor(vendedor);

        // Act
        empresa.RemoverVendedor(vendedor);

        // Assert
        Assert.DoesNotContain(vendedor, empresa.Vendedores);
    }
}