using System;

namespace UtilizandoPOOEx04
{
    public class Televisao
    {
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
        }

        public void ExibirCanalAtual()
        {
            Console.Write("\nCanal: {0}", _canal);
        }

        public void ExibirVolume()
        {
            Console.Write("\nVolume: {0}", Volume);
        }

        public void ExibirDadosAtuais()
        {
            ExibirCanalAtual();
            ExibirVolume();
            Console.WriteLine();
        }
    }
}
