using System;

namespace Actividad4._1
{
    class Program
    {
        public static int cuadrado (int n)

        {
            return  n * n;
        }
        public static void Main()
        { 
            int numero;
            int resultado;
             Console.WriteLine("Introduce uno de los lados del cuadrado");
             numero = int.Parse(Console.ReadLine());
             resultado= cuadrado(numero);
                if (resultado>= 1)
                {
                     Console.WriteLine(resultado);
                }
                 else
                {
                    Console.WriteLine("El valor introducido es incorrecto");
                }
          }


    }
}
