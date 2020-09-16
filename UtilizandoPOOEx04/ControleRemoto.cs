using System;

namespace UtilizandoPOOEx04
{
    public class ControleRemoto
    {
        private Televisao _televisao;

        public void Controlar(string tecla)
        {
            switch (tecla)
            {
                case "+":
                    AumentarVolume();
                    break;
                case "-":
                    DiminuirVolume();
                    break;
                case "<":
                    DiminuirCanal();
                    break;
                case ">":
                    AumentarCanal();
                    break;
                case "C":
                    TrocarDeCanal();
                    break;
                case "V":
                    ConsultarVolume();
                    break;
                case "H":
                    ConsultarCanal();
                    break;
                case "I":
                    ConsultarDadosAtuais();
                    break;
                default:
                    break;
            }
        }

        public ControleRemoto(Televisao televisao)
        {
            _televisao = televisao;
        }

        private void AumentarVolume()
        {
            _televisao.Volume++;
        }

        private void DiminuirVolume()
        {
            if (_televisao.Volume.Equals(0))
                return;

            _televisao.Volume--;
        }

        private void AumentarCanal()
        {
            _televisao.Canal++;
        }

        private void DiminuirCanal()
        {
            _televisao.Canal--;
        }

        private void TrocarDeCanal()
        {
            Console.WriteLine("Informe o Canal: ");
            string canalDigitado = Console.ReadLine();
            if (!int.TryParse(canalDigitado, out int canal))
            {
                Console.WriteLine("Canal inexistente.");
                return;
            }

            _televisao.Canal = canal;
        }

        private void ConsultarVolume()
        {
            _televisao.ExibirVolume();
        }

        private void ConsultarCanal()
        {
            _televisao.ExibirCanalAtual();
        }

        private void ConsultarDadosAtuais()
        {
            _televisao.ExibirDadosAtuais();
        }
    }
}
