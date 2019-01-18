using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17_RelacionFunciones2
{
    class Program
    {
        static long Factorial(long n1)
        {
            long contador;
            long factorial = 1;

            for (contador = n1; contador >= 1; contador--)
            {
                factorial = factorial * contador;
            }

            return factorial;
        }
        static void Main(string[] args)
        {
            long n1;

            Console.WriteLine("Dime un número : ");
            n1 = long.Parse(Console.ReadLine());

            Console.WriteLine("El factorial de {0}! es {1} ",n1,Factorial(n1));

            Console.ReadKey();
        }
    }
}
