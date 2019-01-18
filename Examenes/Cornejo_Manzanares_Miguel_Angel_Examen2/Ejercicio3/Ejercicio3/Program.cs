using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
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

        static int[] CopiaArrayPro(int[] array)
        {
            int[] arrayb = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                arrayb[i] = array[i];
            }

            return arrayb;
        }

        static int SumaArray(int[] arraya)
        {
            int suma = 0, i;

            for (i = 0; i < arraya.Length; i++)
            {
                suma = suma + arraya[i];
            }

            return suma;
        }

        static bool CompruebaTarjeta(int[] array)
        {
            int i;
            bool devuelve = false;
            int[] arrayb = CopiaArrayPro(array);

            if(arrayb.Length < 16 || arrayb.Length > 16)
            {
                devuelve = false;
            }
            else
            {
                for (i = 0; i < arrayb.Length-1; i++)
                {
                    if (i % 2 == 0)
                    {
                        arrayb[i] = arrayb[i] * 2;
                    }

                    if (arrayb[i] >= 10)
                    {
                        arrayb[i] = arrayb[i] - 9;
                    }
                }               
            }
            
            if(SumaArray(arrayb) % 10 == 0)
            {
                devuelve = true;
            }

            return devuelve;
        }

        static void Main(string[] args)
        {
            int[] array = new int[16] {4,9,2,9,9,9,6,8,6,1,5,0,1,7,5,6};

            EscribeArray(array);
            Console.WriteLine();
            Console.WriteLine(CompruebaTarjeta(array));
            Console.ReadKey();
        }
    }
}
