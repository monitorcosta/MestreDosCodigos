using System;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhandoNoConsoleEx07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando no Console: Exercício 7");

            Console.WriteLine("Digite 4 números inteiros.");

            List<int> numeros = new List<int>();

            int contador = 1;

            while (contador <= 4)
            {
                while (true)
                {
                    Console.Write("Digite o número {0}: ", contador);
                    string numeroString = Console.ReadLine();

                    bool numeroValido = int.TryParse(numeroString, out var numero);
                    if (!numeroValido)
                    {
                        Console.WriteLine("Digite um número inteiro e válido!");
                        continue;
                    }

                    numeros.Add(numero);
                    break;
                }

                contador++;
            }

            int soma = numeros.Where(n => n % 2 == 0).Sum();
            Console.WriteLine(soma);

            Console.WriteLine("Aperte qualquer tecla para encerrar a aplicação.");
            Console.ReadLine();
        }
    }
}
