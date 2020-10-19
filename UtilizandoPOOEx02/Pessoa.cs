using System;

namespace UtilizandoPOOEx02
{
    public class Pessoa
    {
        private readonly INotificador _notificador;

        private string _nome;
        private DateTime _dataDeNascimento;
        private double _altura;

        public Pessoa()
        {
            _notificador = new Notificador();
        }

        public void InformarNome(string nome)
        {
            _nome = nome;
        }

        public string ObterNome()
        {
            return _nome;
        }

        public void InformarDataDeNascimento(DateTime dataDeNascimento)
        {
            _dataDeNascimento = dataDeNascimento;
        }

        public DateTime ObterDataDeNascimento()
        {
            return _dataDeNascimento;
        }

        public void InformarAltura(double altura)
        {
            _altura = altura;
        }

        public double ObterAltura()
        {
            return _altura;
        }

        public string CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            int anos = new DateTime(DateTime.Now.Subtract(_dataDeNascimento).Ticks).Year - 1;
            var anosTranscorridos = _dataDeNascimento.AddYears(anos);
            int meses = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (anosTranscorridos.AddMonths(i) == dataAtual)
                {
                    meses = i;
                    break;
                }
                else if (anosTranscorridos.AddMonths(i) >= dataAtual)
                {
                    meses = i - 1;
                    break;
                }
            }
            int dias = dataAtual.Subtract(anosTranscorridos.AddMonths(meses)).Days;

            return $"{anos} anos {meses} Meses {dias} dias";
        }

        public void ImprimirDados()
        {
            _notificador.AdicionarTitulo("Dados da Pessoa");            
            _notificador.AdicionarMensagem($"Nome: {_nome}");
            _notificador.AdicionarMensagem($"Altura: {_altura}");
            _notificador.AdicionarMensagem($"Data de Nascimento: {_dataDeNascimento.ToShortDateString()}");
            _notificador.AdicionarMensagem($"Idade: {CalcularIdade()}");
            _notificador.Notificar();
        }
    }
}
