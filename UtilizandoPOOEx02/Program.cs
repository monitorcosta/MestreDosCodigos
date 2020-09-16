using System;

namespace UtilizandoPOOEx02
{
    public class Program
    {
        // colocar para perguntar se quer digitar outra pessoa
        // validar as informações se são válidas
        // ver se apaga as informações da tela
        // pensar se digita os dados na mesma linha
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
        }
    }
}
