using System;

namespace Actividad4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int limite;
            int i;
            int aux;
            int a = 0;
            int b = 1;
            Console.WriteLine("Introduce el limite");
            limite = int.Parse(Console.ReadLine());
            for(i=0; i<limite;i++)
            {
                aux = a;
                a = b;
                b = aux + a;
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
