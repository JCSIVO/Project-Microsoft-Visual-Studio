using System;

namespace Actividad7.Pag136
{
    class Program
    {
        static void Main(string[] args)
        { 
            int ano=0;
            Console.WriteLine("Introduce el año");
            ano = int.Parse(Console.ReadLine());
            if (ano % 4 == 0)
            {
                Console.WriteLine("Este es un año bisiesto");
            }
            else
            {
                Console.WriteLine("Este año NO ES bisiesto");
            }
        }
    }
}
