using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10_RelacionFunciones
{
    class Program
    {
        static bool Primo(int n1)
        {
            bool es;
            int i;
            int contador = 0;

            es = false;

            for (i = 1; i <= n1; i++)
            {
                if (n1 % i == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)
            {
                es = true;
            }

            return es;
        }

        static void Main(string[] args)
        {
            int n1;

            Console.Write("Dime un número : ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write(Primo(n1));

            Console.ReadKey();
        }
    }
}
