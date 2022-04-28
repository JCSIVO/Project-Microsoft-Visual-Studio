using System;

namespace Actividad3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int euro = 0;
            const double pesetas = 166.386;
            double resultado = 0;
            Console.WriteLine("Introduce la cantidad en pesetas");
                euro = int.Parse(Console.ReadLine());
            if (euro > 0) { 
                resultado = euro * pesetas;
                Console.WriteLine("La conversion a euros es:");
                Console.WriteLine(resultado);
            }
            else {
                Console.WriteLine("No es posible hacer la conversión");
                    }
        }
    }
}
