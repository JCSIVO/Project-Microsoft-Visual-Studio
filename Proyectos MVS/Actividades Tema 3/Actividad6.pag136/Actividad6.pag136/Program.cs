using System;

namespace Actividad6.pag136
{
    class Program
    {
        static void Main(string[] args)
        {
            int compra = 0;
            int dtto1 = 5;
            int dtto2 = 10;
            int dtto3 = 15;
            Console.WriteLine("Cual es tu importe");
            compra = int.Parse(Console.ReadLine());
            if (compra < 200)
            {
                Console.WriteLine("No se te aplica ningun descuento");
            }
            else if (compra  >= 200 & compra <= 500)
            {
                compra = (compra * dtto1) / 100;
                Console.WriteLine(compra);
            }
            else if (compra > 500 & compra < 1000)
            {
                compra = (compra * dtto2) / 100;
                Console.WriteLine(compra);
            }
            else
            {
                compra = (compra * dtto3) / 100;
                Console.WriteLine(compra);
            }
            Console.WriteLine("Tu compra te cuesta:{0}", compra);
        }
    }
}
