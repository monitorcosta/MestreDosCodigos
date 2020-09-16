using System;

namespace UtilizandoPOOEx02
{
    public class Pessoa
    {
        private string _nome;
        private DateTime _dataDeNascimento;
        private double _altura;

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetDataDeNascimento(DateTime dataDeNascimento)
        {
            _dataDeNascimento = dataDeNascimento;
        }

        public DateTime GetDataDeNascimento()
        {
            return _dataDeNascimento;
        }

        public void SetAltura(double altura)
        {
            _altura = altura;
        }

        public double GetAltura()
        {
            return _altura;
        }

        public string CalcularIdade()
        {
            DateTime dataAtual = DateTime.Now;
            int anos = new DateTime(DateTime.Now.Subtract(_dataDeNascimento).Ticks).Year - 1;
            DateTime anosTranscorridos = _dataDeNascimento.AddYears(anos);
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
            Console.WriteLine("Dados da Pessoa");
            Console.WriteLine("Nome: {0}", _nome);
            Console.WriteLine("Altura: {0}", _altura);
            Console.WriteLine("Data de Nascimento: {0}", _dataDeNascimento.ToShortDateString());
            Console.WriteLine("Idade: {0}", CalcularIdade());
        }
    }
}
