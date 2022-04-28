using System;

namespace Actividad5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animales = new string[3];
            animales[0] = "Perro";
            animales[1] = "Gato";
            animales[2] = "Pajaro";
            Console.WriteLine("ARRAY 1:"+ animales.Length);


            string[] animales2 = new string[] {"Caballo", "Conejo", "Jirafa" };
            Console.WriteLine("ARRAY 2:" + animales2.Length);


            string[] animales3 = { "Leon", "Tigre", "Oso" };
            Console.WriteLine("ARRAY 2:" + animales3.Length);


        }
    }
}
