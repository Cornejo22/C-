using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8_RelacionFunciones
{
    class Program
    {
        static int MCD(int n1, int n2)
        {
            int mcd, i;
            i = n1;
            mcd = 0;

            while (i >= 1)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    mcd = i;
                    break;
                }
                i--;
            }

            return mcd;
        }

        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Dime un número : ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Dime otro número : ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("El máximo común divisor : {0} ",MCD(n1,n2));

            Console.ReadKey();
        }
    }
}
