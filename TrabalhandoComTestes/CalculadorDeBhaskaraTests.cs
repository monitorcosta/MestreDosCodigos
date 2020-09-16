using TrabalhandoNoConsoleEx05;
using Xunit;

namespace TrabalhandoComTestes
{
    public class CalculadorDeBhaskaraTests
    {
        [Theory]
        [InlineData(1, 8, -9, 1, -9)]
        [InlineData(2, -16, -18, 9, -1)]
        [InlineData(1, 12, -13, 1, -13)]
        public void DeveCalcularAsRaizes(int coeficienteA, int coeficienteB, int coeficienteC, int raiz1, int raiz2)
        {
            var calculador = new CalculadorDeBhaskara(coeficienteA, coeficienteB, coeficienteC);

            Assert.Equal(raiz1, calculador.CarlcularValorRaiz1());
            Assert.Equal(raiz2, calculador.CarlcularValorRaiz2());
        }

        [Fact]
        public void DeveValidarDeltaNegativo()
        {
            int coeficienteA = 7;
            int coeficienteB = 3;
            int coeficienteC = 4;

            var calculador = new CalculadorDeBhaskara(coeficienteA, coeficienteB, coeficienteC);

            Assert.True(calculador.DeltaNegativo());
        }
    }
}
