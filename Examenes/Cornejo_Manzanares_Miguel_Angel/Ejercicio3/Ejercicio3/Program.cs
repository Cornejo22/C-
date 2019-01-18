using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static int Maximo(int a,int b, int c)
        {
            int max;

            if(a > b && a > c)
            {
                max = a;
            }
            else
            {
                if(b > c)
                {
                    max = b;
                }
                else
                {
                    max = c;
                }
            }

            return max;
        }

        static int Minimo(int a,int b, int c)
        {
            int min;

            if (a < b && a < c)
            {
                min = a;
            }
            else
            {
                if (b < c)
                {
                    min = b;
                }
                else
                {
                    min = c;
                }
            }

            return min;
        }

        static int Medio(int a,int b, int c)
        {
            int medio;

            if(a > b && a < c)
            {
                medio = a;
            }
            else
            {
                if(b > a && b < c)
                {
                    medio = b;
                }
                else
                {
                    medio = c;
                }
            }

            return medio;
        }

        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Dime el primer número : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Dime el segundo número : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Dime el tercer número : ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Tu máximo es : {0} ",Maximo(a, b, c));
            Console.WriteLine("Tu medio es : {0}",Medio(a, b, c));
            Console.WriteLine("Tu mínimo es : {0}",Minimo(a, b, c));
      

            Console.ReadKey();
        }
    }
}
