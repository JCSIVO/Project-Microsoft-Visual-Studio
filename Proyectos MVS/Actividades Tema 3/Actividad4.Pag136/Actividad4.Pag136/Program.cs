using System;

namespace Actividad4.Pag136
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido1;
            string apellido2;
            Console.WriteLine("Introduce tu nombre");
            nombre = (string) 
            Console.ReadLine();
            Console.WriteLine("Introduce tu primer Apellido");
            apellido1 = (string)
            Console.ReadLine();
            Console.WriteLine("Introduce tu Segundo Apellido");
            apellido2 = (string)
            Console.ReadLine();

            Console.WriteLine("Te llamas {0}:" ,nombre+  "\v \v tu primer apellido es:" +apellido1+ "\v \v Tu segundo apellido es:"  +apellido2);
        }
    }
}
