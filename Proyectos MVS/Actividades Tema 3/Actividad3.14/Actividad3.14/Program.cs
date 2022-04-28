using System;

namespace Actividad3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a= 0;
            int acumulador = 0;
            int contador = 5;
            while (contador >= 1)
            { 
                acumulador = a;
                acumulador = acumulador + a;
                Console.WriteLine("*****");
                contador--;
            }
        }
    }
}
