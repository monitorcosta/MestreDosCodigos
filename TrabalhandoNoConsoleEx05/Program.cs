using System;

namespace TrabalhandoNoConsoleEx05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando no Console: Exercício 5");
            Console.WriteLine();

            Console.WriteLine("Calcular Bháskara");
            Console.WriteLine();

            int coeficienteA = DigitarNumero("a");
            int coeficienteB = DigitarNumero("b");
            int coeficienteC = DigitarNumero("c");

            var calculadorDeBaskara = new CalculadorDeBhaskara(coeficienteA, coeficienteB, coeficienteC);
            if (!calculadorDeBaskara.DeltaNegativo())
            {
                double raiz1 = calculadorDeBaskara.CarlcularValorRaiz1();
                double raiz2 = calculadorDeBaskara.CarlcularValorRaiz2();

                Console.WriteLine("Raiz 1: {0}", raiz1);
                Console.WriteLine("Raiz 2: {0}", raiz2);
            }
            else
            {
                Console.WriteLine("A equacao nao possui raizes reais!");
            }

            Console.Write("Aperte qualquer tecla para encerrar a aplicação.");
            Console.ReadLine();
        }

        private static int DigitarNumero(string nomeCoeficiente)
        {
            bool numeroValido = false;
            int valorDoCoeficiente = 0;
            while (!numeroValido)
            {
                Console.Write("Digite o coeficiente '{0}' da equação: ", nomeCoeficiente);
                string valorAString = Console.ReadLine();
                numeroValido = int.TryParse(valorAString, out valorDoCoeficiente);
                if (!numeroValido)
                {
                    Console.WriteLine("Dígito inválido.");
                }
            }
            return valorDoCoeficiente;
        }
    }
}
