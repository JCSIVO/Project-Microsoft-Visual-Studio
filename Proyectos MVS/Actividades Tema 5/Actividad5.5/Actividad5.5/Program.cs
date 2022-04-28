using System;

namespace Actividad5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int n in numero)
            {
                int numero1 = 0;
                numero1 = n % 2;
                 if ( numero1 == 0)
                {
                    Console.WriteLine("El {0} numero es par", n);
                } else
                {
                    Console.WriteLine("El numero {0} es impar", n);
                }
                
            }
            
        }
    }
}
