using System;

namespace UtilizandoPOOEx04
{
    public class Televisao
    {
        private readonly INotificador _notificador;
        
        private int _canal;
        private int _volume;

        public int Volume
        {
            get { return _volume; }
            set
            {
                if (value >= 0)
                {
                    _volume = value;
                }
            }
        }

        public int Canal
        {
            get { return _canal; }
            set
            {
                if (value >= 0)
                {
                    _canal = value;
                }
            }
        }

        public Televisao()
        {
            _volume = 1;
            _canal = 1;
            _notificador = new Notificador();
        }

        public void ExibirCanalAtual()
        {
            Console.WriteLine($"Canal: {_canal}");
        }

        public void ExibirVolume()
        {
            _notificador.Notificar($"Volume: {_volume}");
        }

        public void ExibirDadosAtuais()
        {
            ExibirCanalAtual();
            ExibirVolume();
        }
    }
}
