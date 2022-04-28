using System;

namespace Actividad1.pag166
{
    class Program
    {
        public static int dias(int mes, int dia)
        {
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                if (dia < 31)
                {
                    dia++;

                }
                else { mes++; }
                Console.WriteLine("\n Cambiamod de mes");
                return mes;
                

            } else if (mes == 2)
            {
                if (dia < 28)
                {
                    dia++;
                } else
                {
                    mes++;
                    Console.WriteLine("\n Cambiamos de mes");
                    return mes;
                }
                

            } else
            { if (dia < 30)
                {
                    dia++;
                } else
                {
                    mes++;
                    Console.WriteLine("\n Cambiamos de mes");
                    return mes;
                }
            } return dia;
            
        }
        public static void Main(string[] args)
        {
            int dia;
            int mes;
            int resultado;
            Console.WriteLine("¿Que dia es hoy??");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("¿De que mes quieres saber?");
            mes = int.Parse(Console.ReadLine());
            resultado = dias(mes, dia);
            Console.WriteLine(resultado);
            
        }
    }
}
