using System;

namespace Actividad3._8
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
            resultado = euro * pesetas;
            Console.WriteLine("La conversion a euros es:");
            Console.WriteLine(resultado);
        }
    }
}
