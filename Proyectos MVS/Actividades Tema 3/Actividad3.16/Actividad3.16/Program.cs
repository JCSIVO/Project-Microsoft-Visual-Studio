using System;

namespace Actividad3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int totaldias = 0;
            int precipitacionesmes;
            int mes = 1 ;
            int num1 = 31;
            int promedio = 0;
            do
            {
                Console.WriteLine("Introduce las precipitaciones del mes {0}", mes);
                precipitacionesmes = int.Parse(Console.ReadLine());
                totaldias = totaldias + precipitacionesmes;
                mes++;
                
                promedio = num1 / precipitacionesmes;
                Console.WriteLine("el promedio de dias son {0} dias", promedio);
            } while (mes <= 12);
            Console.WriteLine("ha llovido este año durante {0} dias", totaldias);
            Console.ReadLine();
          
        }
            
    } 
        
    
}
