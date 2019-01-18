using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {          
            int numero;
            int numero2 = 0;
            int cuantos = 1;
            double media = 0;

            Console.WriteLine("Dime número : ");
            numero = int.Parse(Console.ReadLine());
            numero2 = numero2 + numero;

            while(numero >= 0)
            {                            
                Console.WriteLine("Dime número : ");
                numero = int.Parse(Console.ReadLine());
                if(numero != -1)
                {
                    numero2 = numero2 + numero;
                    cuantos++;
                }                               
            }

            media = numero2 / cuantos;

            Console.WriteLine(media);
            
            Console.ReadKey();
        }
    }
}
