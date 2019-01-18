using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, min,n1,n2;
            int mcd = 1;
            int mcm = 0;

            Console.WriteLine(" == Mínimo Común Múltiplo == ");
            Console.WriteLine();

            Console.WriteLine("Dime el primer número :  ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número :  ");
            n2 = int.Parse(Console.ReadLine());

            min = n1;

            for (i = 1; i <= min; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    mcd = i;
                    mcm = (n1 * n2) / mcd;

                }
            }

            Console.WriteLine("El mínimo común múltiplo es :  " + mcm);
            Console.ReadKey();
        }
    }
}
