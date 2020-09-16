namespace TrabalhandoNoConsoleEx01
{
    public class Calculadora
    {
        private int _valorA;
        private int _valorB;

        public Calculadora(int valorA, int valorB)
        {
            _valorA = valorA;
            _valorB = valorB;
        }

        public int Subtrair()
        {
            return _valorA - _valorB;
        }

        public double? Dividir()
        {
            if (_valorA == 0)
                return null;

            return (double)_valorB / _valorA;
        }

        public int Multiplicar()
        {
            return _valorA * _valorB;
        }
    }
}
