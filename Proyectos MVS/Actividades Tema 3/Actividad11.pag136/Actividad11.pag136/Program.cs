using System;

namespace Actividad11.pag136
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Introduce un numero");
            num=int.Parse(Console.ReadLine());
            num1 = num;
            num2 = num;
            if (num >= 10 & num < 100)
            {
                num = num /10;
                num1 = num1 % 10;
                Console.WriteLine("{0}-{1}", num, num1);
            }
            else if (num >=100 & num < 999)
            {
                num = num /100;
                num2 = num2 % 7;
                num1 = num1 % 10;
                Console.WriteLine("{0}-{1}-{2}",num,num2,num1);
            }





            //Console.WriteLine( num);




        }
    }
}
