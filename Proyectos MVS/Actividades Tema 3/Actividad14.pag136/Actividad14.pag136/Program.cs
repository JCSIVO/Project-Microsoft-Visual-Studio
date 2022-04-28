using System;

namespace Actividad14.pag136
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int acumulador = 0;
            do
            {
                acumulador = num + acumulador;
                //Console.WriteLine(num);
                num++;
                if (num / 5 == 3)
                {
                    //Console.WriteLine(num);
                }
                else if (num % 5 == 0) 
                {
                    Console.WriteLine(num);
                }
            } while (num <= 100);
            
            
        }
    }
}
