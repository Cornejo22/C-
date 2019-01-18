using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, mcd,n1,n2;

            Console.WriteLine("== Máximo Común Divisor ==");
            Console.WriteLine();

            Console.WriteLine(" Dime el primer número : ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Dime el segundo número : ");
            n2 = int.Parse(Console.ReadLine());

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

            Console.WriteLine("El máximo común divisor es : {0}  ", mcd);

            Console.ReadKey();
        }
    }
}
