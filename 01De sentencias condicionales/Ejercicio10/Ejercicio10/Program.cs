using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int mayor;
            int menor;
            int mediano;

            Console.WriteLine("Dime el primer número : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el tercer número : ");
            c = int.Parse(Console.ReadLine());

            if(a > b)
            {
                if(a > c)
                {
                    mayor = a;
                    if(b > c)
                    {
                        mediano = b;
                        menor = c;
                    }
                    else
                    {
                        mediano = c;
                        menor = b;
                    }
                }
                else
                {
                    mayor = c;
                    mediano = a;
                    menor = b;
                }
            }
            else
            {
                if(b > c)
                {
                    mayor = b;
                    if(a > c)
                    {
                        mediano = a;
                        menor = c;
                    }
                    else
                    {
                        mediano = c;
                        menor = a;
                    }
                }
                else
                {
                    mayor = c;
                    mediano = b;
                    menor = a;
                }
            }

            Console.WriteLine("El mayor es " + mayor);
            Console.WriteLine("El menor es " + menor);
            Console.WriteLine("El mediano es " + mediano);
            Console.ReadKey();
        }
    }
}
