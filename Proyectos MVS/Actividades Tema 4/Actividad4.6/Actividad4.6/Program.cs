using System;

namespace Actividad4._6
{
    class Program
    {
        public static int menu()
        {
            int opcion;
            Console.WriteLine("Menú");
            Console.WriteLine("1. Area del Circulo");
            Console.WriteLine("2. Area de Cuadrado");
            Console.WriteLine("3. Area del Rectángulo");
            Console.WriteLine("4. Area del Triángulo");
            Console.WriteLine("5. Salir");
            Console.WriteLine("¿Que opcion queire hacer?");
            opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

            public static double areacirculo(int a)
            {
            double pi = 3.1415;
            return pi * a * a;
             }
            public static int areacuadrado(int a)
            {
            return a * a;
            }
            public static int arearectangulo(int a, int b)
            {
            return a * b;
            }
            public static int areatriangulo(int a, int b)
            {
            return (a * b) / 2;
            }

             static void Main(string[] args)
            {
                int opcion;
                int a = 0;
                int b = 0;
                double resultado;
            do
            {
                opcion = menu();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduce el radio del circulo");
                        a = int.Parse(Console.ReadLine());
                        resultado = areacirculo(a);
                        Console.WriteLine(resultado);
                        break;
                    case 2:
                        Console.WriteLine("Introduce el lado del cuadrado");
                        a = int.Parse(Console.ReadLine());
                        resultado = areacuadrado(a);
                        Console.WriteLine(resultado);
                        break;
                    case 3:
                        Console.WriteLine("Introduce base del rectangulo");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del rectangulo");
                        b = int.Parse(Console.ReadLine());
                        resultado = arearectangulo(a,b);
                        Console.WriteLine(resultado);
                        break;
                    case 4:
                        Console.WriteLine("Introduce base del triangulo");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del triangulo");
                        b = int.Parse(Console.ReadLine());
                        resultado = areatriangulo(a,b);
                        Console.WriteLine(resultado);
                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar el programa");
                        break;
                    default:
                        Console.WriteLine("Opcion inexsistente");
                        break;
                }
                Console.ReadLine();
            } while (opcion != 5);
                
             }
    }
}
