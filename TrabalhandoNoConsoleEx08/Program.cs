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

            Console.WriteLine("Imprimir todos os números.");
            foreach (var numero in numeros)
            { 
                Console.WriteLine(numero);
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

            Console.WriteLine("Aperte qualquer tecla para continuar.");
            Console.ReadLine();

            Console.WriteLine("Imprimir o primeiro.");
            Console.WriteLine(numeros.FirstOrDefault());

            Console.WriteLine("Aperte qualquer tecla para continuar.");
            Console.ReadLine();

            Console.WriteLine("Imprimir o último.");
            Console.WriteLine(numeros.LastOrDefault());

            Console.WriteLine("Aperte qualquer tecla para continuar.");
            Console.ReadLine();

            Random random = new Random();
            var novoNumeroParaInicioDaLista = random.Next(numeros.OrderBy(o => o).LastOrDefault());
            numeros.Insert(0, novoNumeroParaInicioDaLista);
            Console.WriteLine("Inserido no início da lista: criado {0} - na lista {1}", novoNumeroParaInicioDaLista, numeros[0]);

            Console.WriteLine("Aperte qualquer tecla para continuar.");
            Console.ReadLine();

            var novoNumeroParaFimDaLista = random.Next(numeros.OrderBy(o => o).LastOrDefault());
            numeros.Insert(numeros.Count, novoNumeroParaFimDaLista);
            Console.WriteLine("Inserido no fim da lista: criado {0} - na lista {1}", novoNumeroParaFimDaLista, numeros[numeros.Count-1]);

            Console.WriteLine("Aperte qualquer tecla para continuar.");
            Console.ReadLine();

            int numeroInformado;
            while (true)
            {
                Console.Write("Digite um número: ");
                string numeroString = Console.ReadLine();
                bool numeroValido = int.TryParse(numeroString, out numeroInformado);
                if (numeroValido)
                {
                    break;
                }
                Console.WriteLine("Digite um número válido");
            }
            if(numeros.Any(t => t == numeroInformado))
            {
                Console.WriteLine("{0} está na lista.", numeros.FirstOrDefault(t => t == numeroInformado));
            }

            Console.WriteLine("Aperte qualquer tecla para continuar.");
            Console.ReadLine();

            Console.WriteLine("Converter em array");
            var arrayDeNumeros = numeros.ToArray();
            Console.WriteLine("Tipo lista: {0}", arrayDeNumeros.GetType());

            Console.WriteLine("Aperte qualquer tecla para encerrar a aplicação.");
            Console.ReadLine();
        }
    }
}

