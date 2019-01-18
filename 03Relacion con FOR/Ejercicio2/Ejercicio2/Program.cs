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
            for (int i = 1; i < 10; i = i + 2)
            {
                Console.Write(" " + i);
            }
            Console.ReadKey();
        }
    }
}
