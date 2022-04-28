using System;

namespace Actividad3._18
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 7;
            for(int i=1; i<=100; i++)
            {
                if (i % numero == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
