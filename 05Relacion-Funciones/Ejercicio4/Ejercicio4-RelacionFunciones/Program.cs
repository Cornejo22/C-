using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_RelacionFunciones
{
    class Program
    {
        static void ImprimeSerie(int n1, int n2)
        {
            int i;

            if (n1 < n2)
            {
                for (i = n1; i <= n2; i++)
                {
                    if (i == n2)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i + ",");
                    }

                }
            }
            else
            {
                for (i = n1; i >= n2; i--)
                {
                    if (i == n2)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i + ",");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Primer número : ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Segundo número : ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            ImprimeSerie(n1, n2);

            Console.ReadKey();
        }
    }
}
