using System;

namespace Actividad3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
             //area cuadrado es lado x lado
            Console.WriteLine(" Introduce un lado del Cuadrado");
            num = int.Parse(Console.ReadLine());
            Console.Write(num * num);
        }
    }
}
