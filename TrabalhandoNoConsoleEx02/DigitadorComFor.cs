using System;

namespace TrabalhandoNoConsoleEx02
{
    public class DigitadorComFor: Digitador, IDigitador
    {
        public void Digitar(int quantidadeDeFuncionarios)
        {
            for (int i = 0; i < quantidadeDeFuncionarios; i++)
            {
                DigitarFuncionario();
            }

            ImprimirSalarios();
        }
    }
}
