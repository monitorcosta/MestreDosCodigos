using System;

namespace UtilizandoPOOEx02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Utilizando POO: Exercício 2");
            Console.WriteLine();
            Console.WriteLine("Digite os dados da pessoa");

            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Altura:");
            string altura = Console.ReadLine();

            Console.WriteLine("Data de nascimento:");
            string nascimento = Console.ReadLine();

            var pessoa = new Pessoa();
            pessoa.SetNome(nome);
            pessoa.SetDataDeNascimento(Convert.ToDateTime(nascimento));
            pessoa.SetAltura(Convert.ToDouble(altura));

            pessoa.ImprimirDados();

            Console.WriteLine("Aperte qualquer tecla para encerrar a aplicação.");
            Console.ReadLine();
        }
    }
}
