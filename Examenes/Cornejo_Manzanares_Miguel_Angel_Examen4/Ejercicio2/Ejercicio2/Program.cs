using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static bool Detecta5(int[] array)
        {
            bool devuelve = false;
            int i;
            int contador = 1;
            for (i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    contador++;
                }
            }          

            if(contador >= 5)
            {
                devuelve = true;
            }

            return devuelve;
        }

        static void Main(string[] args)
        {
            int[] array = new int[7] { 1, 1, 1, 1,3, 2,4 };
            int[] array2 = new int[8] { 1, 1, 1, 1, 1 ,3, 2, 4};
            Console.WriteLine(Detecta5(array));
            Console.Write(Detecta5(array2));

            Console.ReadKey();
        }
    }
}
