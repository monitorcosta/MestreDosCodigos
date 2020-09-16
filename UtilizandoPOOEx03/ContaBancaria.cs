using System;

namespace UtilizandoPOOEx03
{
    public abstract class ContaBancaria
    {
        protected string _numeroDaConta;
        protected double _saldo;

        protected ContaBancaria()
        {
            _numeroDaConta = new Random().Next(minValue: 1, maxValue: 2000).ToString();
        }

        public abstract void Sacar(double valorDoSaque);
        public abstract void Depositar(double valorDoDeposito);
    }
}
