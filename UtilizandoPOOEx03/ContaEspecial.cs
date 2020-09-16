using System;

namespace UtilizandoPOOEx03
{
    public class ContaEspecial : ContaBancaria, IImprimivel
    {
        private double _limiteDeCredito = 2000;
        public override void Depositar(double valorDoDeposito)
        {
            _saldo += valorDoDeposito;
        }

        public override void Sacar(double valorDoSaque)
        {
            if (_saldo - valorDoSaque <= _limiteDeCredito + _saldo)
            {
                _saldo -= valorDoSaque;
            }
        }

        public void MostrarDados()
        {
            Console.WriteLine("Consta Especial");
            Console.WriteLine("Número: {0}", _numeroDaConta);
            Console.WriteLine("Saldo: {0}", _saldo);
            Console.WriteLine("Limite de Crédito: {0}", _limiteDeCredito);
        }
    }
}
