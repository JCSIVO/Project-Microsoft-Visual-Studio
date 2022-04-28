using System;
using System.IO;

namespace Actividad10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string fichero =null;
            Console.WriteLine("¿cual es el nombre de tu fichero?");
            fichero = Console.ReadLine();
            string path = @"/Users/joseconejerosivo/Proyectos VS/Actividades Tema 10/Actividad10.3\" + fichero + ".txt";
            FileStream fs = File.Create(path);
        }
    }
}
