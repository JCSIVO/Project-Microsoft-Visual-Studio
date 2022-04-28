using System;

namespace Actividad3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num =10 ;
            string mensaje;
            Console.WriteLine("Introduce el valor del Numero");
            num = int.Parse(Console.ReadLine());
            mensaje = ( (num%2) !=0) ? "el numero es impar" : "el numero es par";
            Console.WriteLine(mensaje);
        }
    }
}
