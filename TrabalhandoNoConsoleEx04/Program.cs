using System;
using System.Collections.Generic;

namespace TrabalhandoNoConsoleEx04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando no Console: Exercício 4");

            int quantidade = DigitarQuantidadeDeAlunos();

            Console.WriteLine();

            Console.WriteLine("Digite uma letra para encerrar a digitação da nota.");
            Console.WriteLine("Digite notas inteiras de 0 a 10.");
            Console.WriteLine();
            var alunos = new List<Aluno>();
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o Nome do Aluno: ");
                string nomeDoAluno = Console.ReadLine();

                var aluno = new Aluno(nomeDoAluno);

                while (true)
                {
                    Console.Write("Digite a nota do aluno: ");
                    string notaString = Console.ReadLine();
                    bool notaValida = int.TryParse(notaString, out int nota);
                    if (!notaValida)
                    {
                        break;
                    }
                    
                    if (nota <= 0 || nota > 10)
                    {
                        Console.WriteLine("Digite notas inteiras de 0 a 10.");
                        continue;
                    }                    
                    
                    aluno.AdicionarNota(nota);                    
                }
                alunos.Add(aluno);
                Console.WriteLine();
            }

            new ImpressaoDeAlunos().Imprimir(alunos);

            Console.Write("Aperte qualquer tecla para encerrar a aplicação.");
            Console.ReadLine();
        }

        private static int DigitarQuantidadeDeAlunos()
        {            
            int quantidadeDeAlunos;
            while (true)
            {
                Console.Write("Escolha a quantidade de alunos para lançar nota: ");
                string quantidadeDigitada = Console.ReadLine();
                bool numeroValido = int.TryParse(quantidadeDigitada, out quantidadeDeAlunos);
                if (numeroValido)
                {
                    break;
                }
                Console.WriteLine("Digite um número inteiro e válido!");
            }

            return quantidadeDeAlunos;
        }
    }
}
