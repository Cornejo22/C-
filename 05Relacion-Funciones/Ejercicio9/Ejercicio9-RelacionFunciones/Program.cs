using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9_RelacionFunciones
{
    class Program
    {

        static int MCM(int n1, int n2)
        {
            int i, min;
            int mcd = 1;
            int mcm = 0;

            min = n1;

            for (i = 1; i <= min; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    mcd = i;
                    mcm = (n1 * n2) / mcd;
                }
            }

            return mcm;
        }

        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("Dime un número : ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Dime otro número : ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("El mínimo común múltiplo es : {0}",MCM(n1,n2));

            Console.ReadKey();
        }
    }
}
