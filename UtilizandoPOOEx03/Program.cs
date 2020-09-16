using System;

namespace UtilizandoPOOEx03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContaBancaria contaBancaria = CriarContaBancaria();

            bool continuar = true;
            while (continuar)
            {
                string tipoDeOperacao = InformarTipoDeOperacao();
                switch (tipoDeOperacao.ToUpper())
                {
                    case "D":
                        Depositar(contaBancaria);
                        break;
                    case "S":
                        Sacar(contaBancaria);
                        break;
                    case "I":
                        ImprimirDadosDaConta((IImprimivel)contaBancaria);
                        break;
                    case "N":
                        contaBancaria = CriarContaBancaria();
                        break;
                    case "Z":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Operação inválida!");
                        break;
                }
            }
        }

        private static void Sacar(ContaBancaria contaBancaria)
        {
            Console.WriteLine("Informe o valor do saque:");
            string saque = Console.ReadLine();
            double valorDoSaque = Convert.ToDouble(saque);
            contaBancaria.Sacar(valorDoSaque);
        }

        private static void Depositar(ContaBancaria contaBancaria)
        {
            Console.WriteLine("Informe o valor do deposito:");
            string deposito = Console.ReadLine();
            double valorDoDeposito = Convert.ToDouble(deposito);
            contaBancaria.Depositar(valorDoDeposito);
        }

        private static string InformarTipoDeOperacao()
        {
            Console.WriteLine("Informe o tipo de operação:");
            Console.WriteLine("D - Depositar");
            Console.WriteLine("S - Sacar");
            Console.WriteLine("I - Imprimir dados");
            Console.WriteLine("N - Nova Conta");
            Console.WriteLine("Z - Sair");
            return Console.ReadLine();
        }

        private static string InformarTipoDeConta()
        {
            Console.WriteLine("Informe o tipo de conta desejada:");
            Console.WriteLine("1 - Conta Corrente");
            Console.WriteLine("2 - Conta Especial");

            return Console.ReadLine();
        }

        private static void ImprimirDadosDaConta(IImprimivel contaBancaria)
        {
            contaBancaria.MostrarDados();
        }

        private static ContaBancaria CriarContaBancaria()
        {
            string tipoDeConta = InformarTipoDeConta();
            if (tipoDeConta == "1")
                return new ContaCorrente();

            if (tipoDeConta == "2")
                return new ContaEspecial();

            return null;
        }
    }
}
