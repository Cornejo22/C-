using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesordenaArray
{
    class Program
    {
        static void BorraDeArray(ref int[] array, int posicion)
        {
            int i;

            //array[posicion] = 0;

            for (i = posicion; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            Array.Resize(ref array, array.Length - 1);
        }

        static int[] DesordenaArray(int[] array)
        {
            int[] arrayb = new int[array.Length];
            int random;
            int j = 0;
            Random e = new Random();

            if (array.Length > 0)
            {

                while ((array.Length - 1) > 0)
                {
                    //Console.WriteLine("(1) "+array.Length);                    
                    random = e.Next(0, (array.Length));
                    // Console.WriteLine(random);
                    //  EscribeArray(array);
                    arrayb[j] = array[random];
                    //  EscribeArray(arrayb);
                    BorraDeArray(ref array, random);
                    //  EscribeArray(array);
                    j++;
                    //  Console.WriteLine();
                }
            }
            //Console.WriteLine(j+" ."+array.Length);
            arrayb[j] = array[0];

            return arrayb;
        }

        static void EscribeArray(int[] array)
        {
            int i;
            Console.Write("[");
            for (i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + ",");
            }
            Console.Write(array[i]);
            Console.Write("]");
        }

        static void Main(string[] args)
        {
            int[] array = new int[10] { 1, 2, 3, 4, 17, 5, 7, 8, 9, 10 };
            EscribeArray(array);
            // DesordenaArray(array);
            EscribeArray(DesordenaArray(array));

            Console.ReadKey();

        }
    }
}
