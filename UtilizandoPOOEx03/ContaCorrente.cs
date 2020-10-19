namespace UtilizandoPOOEx03
{
    public class ContaCorrente : ContaBancaria, IImprimivel
    {
        private readonly double _taxaDeOperacao = 2.5;

        public override void Depositar(double valorDoDeposito)
        {
            _saldo += valorDoDeposito - _taxaDeOperacao;
        }

        public override void Sacar(double valorDoSaque)
        {
            var valorTotalDaSaida = valorDoSaque + _taxaDeOperacao;
           
            if (ValidarSaque(_saldo, valorTotalDaSaida))
            {
                _saldo -= valorTotalDaSaida; 
            }            
        }

        public void MostrarDados()
        {
            _notificador.AdicionarTitulo("Conta Corrente");
            _notificador.AdicionarMensagem($"Número: {_numeroDaConta}");
            _notificador.AdicionarMensagem($"Saldo: {_saldo}");
            _notificador.AdicionarMensagem($"Taxa de operação: {_taxaDeOperacao}");
            _notificador.Notificar();
        }
    }
}
