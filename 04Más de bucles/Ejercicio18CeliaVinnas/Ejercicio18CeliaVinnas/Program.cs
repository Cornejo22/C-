using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18CeliaVinnas
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, contador;

            contador = 0;

            for (i = 2; i <= 1000; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contador = contador + 1;
                    }
                }
                if(contador == 2)
                {
                    Console.WriteLine(i);
                }

                contador = 0;
            }

            Console.ReadKey();
        }
    }
}
