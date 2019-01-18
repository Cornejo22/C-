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
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.Write(" " + n1);
                n1 = n1 + 2;
            }

            Console.ReadKey();
        }
    }
}
