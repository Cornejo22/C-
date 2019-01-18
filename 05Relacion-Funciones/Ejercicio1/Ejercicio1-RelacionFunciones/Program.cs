using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_RelacionFunciones
{
    class Program
    {
        static bool Par(int n1)
        {
            bool devuelve;

            devuelve = false;

            if (n1 % 2 == 0)
            {
                devuelve = true;
            }

            return devuelve;
        }

        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Dime el número : ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine(Par(n1));

            Console.ReadKey();
        }
    }
}
