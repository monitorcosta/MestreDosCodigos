using System;

namespace UtilizandoPOOEx04
{
    public class Notificador : INotificador
    {
        public void Notificar(string mensagem)
        {
            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                Console.WriteLine(mensagem);
            }
        }
    }
}
