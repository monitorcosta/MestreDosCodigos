namespace UtilizandoPOOEx03
{
    public class ContaEspecial : ContaBancaria, IImprimivel
    {
        private readonly double _limiteDeCredito = 2000;

        public override void Depositar(double valorDoDeposito)
        {
            _saldo += valorDoDeposito;
        }

        public override void Sacar(double valorDoSaque)
        {
            var saldoDisponivel = _limiteDeCredito + _saldo;

            if (ValidarSaque(saldoDisponivel, valorDoSaque))
            {
                _saldo -= valorDoSaque;
            }
        }

        public void MostrarDados()
        {
            _notificador.AdicionarTitulo("Conta Especial");
            _notificador.AdicionarMensagem($"Número {_numeroDaConta}");
            _notificador.AdicionarMensagem($"Saldo: {_saldo}");
            _notificador.AdicionarMensagem($"Limite de Crédito: {_limiteDeCredito}");
            _notificador.Notificar();
        }
    }
}
