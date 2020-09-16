using System;

namespace TrabalhandoNoConsoleEx02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando no Console: Exercício 2");
            DigitarManeiraDeTestar(out string maneiraDeTestar);
            IDigitador digitador = CriarDigitador(maneiraDeTestar);

            int quantidadeDeFuncionarios = DigitarQuantidadeDeFuncionarios();

            Console.WriteLine();

            digitador.Digitar(quantidadeDeFuncionarios);

            Console.Write("Aperte uma tecla para finalizar a aplicação.");
            Console.ReadLine();
        }

        private static void DigitarManeiraDeTestar(out string maneiraDeTestar)
        {
            while (true)
            {
                Console.WriteLine("Escolha a maneira de executar:");
                Console.WriteLine("F - For");
                Console.WriteLine("W - While");
                maneiraDeTestar = Console.ReadLine();
                if (ValidarManeiraDeTestar(maneiraDeTestar))
                    break;

            }
        }

        private static int DigitarQuantidadeDeFuncionarios()
        {
            
            int quantidadeDeFuncionarios;
            while (true)
            {
                Console.Write("Escolha a quantidade de funcionários para cadastrar: ");
                string quantidadeDigitada = Console.ReadLine();
                bool numeroValido = int.TryParse(quantidadeDigitada, out quantidadeDeFuncionarios);
                if (numeroValido)
                {
                    break;
                }
                Console.WriteLine("Digite um número inteiro e válido!");
            }

            return quantidadeDeFuncionarios;
        }

        private static IDigitador CriarDigitador(string maneiraDeTestar)
        {
            string maneira = maneiraDeTestar.ToUpper();
            if (maneira == "F")
                return new DigitadorComFor();

            if (maneira == "W")
                return new DigitadorComWhile();

            return null;
        }

        private static bool ValidarManeiraDeTestar(string maneiraDeTestar)
        {
            string maneira = (maneiraDeTestar ?? "").ToUpper();
            return maneira == "F" || maneira == "W";
        }
    }
}
