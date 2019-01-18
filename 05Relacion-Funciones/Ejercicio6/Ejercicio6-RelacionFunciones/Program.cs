using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_RelacionFunciones
{
    class Program
    {
        static int Max(int n1, int n2)
        {
            int mayor;

            if (n1 > n2)
            {
                mayor = n1;
            }
            else
            {
                mayor = n2;
            }

            return mayor;
        }

        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Dime un número : ");
            n1 = int.Parse(Console.ReadLine());
            
            Console.Write("Dime otro número : ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("El mayor es : {0}",Max(n1,n2));

            Console.ReadKey();
        }
    }
}
