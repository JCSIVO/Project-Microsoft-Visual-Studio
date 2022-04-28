using System;

namespace Actividad5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] numero = new int [] { 1, 8, 23, 15, 100, 48 };
            Array.Sort(numero);
            for(i = 0; i<numero.Length; i++)
            {
                Console.WriteLine(numero[i].ToString());
            }
            int inicio = 0, final = 5, mitad = 0, num;
            bool encontrar = false;
            Console.WriteLine("introduce un numero");
            num = int.Parse(Console.ReadLine());
            while (inicio <= final && encontrar == false)
            {
                mitad = (inicio + final) / 2;
                if (numero[mitad] == num)
                    encontrar = true;
                else if (numero[mitad] > num)
                    final = mitad - 1;
                else inicio = mitad + 1; 
            }
            if (encontrar== false)
            {
                Console.WriteLine("El elemento no esta");
            } else
            {
                Console.WriteLine("El elemento esta y se encuentra en la posicion"+ mitad + 1);
            }
        }
    }
}
