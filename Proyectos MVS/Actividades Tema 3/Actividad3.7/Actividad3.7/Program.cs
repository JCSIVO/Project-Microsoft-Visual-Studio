using System;

namespace Actividad3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("Introduce una letra del abecedario:");
            letra = (char)Console.Read();
            Console.WriteLine("La siguiente letra del abecedario es:");
            Console.WriteLine(++letra);
            
        }
    }
}
