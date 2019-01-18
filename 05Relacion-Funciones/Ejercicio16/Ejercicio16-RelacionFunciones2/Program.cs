using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16_RelacionFunciones2
{
    class Program
    {
        static int Elevado(int a,int b)
        {
            int numero = a;
            int i;

            for (i = 1; i < b; i++)
            {
                numero = numero * a;
            }

            return numero;
        }
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Dime el número para la base : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el número para el exponente : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Su potencia de {0} elevado a {1} : {2}",a,b, Elevado(a,b));

            Console.ReadKey();
        }
    }
}
