using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
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

        static void IntercambiaParImpar(int[] array)
        {           
            int i;
            int j = 1;
            int k = 0;
            int aux;          
           
            if(array.Length % 2 == 0)
            {
                for (i = 0; i < array.Length-1; i = i + 2)
                {
                    aux = array[k];
                    array[i] = array[j];
                    j = j + 2;
                    array[i + 1] = aux;
                    k = k + 2;
                }
               
            }
            else
            {
                Console.WriteLine("Error");               
            }

        }
        static void Main(string[] args)
        {

            int[] arrayA = new int[6] { 7,1,4,6,9,5};

            EscribeArray(arrayA);
            IntercambiaParImpar(arrayA);
            EscribeArray(arrayA);

            Console.ReadKey();
        }
    }
}
