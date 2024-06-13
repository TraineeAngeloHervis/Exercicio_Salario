using Xunit;
using Exercicio_Salario.Models;

namespace Exercicio_Salario.Builders
{
    public class VendedorBuilderTests
    {
        [Fact]
        public void DadoVendedor_QuandoVendedorComNome_DeveRetornarVendedorComNome()
        {
            // Arrange
            const string nome = "Vendedor";
            var vendedorBuilder = new VendedorBuilder();

            // Act
            var vendedor = vendedorBuilder.ComNome(nome).Build();

            // Assert
            Assert.Equal(nome, vendedor.Nome);
        }

        [Fact]
        public void DadoVendedor_QuandoVendedorComCpf_DeveRetornarVendedorComCpf()
        {
            // Arrange
            const string cpf = "12345678901";
            var vendedorBuilder = new VendedorBuilder();

            // Act
            var vendedor = vendedorBuilder.ComCpf(cpf).Build();

            // Assert
            Assert.Equal(cpf, vendedor.Cpf);
        }

        [Fact]
        public void DadoVendedor_QuandoVendedorComCnpjEmpresa_DeveRetornarVendedorComCnpjEmpresa()
        {
            // Arrange
            const string cnpjEmpresa = "01234567000189";
            var vendedorBuilder = new VendedorBuilder();

            // Act
            var vendedor = vendedorBuilder.ComCnpjEmpresa(cnpjEmpresa).Build();

            // Assert
            Assert.Equal(cnpjEmpresa, vendedor.CnpjEmpresa);
        }

        [Fact]
        public void DadoVendedor_QuandoVendedorComPercentualComissao_DeveRetornarVendedorComPercentualComissao()
        {
            // Arrange
            const decimal percentualComissao = 0.15m;
            var vendedorBuilder = new VendedorBuilder();

            // Act
            var vendedor = vendedorBuilder.ComPercentualComissao(percentualComissao).Build();

            // Assert
            Assert.Equal(percentualComissao, vendedor.PercentualComissao);
        }

        [Fact]
        public void DadoVendedor_QuandoVendedorComSalarioFixo_DeveRetornarVendedorComSalarioFixo()
        {
            // Arrange
            const decimal salarioFixo = 1000;
            var vendedorBuilder = new VendedorBuilder();

            // Act
            var vendedor = vendedorBuilder.ComSalarioFixo(salarioFixo).Build();

            // Assert
            Assert.Equal(salarioFixo, vendedor.SalarioFixo);
        }
        
        [Fact]
        public void DadoVendedor_QuandoVendedorComListaVendas_DeveRetornarVendedorComListaVendas()
        {
            // Arrange
            var vendas = new List<Venda> { VendaBuilder.ObterVendaPadrao() };
            var vendedorBuilder = new VendedorBuilder();

            // Act
            var vendedor = vendedorBuilder.ComListaVendas(vendas).Build();

            // Assert
            Assert.Equal(vendas, vendedor.Vendas);
        }

        [Fact]
        public void DadoVendedor_QuandoObterVendedorPadrao_DeveRetornarVendedorPadrao()
        {
            // Arrange & Act
            var vendedor = VendedorBuilder.ObterVendedorPadrao();

            // Assert
            Assert.Equal("Vendedor 1", vendedor.Nome);
            Assert.Equal("12345678910", vendedor.Cpf);
        }
    }
}