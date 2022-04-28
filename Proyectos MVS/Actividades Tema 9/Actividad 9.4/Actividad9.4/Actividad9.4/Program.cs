using System;

namespace Actividad9
{
    class FiguraGeometrica
    {
        double lado1; //Posicion del objeto
        double lado2; //posicion del objeto
        public FiguraGeometrica(double lado1, double lado2)
        {
            
            this.lado1 = lado1;
            this.lado2 = lado2;
        }
    }
     class Rectangulo //: FiguraGeometrica
    {
        double lado1;
        double lado2;
        public Rectangulo(double lado1, double lado2) //: base( lado1, lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }
        public  double area
        {
            get { return lado1 * lado2; }
                 //lado1 * lado2;
        }

        public double perimetro()
        {
            return (2 * lado1) + (2 * lado2);
        }
        // area bxh  y perimetro 2b+2h

    }
    class Cuadrado //: FiguraGeometrica
    {
        // area axa  y perimetro 4xa
        double lado1;
        public Cuadrado(double lado1) //: base(lado1, lado1)
        {
            this.lado1 = lado1;
        }
        public double area
        {
          get { return lado1 * lado1; }

        }
        public double perimetro()
        {
            return 4 * lado1;
        }
    }
    class Circulo //: FiguraGeometrica
    {
        // area pixRadio al cuadrado  perimetro pi x diagonal ó 2xpixRadio
        double lado1;
        public Circulo(double lado1)// : base(lado1, lado1)
        {
            this.lado1 = lado1;
        }
        public double area
        {
            get { return lado1 * lado1 * 3.1415; }
        }
        public double perimetro()
        {
            return 2 * (3.1415 * lado1);
        }
    }
    class Rombo //: FiguraGeometrica
    {
        // area diagonal grande x diagonal pequeña dividida entre dos  perimetro 4xa
        double lado1;
        double lado2;
        public Rombo(double lado1, double lado2)// : base(lado1, lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }
        public double area
        {
          get{ return (lado1 * lado2) / 2; }
        }
        public double perimetro()
        {
            return 4 * lado2;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] nombres;
            string[] areas;
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            double areas1 = 0;
            double areas2 = 0;
            double areas3 = 0;
            double areas4 = 0;
            int opcion;
            double lado1;
            double lado2;
            do
            {
                Console.WriteLine("Escoge una figura");
                Console.WriteLine("1.rectangulo");
                Console.WriteLine("2.Cuadrado");
                Console.WriteLine("3.circulo");
                Console.WriteLine("4.rombo");
                Console.WriteLine("5. Salir");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("Introduce uno de los lado del rectangulo");
                    lado1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduce el otro  lado del rectangulo");
                    lado2 = double.Parse(Console.ReadLine());
                    Rectangulo rec = new Rectangulo(lado1, lado2);
                    Console.WriteLine("El area del rectangulo es:" + rec.area);
                    Console.WriteLine("El perimetro del rectangulo es:" + rec.perimetro());
                    nombres = new string[num1];
                    num1++;
                    areas1 = rec.area;
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Introduce un lado del cuadrado");
                    lado1 = double.Parse(Console.ReadLine());

                    Cuadrado cua = new Cuadrado(lado1);
                    Console.WriteLine("el area del cuadrado es:" + cua.area);
                    Console.WriteLine("El perimetro del cudrado es:" + cua.perimetro());
                    nombres = new string[num2];
                    num2++;
                    areas2 = cua.area;
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Introduce el radio del circulo");
                    lado1 = double.Parse(Console.ReadLine());

                    Circulo cir = new Circulo(lado1);
                    Console.WriteLine("el area del circulo es:" + cir.area);
                    Console.WriteLine("El perimetro del circulo es:" + cir.perimetro());
                    nombres = new string[num3];
                    num3++;
                    areas3 = cir.area;
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Introduce uno de los lado del rectangulo");
                    lado1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduce el otro  lado del rectangulo");
                    lado2 = double.Parse(Console.ReadLine());
                    Rombo rom = new Rombo(lado1, lado2);
                    Console.WriteLine("El area del rombo es:" + rom.area);
                    Console.WriteLine("El perimetro del rombo es:" + rom.perimetro());
                    nombres = new string[num4];
                    num4++;
                    areas4 = rom.area;
                }
            } while (opcion != 5);
            Console.WriteLine(num1 + "rectangulo" + num2 + "cuadrado" + num3 + "circulo" + num4 + "rombo");
            Console.WriteLine(areas1 + "rectangulo" + areas2 + "cuadrado" + areas3 + "circulo" + areas4 + "rombo");
        }
    }
}

