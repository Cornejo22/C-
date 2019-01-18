using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void EscribeArray(int[] array)
        {
            int i;

            Console.Write("[");
            for (i = 0; i < array.Length-1; i++)
            {
                Console.Write(array[i] + ",");
            }
            Console.Write(array[i]);
            Console.Write("]");
        }

        static int[] CopiaArrayPro(int[] array)
        {
            int[] arrayb = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                arrayb[i] = array[i];
            }

            return arrayb;
        }

        static int[] TailArray(int[] array, int n)
        {
            int[] arrayb;
            int i;
            int j = 0;
            int k = array.Length-n;

            if (n > array.Length || n <= 0)
            {
                Console.WriteLine("Error");
                arrayb = CopiaArrayPro(array);
                
            }
            else
            {
                arrayb = new int[n];
                for (i = k; i < array.Length; i++)
                {
                    arrayb[j] = array[k];
                    j++;
                    k++;
                }
            }

            return arrayb;
        }

        static void Main(string[] args)
        {
            int[] array = new int[6] { 1, 2, 3, 4, 5, 6 };
            int n;

            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            EscribeArray(array);
            Console.WriteLine();
            Console.WriteLine();   
            EscribeArray(TailArray(array,n));
            Console.ReadKey();
        }
    }
}
