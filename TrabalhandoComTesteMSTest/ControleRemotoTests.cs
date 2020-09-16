using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilizandoPOOEx04;

namespace TrabalhandoComTesteMSTest
{
    [TestClass]
    public class ControleRemotoTests
    {
        [TestMethod]
        public void DeveAumentarOVolume()
        {
            var televisao = new Televisao();
            var controleRemoto = new ControleRemoto(televisao);
            var comando = "+";

            controleRemoto.Controlar(comando);

            Assert.AreEqual(2, televisao.Volume);
        }

        [TestMethod]
        public void DeveDiminuirOVolume()
        {
            var televisao = new Televisao();
            var controleRemoto = new ControleRemoto(televisao);
            var comando = "-";

            controleRemoto.Controlar(comando);

            Assert.AreEqual(0, televisao.Volume);
        }

        [TestMethod]
        public void DeveAumentarOCanal()
        {
            var televisao = new Televisao();
            var controleRemoto = new ControleRemoto(televisao);
            var comando = ">";

            controleRemoto.Controlar(comando);

            Assert.AreEqual(2, televisao.Canal);
        }

        [TestMethod]
        public void DeveDiminuirOCanal()
        {
            var televisao = new Televisao();
            var controleRemoto = new ControleRemoto(televisao);
            var comando = "<";

            controleRemoto.Controlar(comando);

            Assert.AreEqual(0, televisao.Canal);
        }
    }
}
