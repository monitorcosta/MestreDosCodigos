using System;

namespace TrabalhandoNoConsoleEx02
{
    public abstract class Digitador
    {
        protected int _menorSalario;
        protected int _maiorSalario;

        protected void DigitarFuncionario()
        {
            DigitarNomeDoFuncionario();

            int valorDoSalario = DigitarSalario();
            AtualizarSalarios(valorDoSalario);

            Console.WriteLine();
        }

        private static void DigitarNomeDoFuncionario()
        {
            while (true)
            {
                Console.Write("Digite o Nome do Funcionário:");
                string nome = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nome))
                    break;

                Console.WriteLine();
            }
        }

        private int DigitarSalario()
        {
            
            int salario;
            while (true)
            {
                Console.Write("Digite o Salário do Funcionário:");
                string numeroString = Console.ReadLine();
                bool numeroValido = int.TryParse(numeroString, out salario);
                if (!numeroValido)
                {
                    Console.WriteLine("Digite um salário inteiro e válido!");
                    continue;
                }
                break;
            }
            return salario;
        }

        private void AtualizarSalarios(int salario)
        {
            _maiorSalario = Math.Max(_maiorSalario, salario);
            _menorSalario = _menorSalario == 0 ? salario : Math.Min(_menorSalario, salario);
        }

        protected void ImprimirSalarios()
        {
            Console.WriteLine("O menor salário é {0}", _menorSalario);
            Console.WriteLine("O maior salário é {0}", _maiorSalario);
        }
    }
}
