using System;

namespace UtilizandoPOOEx04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var televisao = new Televisao();
            var controleRemoto = new ControleRemoto(televisao);
           
            Console.WriteLine("+ Volume -");
            Console.WriteLine("< Canal >");
            Console.WriteLine("Aperte C e informe o canal desejado.");
            Console.WriteLine("Aperte V e consulte o volume atual");
            Console.WriteLine("Aperte H e consulte o canal atual");
            Console.WriteLine("Aperte I e consulte a configuração atual");
            Console.WriteLine("Aperte Z e desligue a aplicação");

            while (true)
            {
                var consoleInfoKey = Console.ReadKey();

                Console.Write("\n");

                string tecla = consoleInfoKey.KeyChar.ToString().ToUpper();
                controleRemoto.Controlar(tecla);
                
                if (tecla.ToUpper() == "Z")
                    break;
            }
        }
    }
}
