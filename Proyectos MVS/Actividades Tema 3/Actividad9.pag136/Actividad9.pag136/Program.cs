using System;

namespace Actividad9.pag136
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string mensaje;
            Console.WriteLine("introduce el primer munero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduce el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            mensaje = (num1 >= num2) ? "El primero es mayor o son iguales" : "el segundo  es mayor";
            Console.WriteLine(mensaje);


            /*if (num1 > num2)
            {
                Console.WriteLine("\n");
                Console.WriteLine("El numero mayor es el primero: {0}", num1);
            }
            else if (num1<num2)
            {
                Console.WriteLine("\n");
                Console.WriteLine("El segundo numero es maryor: {0}", num2);
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("los numero son iguales");
            }*/
        }
    }
}
