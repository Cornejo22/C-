using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int contador;

            Console.WriteLine("Dime el primer número : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número : ");
            b = int.Parse(Console.ReadLine());

            if(a > b)
            {
                contador = b;
                if(contador % 2 == 0)
                {
                    contador++;
                    while (contador < a)
                    {
                        Console.Write(" " + contador);
                        contador = contador + 2;
                    }
                }
                else
                {
                    while (contador < a)
                    {
                        Console.Write(" " + contador);
                        contador = contador + 2;
                    }
                }
                
            }
            else
            {
                contador = a;
                if(contador % 2 == 0)
                {
                    contador++;
                    while (contador < b)
                    {
                        Console.Write(" " + contador);
                        contador = contador + 2;
                    }
                }
                else
                {
                    while (contador < b)
                    {
                        Console.Write(" " + contador);
                        contador = contador + 2;
                    }
                }
                
            }

            Console.ReadKey();
        }
    }
}
