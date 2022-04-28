using System;

namespace Actividad4._4
{
    class Program
    {
         public static char Voc(char op, char a, char e, char i, char o, char u)
        {
            //Console.WriteLine("Introduce un caracter");
            //op = (char)(Console.Read());
            

                if (op == 'a' || op == 'e' || op == 'i' || op == 'o' || op == 'u')
                {

                    Console.WriteLine("Esto es una vocal");
                    //Console.WriteLine(op);
                    return op;
                }
                else
                { 
                    Console.WriteLine("Esto es una consonante");
                    //Console.WriteLine(op);
                    return op;
                }
           
         }

        public static void Main()
        {

            
            Console.WriteLine("Introduce un caracter");
            char op;
            
            op = (char)(Console.Read());
            char a;
            a = (char)(Console.Read());
            char e;
            e = (char)(Console.Read());
            char i;
            i = (char)(Console.Read());
            char o ;
            o = (char)(Console.Read());
            char u;
            u = (char)(Console.Read());
            //char op;
            //op = (char)(Console.Read());*/
            char resultado;
            //resultado = (char)(Console.Read());
            resultado = Voc(op,a,e,i,o,u);
            Console.WriteLine("El caracter introducido es:");
            Console.WriteLine(resultado);
            
        }
    }
}
