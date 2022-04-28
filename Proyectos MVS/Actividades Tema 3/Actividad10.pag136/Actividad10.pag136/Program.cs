using System;

namespace Actividad10.pag136
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string mensaje;
            Console.WriteLine("Introduce el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            mensaje = (num1 % num2 ==0) ? "El segundo es divisor del primero":"El segundo no es divisor";
            Console.WriteLine(mensaje);
        }
    }
}
