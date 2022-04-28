using System;

namespace Actividad4._3
{
    class Program
    {
        public static int poten(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            } else return a*poten(a,b-1);
        }
        public static void Main()
        {
            int a;
            int b;
            int resultado;
            Console.WriteLine("Introduce la base de la potencia:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el exponente");
            b = int.Parse(Console.ReadLine());
            resultado = poten(a,b);
                Console.WriteLine("la potencia es");
                Console.WriteLine(resultado);
            
        }
    }
}
