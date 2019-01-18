using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int i = 0;

            while (i <= 10)
            {
                Console.Write(" " + n1);
                n1 = n1 + 2;
                i++;
            }
            Console.ReadKey();
        }
    }
}
