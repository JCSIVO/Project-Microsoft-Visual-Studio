using System;

namespace Actividad15.pag136
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int contador = 1;
            int max = 0;
            int acumulador = 0;
            int resultado = 0;
            int resultado1 = 0;
            Console.WriteLine("Introduce la base de la potencia");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el exponente");
            num2 = int.Parse(Console.ReadLine());
            max = num2;
            while (num2 != contador)
            {
                num2 = num1;
                acumulador = num1 +0;
                resultado =  (acumulador*num1+ acumulador*num1+ acumulador * num1 +
                acumulador * num1+ acumulador * num1 + acumulador * num1 + acumulador * num1 + acumulador * num1);
                resultado1 = resultado;
                //onsole.WriteLine(acumulador);
                //Console.WriteLine(resultado);
                contador++;

                //resultado1 = (resultado + resultado);

            }
            
            Console.WriteLine(resultado1);
            //resultado= (num1*num2)*num1;
            //Console.WriteLine(num1);
        }
    }
}
