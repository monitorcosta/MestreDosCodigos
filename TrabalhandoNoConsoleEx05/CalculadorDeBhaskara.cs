using System;

namespace TrabalhandoNoConsoleEx05
{
    public class CalculadorDeBhaskara
    {
        private readonly int _coeficienteA;
        private readonly int _coeficienteB;
        private readonly int _coeficienteC;

        public CalculadorDeBhaskara(int coeficienteA, int coeficienteB, int coeficienteC)
        {
            _coeficienteA = coeficienteA;
            _coeficienteB = coeficienteB;
            _coeficienteC = coeficienteC;
        }

        public bool DeltaNegativo()
        {
            return CalcularDelta() < 0;
        }

        public double CarlcularValorRaiz1()
        {
            return (-_coeficienteB + Math.Sqrt(CalcularDelta())) / (2 * _coeficienteA);
        }

        public double CarlcularValorRaiz2()
        {
            return (-_coeficienteB - Math.Sqrt(CalcularDelta())) / (2 * _coeficienteA);
        }

        private double CalcularDelta()
        {
            return Math.Pow(_coeficienteB, 2) - (4 * _coeficienteA * _coeficienteC);
        }
    }
}
