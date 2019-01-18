using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;

            while (n1 <= 10)
            {
                Console.Write(" " + n1);
                n1 = n1 + 2;
            }

            Console.ReadKey();
        }
    }
}
