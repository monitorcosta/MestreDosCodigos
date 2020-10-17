using System;

namespace UtilizandoPOOEx03
{
    public abstract class ContaBancaria
    {
        protected string _numeroDaConta;
        protected double _saldo;
        protected INotificador _notificador;

        protected ContaBancaria()
        {
            _numeroDaConta = new Random().Next(minValue: 1, maxValue: 2000).ToString();
            _notificador = new Notificador();
        }

        public abstract void Sacar(double valorDoSaque);
        public abstract void Depositar(double valorDoDeposito);

        protected bool ValidarSaque(double saldoDisponivel, double valorDoSaque)
        {
            if (saldoDisponivel < valorDoSaque)
            {
                _notificador.AdicionarMensagem("Saldo Insuficiente.");
                _notificador.Notificar();
                return false;
            }

            return true;
        }
    }
}
