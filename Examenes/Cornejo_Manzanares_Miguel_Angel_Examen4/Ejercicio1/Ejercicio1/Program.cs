using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static int[,] TablaMultiplicarBi()
        {
            int[,] array = new int[10, 10];
            int i;
            int j = 1;
            for (i = 0; i < 10; i++)
            {
                array[i, 0] = j;
                array[0, i] = j;
                j++;
            }

            for (i = 1; i < array.GetLength(0); i++)
            {
                for (j = 1; j < array.GetLength(1); j++)
                {
                    array[i, j] = array[i, 0] * array[j, 0];
                }
            }

            return array;
        }

        static void EscribeArrayBi(int[,] arraybidi)
        {
            int i, j;

            for (i = 0; i < arraybidi.GetLength(0); i++)
            {
                for (j = 0; j < arraybidi.GetLength(1); j++)
                {
                    Console.Write(arraybidi[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            EscribeArrayBi(TablaMultiplicarBi());

            Console.ReadKey();
        }
    }
}
