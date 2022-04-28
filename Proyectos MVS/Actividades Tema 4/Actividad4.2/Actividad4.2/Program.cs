using System;

namespace Actividad4._2
{
    class Program
    {
        public static int area_tri(int a, int b)
        {
            return (a * b) / 2;
        }
        public static void Main()
        {
            int a;
            int b;
            int resultado;
            Console.WriteLine("Introduce la altura del triangulo");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la base del triangulo");
            b = int.Parse(Console.ReadLine());
            resultado = area_tri(a, b);
            if (resultado >= 1)
            {
                Console.WriteLine("El area del triangulo es;");
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("El valor introducido es incorrrecto");
            }
        }
    }
}
