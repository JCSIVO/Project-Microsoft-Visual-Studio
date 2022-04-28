using System;

namespace Actividad3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num1 = 0;
            int num2 = 0;
            int resultado = 0;
      
            Console.WriteLine("introduce el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            resultado = num1 * num2;
            Console.WriteLine(resultado)*/

            int num1 = 0;
            int num2 = 0;
            int resultado = 0;
            int acumulador = 0;
            int contador = 1;
            Console.WriteLine("introduce el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            while (contador <= num2)
            {
                num2--;
                resultado = num1;
                Console.WriteLine(resultado);
                acumulador = acumulador + resultado;
            }
            contador++;
            Console.WriteLine("El resultado final resultado es:");
            Console.WriteLine(acumulador);
            
        }
    }
}
