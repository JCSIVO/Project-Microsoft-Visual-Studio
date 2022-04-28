using System;

namespace Actividad5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alumno = new string[] { "Fran", "Blanca", "Rocio", "Pepe" };
            int [] nota = new int [4];
            int[] nota2 = new int[4];
            int media = 0;
            int notamayor, aux;
            Console.WriteLine("Introduce la nota de:");
            for (int i=0; i<=3; i++)
            {
                Console.WriteLine(alumno[i]);
                Console.Write("\n");
                nota[i] = int.Parse(Console.ReadLine());
                nota2[i]=int.Parse(Console.ReadLine());
                Console.WriteLine("la media es");
                media = (nota[i] + nota2[i]) / 2;
                Console.WriteLine(media);
            
            }
            Console.WriteLine("Nota ordenadas de mayor a menor");
            for (int i = 0; i < 4 - 1; i++)
            {
                notamayor = i;
                for (int j = i + 1; j < 4; j++)
                {
                    if (nota[j] > nota[notamayor])
                    {
                        notamayor = j;
                    }
                }
                if (i != notamayor)
                {
                    aux = nota[i];
                    nota[i] = nota[notamayor];
                    nota[notamayor] = aux;

                }
            }

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(alumno[i]);
                Console.Write("-");
                Console.Write(nota[i]);
                Console.Write("\n");
            }
            Console.ReadKey();
            
        }
    }
}
