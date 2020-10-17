using System;

namespace TrabalhandoNoConsoleEx01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando no Console: Exercício 1");
            Console.WriteLine("Digite números inteiros");

            int valorA = DigitarNumero("A");
            int valorB = DigitarNumero("B");

            Console.WriteLine("Valor A: {0} - {1}", valorA, ValidarTipoNumero(valorA));
            Console.WriteLine("Valor B: {0} - {1}", valorB, ValidarTipoNumero(valorB));

            var calculadora = new Calculadora(valorA, valorB);
            int subtracao = calculadora.Subtrair();
            double? divisao = calculadora.Dividir();
            int multiplicacao = calculadora.Multiplicar();

            Console.WriteLine("Escolha um resultado");
            Console.WriteLine("1 - Subtração: {0}", subtracao);
            Console.WriteLine("2 - Divisão: {0}", TratarDivisao(divisao));
            Console.WriteLine("3 - Multiplicação: {0}", multiplicacao);

            string escolha = Console.ReadLine();
            switch (escolha)
            {
                case "1":
                    Console.WriteLine("Escolheu Subtração: {0}", subtracao);
                    break;
                case "2":
                    Console.WriteLine("Escolheu Divisão: {0}", TratarDivisao(divisao));
                    break;
                case "3":
                    Console.WriteLine("Escolheu Multiplicação: {0}", multiplicacao);
                    break;
                default:
                    Console.WriteLine("Escolha inválida: {0}", escolha);
                    break;
            }

            Console.WriteLine("Aperte qualquer tecla para encerrar a aplicação.");
            
            Console.ReadLine();
        }

        private static string TratarDivisao(double? divisao)
        {
            return divisao == null ? "Divisão inválida" : divisao.ToString();
        }

        private static int DigitarNumero(string nomeValor)
        {
            int numero;

            while (true)
            {
                Console.Write("Informe o valor {0}: ", nomeValor);

                string numeroString = Console.ReadLine();

                bool numeroValido = int.TryParse(numeroString, out numero);
                if (!numeroValido)
                {
                    Console.WriteLine("Digite um número inteiro e válido!");
                    continue;
                }
                break;
            }

            return numero;
        }

        private static string ValidarTipoNumero(int numero)
        {
            return numero % 2 == 0 ? "Par" : "Ímpar";
        }
    }
}
