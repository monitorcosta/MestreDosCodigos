namespace TrabalhandoNoConsoleEx06
{
    public class CalculadorDeId
    {
        private int _idPadrao;
        public CalculadorDeId(int id)
        {
            _idPadrao = id;
        }            

        public void ObterPorOut(out int id)
        {
            id = _idPadrao;
        }

        public void ObterPorRef(ref int id)
        {
            id++;
        }
    }
}
