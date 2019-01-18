using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
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

        static bool[] CalculaNPrimos(int numero)
        {
            bool[] arrayBool = new bool[numero + 1];
            int i = 0;

            while(i < numero)
            {
                if(Primo(i) == true)
                {
                    arrayBool[i] = true;
                }
                else
                {
                    arrayBool[i] = false;
                }
                i++;
            }

            return arrayBool;
        }

        static void EscribeArray(bool[] arrayB)
        {
            int i;
            Console.Write("[");
            for (i = 0; i < arrayB.Length-1; i++)
            {
                Console.Write(arrayB[i] + ",");
            }
            Console.Write(arrayB[i]);
            Console.Write("]");
        }

        static void Main(string[] args)
        {
            EscribeArray(CalculaNPrimos(15));

            Console.ReadKey();
        }
    }
}
