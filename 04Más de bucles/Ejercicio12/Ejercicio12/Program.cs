using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int i = 1;
            while (contador < 10)
            {
                if ((i % 2 != 0) && (i % 3 != 0))
                {
                    Console.WriteLine(i);
                    contador = contador + 1;
                }
                i++;
            }

            Console.ReadKey();
        }
    }
}
