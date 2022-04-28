using System;

namespace Actividad12.pag136
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int num = 0;
            double num2 = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            double e = 0;
            //int resto;
            //bool resto1;
            Console.WriteLine("Introduce un numero de cinco digitos");
            num = int.Parse(Console.ReadLine());
            num2 = num;
            if(num > 9999 && num <= 99999)
            {
                a = num % 10;
                //Console.WriteLine(a);
                b = ((num-a)/10)%10;
                //Console.WriteLine(b);
                //Console.WriteLine("{0}{1}", a, b);
                c = (((num)/10)/10)%10;
                //Console.WriteLine("{0}{1}{2}",a,b,c);
                d = (((num) /10)/10)/10%10;
                //Console.WriteLine("{0}{1}{2}{3}",a,b,c,d);
                e = ((((num)/10)/10)/10)/10 %10 ;
                Console.WriteLine("{0}{1}{2}{3}{4}",a,b,c,d,e);
                num2 =(e*1)+(d*10)+(c*100)+(b*1000)+(a*10000) ;
                //Console.WriteLine(num2);
                if (num / num2 == 1)
                {
                    Console.WriteLine("El numero es polindromo");
                }
                else if (num/num2!=1)
                {
                    Console.WriteLine("El numero NO ES polindormo");
                }


            }
            else
            {
                Console.WriteLine("El numero introducido es invalido");
            }

            
        }
    }
}
