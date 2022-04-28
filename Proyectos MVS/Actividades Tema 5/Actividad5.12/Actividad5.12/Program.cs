using System;

namespace Actividad5._12
{
    class Program
    {
        public static int menu()
        {
            int opcion;
            Console.WriteLine("1. Insertar las notas de la asignatura seleccionada");
            Console.WriteLine("2. Insertar todas las notas");
            Console.WriteLine("3. Calcular la nota media de la asignatura seleccionada");
            Console.WriteLine("4. Ordenadar asignaturas de forma ascendente");
            Console.WriteLine("5. Estadística");
            Console.WriteLine("6. Salir");
            Console.WriteLine("Escoge una de las opciones");
            opcion = int.Parse(Console.ReadLine());
            return opcion;
        }
        static void inicialiar (int [,] notas)
        {
            //double[,] notas = new double[3, 15];
            const int filas = 3;
            const int columnas = 15;
            
            Console.WriteLine("Escribe un numero y pulsa enter hasta que aparezc el menu");
            for (int i = 0; i < filas; i++)
            {
                for ( int j =0; j< columnas; j++)
                {
                    notas[i,j] = int.Parse(Console.ReadLine());
                }
            }

        }
        public static void Ingresar()
        {
            int[,] mat;
            int opcion;
            mat = new int[3, 15];
            Console.WriteLine("De de cual asignatura quieres agregar la nota");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        Console.Write("Ingrese la nota[" + (i + 1) + "," + (j + 1) + "]:");
                        string linea;
                        linea = Console.ReadLine();
                        mat[i, j] = int.Parse(linea);
                    }
                }
            } else if (opcion == 2)
            {
                for (int i = 1; i < 3; i++)
                {
                    for (int j = 1; j < 15; j++)
                    {
                        Console.Write("Ingrese la nota[" + (i + 1) + "," + (j + 1) + "]:");
                        string linea;
                        linea = Console.ReadLine();
                        mat[i, j] = int.Parse(linea);
                    }
                }
            } else
            {
                for (int i = 2; i < 3; i++)
                {
                    for (int j = 2; j < 15; j++)
                    {
                        Console.Write("Ingrese la nota[" + (i + 1) + "," + (j + 1) + "]:");
                        string linea;
                        linea = Console.ReadLine();
                        mat[i, j] = int.Parse(linea);
                    }
                }
            }
            
        }
        public static void todas()
        {
            int[,] mat;
            mat = new int[3, 15];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Console.Write("Ingrese la nota[" + (i + 1) + "," + (j + 1) + "]:");
                    string linea;
                    linea = Console.ReadLine();
                    mat[i, j] = int.Parse(linea);
                }
        }   }
        public static void nota_media()
        {
            int  [,] mat;
            mat = new int[0,0];
            int opcion;
            

            Console.WriteLine("De cual asignatura quieres la media");
            opcion = int.Parse(Console.ReadLine());
            int media;
            //media = promedio / 15;
            if (opcion == 1)
            {
                //mat = todas();
                //media 
                Console.WriteLine("La nota media de la Asignatura 1:");
                //Console.WriteLine(media);
            }
            else if (opcion == 2)
            {
                promedio = linea + mat[1, 1] + mat[1, 2] + mat[1, 3] +
                    mat[1, 4] + mat[1, 5] + mat[1, 6] + mat[1, 7] + mat[1, 8] + mat[1, 9] + mat[1, 10] +
                    mat[1, 11] + mat[1, 12] + mat[1, 13] + mat[1, 14] ;
                media = promedio / 15;
                Console.WriteLine("La nota media de la Asignatura 2:");
                Console.WriteLine(media);
            }
            else
            {
                media = (mat[2, 0] + mat[2, 1] + mat[2, 2] + mat[2, 3] +
                    mat[2, 4] + mat[2, 5] + mat[2, 6] + mat[2, 7] + mat[2, 8] + mat[2, 9] + mat[2, 10] +
                    mat[2, 11] + mat[2, 12] + mat[2, 13] + mat[2, 14] / 15);
                Console.WriteLine("La nota media de la Asignatura 3:");
                Console.WriteLine(media);
            }
        }
        public static void orden()
        {
            int []mat;
            mat = new int[3];
            int j;
            int aux;
            for (int i = 1; i< 3; i++)
            {
                j = i;
                aux = mat[i];
                while (j > 0 && aux < mat[j - 1])
                {
                    j--;
                }
                mat[j] = aux;
            }
        }
        static void Main(string[] args)
        {
            int opcion;
            int num;
            Console.WriteLine("Probando el softaware de las notas");
            opcion = menu();
            num = opcion;
            if (opcion == 1)
            {
                 Ingresar();
            } else if (opcion == 2)
            {
                todas();
            }  else if (opcion ==3)
            {
                nota_media();
            } else if (opcion == 4)
            {
                orden();
            }
        }
    }
}
