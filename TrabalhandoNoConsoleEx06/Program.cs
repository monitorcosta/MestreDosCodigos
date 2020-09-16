using System;

namespace TrabalhandoNoConsoleEx06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando no Console: Exercício 6");
            var random = new Random();
            int numeroPadrao = random.Next(minValue: 1, maxValue: 20);
            int numeroDigitado = 0;
            bool numeroValido = false;
            while (!numeroValido)
            {
                Console.WriteLine("Digite um inteiro diferente de {0}:", numeroPadrao);
                string numeroString = Console.ReadLine();
                numeroValido = int.TryParse(numeroString, out numeroDigitado);
                if (!numeroValido)
                {
                    Console.WriteLine("Dígito inválido.");
                }

                if (numeroPadrao == numeroDigitado)
                {
                    numeroValido = false;
                }
            }

            var calculadorDeId = new CalculadorDeId(numeroDigitado);
            calculadorDeId.ObterPorOut(out int idPorOut);
                        
            calculadorDeId.ObterPorRef(ref numeroDigitado);

            Console.WriteLine("Valor por Out: {0}", idPorOut);
            Console.WriteLine("Valor por Ref: {0}", numeroDigitado);

            Console.Write("Aperte qualquer tecla para encerrar a aplicação.");
            Console.ReadLine();
        }
    }
}
