using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11_CeliaVinnas
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int contador;
            int i;

            Console.WriteLine("Dime el primer número : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número : ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                contador = b;
                if (contador % 2 == 0)
                {
                    contador++;                                      
                    for (i = contador; i < a; i = i + 2)
                    {
                        Console.Write(" " + i);
                    }
                }
                else
                {
                    for (i = contador; i < a; i = i + 2)
                    {
                        Console.Write(" " + i);
                    }
                }

            }
            else
            {
                contador = a;
                if (contador % 2 == 0)
                {
                    contador++;
                    for (i = contador; i < b; i = i + 2)
                    {
                        Console.Write(" " + i);
                    }
                }
                else
                {
                    for (i = contador; i < b; i = i + 2)
                    {
                        Console.Write(" " + i);
                    }
                }

            }

            Console.ReadKey();
        }
    }
}
