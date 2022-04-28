using System;

namespace Actividad3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            Console.WriteLine("1.- Lunes");
            Console.WriteLine("2.- Martes");
            Console.WriteLine("3.- Miercoles");
            Console.WriteLine("4.- Jueves");
            Console.WriteLine("5.- Viernes");
            Console.WriteLine("6.- Sabado");
            Console.WriteLine("7.- Domingo");
            opcion = char.Parse(Console.ReadLine());
            if (opcion == '1')
            {
                Console.WriteLine("El niño tiene la actividad de Psicomotricidad");
            }
            else if (opcion == '2')
            {
                Console.WriteLine("El niño tiene la actividad de Natación");
            }
            else if (opcion == '3')
            {
                Console.WriteLine("El niño tiene que ir a mùsica");
            }
            else if (opcion == 4)
            {
                Console.WriteLine("el niño tiene que ir a natación");
            }
            else if (opcion == '5')
            {
                Console.WriteLine("Hoy se descansa");
            }
            else if (opcion == '6')
            {
                Console.WriteLine("Dia Sin Actividades");
            }
            else if (opcion == '7')
            {
                Console.WriteLine("Dia Sin Actividades");
            }
            else {
                Console.WriteLine("la opcion seleccionada es incorrecta");
                    }
            Console.ReadLine();

        }
    }
}
