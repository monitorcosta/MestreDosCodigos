using System.Collections.Generic;
using System.Linq;

namespace TrabalhandoNoConsoleEx04
{
    public class Aluno
    {
        public string Nome {get; private set;}
        public List<int> Notas { get; private set; }

        public Aluno(string nome)
        {
            Nome = nome;
            Notas = new List<int>();
        }

        public void AdicionarNota(int nota)
        {
            if (nota >= 0)
                Notas.Add(nota);
        }

        public int Media()
        {
            if (Notas.Count.Equals(0))
                return 0;

            var media = Notas.Sum(n => n) / Notas.Count;
            return media;
        }
    }
}
