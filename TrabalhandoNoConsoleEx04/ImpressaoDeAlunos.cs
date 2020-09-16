using System;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhandoNoConsoleEx04
{
    public class ImpressaoDeAlunos
    {
        public void Imprimir(List<Aluno> alunos)
        {
            List<Aluno> alunosParaImpressao = alunos.Where(a => a.Media() > 7).ToList();
            foreach (var aluno in alunosParaImpressao)
            {
                Console.WriteLine("Nome do aluno: {0}", aluno.Nome);
                foreach (var nota in aluno.Notas)
                {
                    Console.WriteLine("Nota: {0}", nota);
                }
            }
        }
    }
}
