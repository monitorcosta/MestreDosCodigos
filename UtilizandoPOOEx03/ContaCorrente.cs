using System;

namespace UtilizandoPOOEx03
{
    public class ContaCorrente : ContaBancaria, IImprimivel
    {
        private double _taxaDeOperacao = 2.5;

        public override void Depositar(double valorDoDeposito)
        {
            _saldo += valorDoDeposito - _taxaDeOperacao;
        }

        public override void Sacar(double valorDoSaque)
        {
            var novoSaldo = _saldo - (valorDoSaque + _taxaDeOperacao);

            if (novoSaldo >= 0)
                _saldo = novoSaldo;
        }

        public void MostrarDados()
        {
            Console.WriteLine("Consta Corrente");
            Console.WriteLine("Número: {0}", _numeroDaConta);
            Console.WriteLine("Saldo: {0}", _saldo);
            Console.WriteLine("Taxa de operação: {0}", _taxaDeOperacao);
        }
    }
}
