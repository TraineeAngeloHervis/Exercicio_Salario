using Xunit;

namespace Exercicio_Salario.Builders
{
    public class VendaBuilderTests
    {
        [Fact]
        public void DadoVenda_QuandoVendaComValor_DeveRetornarVendaComValor()
        {
            // Arrange
            const decimal valor = 1000;
            var vendaBuilder = new VendaBuilder();

            // Act
            var venda = vendaBuilder.ComValorVenda(valor).Build();

            // Assert
            Assert.Equal(valor, venda.ValorVenda);
        }

        [Fact]
        public void DadoVenda_QuandoVendaComCpfVendedor_DeveRetornarVendaComCpfVendedor()
        {
            // Arrange
            const string cpf = "12345678901";
            var vendaBuilder = new VendaBuilder();

            // Act
            var venda = vendaBuilder.ComCpfVendedor(cpf).Build();

            // Assert
            Assert.Equal(cpf, venda.CpfVendedor);
        }

        [Fact]
        public void DadoVenda_QuandoObterVendaPadrao_DeveRetornarVendaPadrao()
        {
            // Arrange & Act
            var venda = VendaBuilder.ObterVendaPadrao();

            // Assert
            Assert.Equal(1000, venda.ValorVenda);
            Assert.Equal("", venda.CpfVendedor);
        }
    }
}