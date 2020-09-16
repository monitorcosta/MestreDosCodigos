using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabalhandoNoConsoleEx05;

namespace TrabalhandoComTesteMSTest
{
    [TestClass]
    public class CalculadorDeBhaskaraTests
    {
        [DataTestMethod]
        [DataRow(1, 8, -9, 1, -9)]
        [DataRow(2, -16, -18, 9, -1)]
        [DataRow(1, 12, -13, 1, -13)]
        public void DeveCalcularAsRaizes(int coeficienteA, int coeficienteB, int coeficienteC, int raiz1, int raiz2)
        {
            var calculador = new CalculadorDeBhaskara(coeficienteA, coeficienteB, coeficienteC);

            Assert.AreEqual(raiz1, calculador.CarlcularValorRaiz1());
            Assert.AreEqual(raiz2, calculador.CarlcularValorRaiz2());
        }

        [TestMethod]
        public void DeveValidarDeltaNegativo()
        {
            int coeficienteA = 7;
            int coeficienteB = 3;
            int coeficienteC = 4;

            var calculador = new CalculadorDeBhaskara(coeficienteA, coeficienteB, coeficienteC);

            Assert.IsTrue(calculador.DeltaNegativo());
        }
    }
}
