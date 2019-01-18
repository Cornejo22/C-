using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7_RelacionFunciones
{
    class Program
    {
        static int Min(int n1, int n2)
        {
            int menor;

            if (n1 < n2)
            {
                menor = n1;
            }
            else
            {
                menor = n2;
            }

            return menor;
        }

        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Dime un número : ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Dime otro número : ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("El menor es : {0} ",Min(n1,n2));

            Console.ReadKey();
        }
    }
}
