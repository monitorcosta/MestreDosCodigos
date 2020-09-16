using System;
using System.Globalization;

namespace TrabalhandoNoConsoleEx02
{
    public class DigitadorComWhile: Digitador, IDigitador
    {
        public void Digitar(int quantidadeDeFuncionarios)
        {
            int contador = 0;
            while (contador < quantidadeDeFuncionarios)
            {
                DigitarFuncionario();
                contador++;
            }

            ImprimirSalarios();
        }
    }
}
