using Xunit;

namespace Exercicio_Salario.Builders
{
    public class EmpresaBuilderTests
    {

        [Fact]
        public void DadoEmpresa_QuandoEmpresaComNome_DeveRetornarEmpresaComNome()
        {
            // Arrange
            const string nome = "Empresa";
            var empresaBuilder = new EmpresaBuilder();

            // Act
            var empresa = empresaBuilder.ComNome(nome).Build();

            // Assert
            Assert.Equal(nome, empresa.Nome);
        }

        [Fact]
        public void DadoEmpresa_QuandoEmpresaComCnpj_DeveRetornarEmpresaComCnpj()
        {
            // Arrange
            const string cnpj = "12345678901234";
            var empresaBuilder = new EmpresaBuilder();

            // Act
            var empresa = empresaBuilder.ComCnpj(cnpj).Build();

            // Assert
            Assert.Equal(cnpj, empresa.Cnpj);
        }

        [Fact]
        public void DadoEmpresa_QuandoObterEmpresaPadrao_DeveRetornarEmpresaPadrao()
        {
            // Arrange & Act
            var empresa = EmpresaBuilder.ObterEmpresaPadrao();

            // Assert
            Assert.Equal("Empresa 1", empresa.Nome);
            Assert.Equal("01234567000189", empresa.Cnpj);
        }
    }
}