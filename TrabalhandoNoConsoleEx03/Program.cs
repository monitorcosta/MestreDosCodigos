using System;

namespace TrabalhandoNoConsoleEx03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando no Console: Exercício 3");
            var contador = 1;
            while (contador <= 100)
            {
                if (contador % 3 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }
            Console.WriteLine("Aperte uma tecla para encerrar a aplicação!");
            Console.ReadLine();
        }
    }
}
