namespace UtilizandoPOOEx02
{
    public interface INotificador
    {
        void AdicionarTitulo(string titulo);
        void AdicionarMensagem(string mensagem);
        void Notificar();
    }
}
