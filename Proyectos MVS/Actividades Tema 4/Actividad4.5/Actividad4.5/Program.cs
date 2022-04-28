using System;

namespace Actividad4._5
{
    class Program
    {
        public static decimal redondear( decimal b, int a)
        {
            Console.WriteLine("Introduce el numero a redondear");
            b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuantas Posiciones quieres redomdear?");
            a = int.Parse(Console.ReadLine());
            if (a == 1 )
            {
                //b = (b * 10);
                //b = b / 10;
                b++;
                return redondear(b, 1);
                
                //Console.WriteLine("{0:0}",b);
                //Console.WriteLine(c);
                //return b;
            }
            else if  (a == 2) 
            {
                b = (b * 100) + 100;

                b = b / 100;
                //Console.WriteLine(b);
                //Console.WriteLine(c);
                return a;
            } else
            {
                b = (b * 1000) +10;
                //c = (b - a*10);
                //Console.WriteLine(c);
                b = b / 1000;
                Console.WriteLine(b);
                //Console.WriteLine(c);
                return b;
            }
            //return redondear(b,a) ;
        }
        public static void Main()
        {
            //int a;
            //decimal b;
            //Console.WriteLine("Introduce el numero a redondear");
            //b = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("¿Cuantas Posiciones quieres redomdear?");
            //a = int.Parse(Console.ReadLine());
            decimal resultado;
            int a =0;
            decimal b = 0;
           
            resultado = redondear(b, a);
            Console.WriteLine(resultado);
            
        }
    }
}
