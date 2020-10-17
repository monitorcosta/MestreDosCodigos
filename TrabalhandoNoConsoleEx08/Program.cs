using System;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhandoNoConsoleEx08
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando no Console: Exercício 8");

            Console.WriteLine("Digite números inteiros.");
            Console.WriteLine("Para encerrar a digitação digite algo que não seja número.");

            List<int> numeros = new List<int>();
            while (true)
            {
                Console.Write("Digite um número: ");
                string numeroString = Console.ReadLine();
                bool numeroValido = int.TryParse(numeroString, out var numero);
                if (!numeroValido)
                {
                    break;
                }
                numeros.Add(numero);
            }

            if (numeros.Count <= 0)
            {
                Console.WriteLine("Nenhum número digitado.");
                return;
            }

            Console.WriteLine("Aperte qualquer tecla para continuar.");
            Console.ReadLine();

            Console.WriteLine("Imprimir todos os números em ordem crescente.");
            foreach (var numero in numeros.OrderBy(o => o))
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Aperte qualquer tecla para continuar.");
            Console.ReadLine();

            Console.WriteLine("Imprimir todos os números em ordem decrescente.");
            foreach (var numero in numeros.OrderByDescending(o => o))
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Aperte qualquer tecla para encerrar a aplicação.");
            Console.ReadLine();
        }
    }
}

