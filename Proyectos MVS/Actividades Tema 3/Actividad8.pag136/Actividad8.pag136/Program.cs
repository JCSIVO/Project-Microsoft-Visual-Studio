using System;

namespace Actividad8.pag136
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int contador = 0;
            int factor1 = 0;
            int factor2 = 0;
            int factor3 = 0;
            int factor4 = 0;
            int factor5 = 0;
            int factor6 = 0;
            int factor7 = 0;
            int factor8 = 0;
            int factor9 = 0;
            int factor10 = 0;
            int factor11 = 0;
            int acumulador = 0;
            Console.WriteLine("Introduce un numero");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            do{
                factor1 = numero * contador;
                acumulador = numero + 1;
                contador++;
                factor2 = numero * contador;
                acumulador = numero + 1;
                contador++;
                factor3 = numero * contador;
                acumulador = numero + 1;
                contador++;
                factor4 = numero * contador;
                acumulador = numero + 1;
                contador++;
                factor5 = numero * contador;
                acumulador = numero + 1;
                contador++;
                factor6 = numero * contador;
                acumulador = numero + 1;
                contador++;
                factor7 = numero * contador;
                acumulador = numero + 1;
                contador++;
                factor8 = numero * contador;
                acumulador = numero + 1;
                contador++;
                factor9 = numero * contador;
                acumulador = numero + 1;
                contador++;
                factor10 = numero * contador;
                acumulador = numero + 1;
                contador++;
                factor11 = numero * contador;
                acumulador = numero + 1;
                contador++;
            } while (contador <=1 );
            Console.WriteLine(factor1);
            Console.WriteLine(factor2);
            Console.WriteLine(factor3);
            Console.WriteLine(factor4);
            Console.WriteLine(factor5);
            Console.WriteLine(factor6);
            Console.WriteLine(factor7);
            Console.WriteLine(factor8);
            Console.WriteLine(factor9);
            Console.WriteLine(factor10);
            Console.WriteLine(factor11);
        }
            
            
        
        
    }
}
