using Xunit;

namespace Exercicio_Salario
{
    public class ExercicioSalarioTests
    {
        private readonly Empresa empresa = new("123456789", "Empresa 1");

        [Fact]
        public void Salario_CalcularSalario_DeveRetornarSalarioTotal()
        {
            // Arrange
            ISalario salario = new Salario(0);
            empresa.AdicionarVendedor(new Vendedor("123456789", "123456789", "Ângelo", 1000, 40, 10));

            // Act
            var resultado = empresa.Vendedores[0].CalcularSalario();
            var resultadoEsperado = "Salário Total: 550,00";

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Salario_AtualizarSalario_DeveRetornarSalarioTotalAtualizado()
        {
            // Arrange
            ISalario salario = new Salario(0);
            empresa.AdicionarVendedor(new Vendedor("123456789", "123456789", "Ângelo", 1000, 40, 10));

            // Act
            var resultado = salario.AtualizarSalario(2000);
            var resultadoEsperado = "Salário Total Atualizado: 2000";

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Vendedor_AdicionarVendedor_DeveAdicionarVendedor()
        {
            // Arrange
            empresa.AdicionarVendedor(new Vendedor("123456789", "123456789", "Ângelo", 1000, 40, 10));

            // Act
            var resultado = empresa.Vendedores.Count;
            var resultadoEsperado = 1;

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Vendedor_RemoverVendedor_DeveRemoverVendedor()
        {
            // Arrange
            empresa.AdicionarVendedor(new Vendedor("123456789", "123456789", "Ângelo", 1000, 40, 10));

            // Act
            empresa.RemoverVendedor(empresa.Vendedores[0]);

            // Assert   
            Assert.Empty(empresa.Vendedores);
        }
    }
}