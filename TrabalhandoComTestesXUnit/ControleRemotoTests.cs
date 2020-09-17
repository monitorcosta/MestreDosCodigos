using UtilizandoPOOEx04;
using Xunit;

namespace TrabalhandoComTestesXUnit
{
    public class ControleRemotoTests
    {
        [Fact]
        public void DeveAumentarOVolume()
        {
            var televisao = new Televisao();
            var controleRemoto = new ControleRemoto(televisao);
            var comando = "+";

            controleRemoto.Controlar(comando);

            Assert.Equal(2, televisao.Volume);
        }

        [Fact]
        public void DeveDiminuirOVolume()
        {
            var televisao = new Televisao();
            var controleRemoto = new ControleRemoto(televisao);
            var comando = "-";

            controleRemoto.Controlar(comando);

            Assert.Equal(0, televisao.Volume);
        }

        [Fact]
        public void DeveAumentarOCanal()
        {
            var televisao = new Televisao();
            var controleRemoto = new ControleRemoto(televisao);
            var comando = ">";

            controleRemoto.Controlar(comando);

            Assert.Equal(2, televisao.Canal);
        }

        [Fact]
        public void DeveDiminuirOCanal()
        {
            var televisao = new Televisao();
            var controleRemoto = new ControleRemoto(televisao);
            var comando = "<";

            controleRemoto.Controlar(comando);

            Assert.Equal(0, televisao.Canal);
        }
    }
}
