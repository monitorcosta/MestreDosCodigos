using System;
using System.Collections.Generic;

namespace UtilizandoPOOEx03
{
    public class Notificador: INotificador
    {
        private readonly List<string> _mensagens;

        private string _titulo;

        public Notificador()
        {
            _mensagens = new List<string>();
        }

        public void AdicionarTitulo(string titulo)
        {
            _titulo = titulo;
        }

        public void AdicionarMensagem(string mensagem)
        {
            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                _mensagens.Add(mensagem);
            }
        }

        public void Notificar()
        {
            if (!string.IsNullOrWhiteSpace(_titulo))
            {
                Console.WriteLine(_titulo);
            }

            foreach (var mensagem in _mensagens)
            {
                Console.WriteLine(mensagem);
            }
        }
    }
}
