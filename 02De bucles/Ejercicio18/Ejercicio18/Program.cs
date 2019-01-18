using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisores;
            int i;
            int j;
            for (i = 2; i <= 1000; i++)
            {
                divisores = 0;
                Console.WriteLine("Tu número " + i);
                for (j = i; j >= i; j--)
                {
                    if (j % i == 0)
                    {
                        divisores = divisores + 1;
                    }
                    if (divisores == 2)
                    {
                        Console.WriteLine(i);
                    }
                }                     
            }

            Console.ReadKey();
        }
    }
}
