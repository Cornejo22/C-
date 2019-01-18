using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero,contador,i;
            contador = 0;

            Console.WriteLine("Dime un número : ");
            numero = int.Parse(Console.ReadLine());

            while(numero < 1)
            {
                Console.WriteLine("Dime otro numero : ");
                numero = int.Parse(Console.ReadLine());
            }
            for (i = 1; i <= numero; i++)
            {
                if(numero % i == 0)
                {
                    contador++;
                }
            }

            if(contador == 2)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El número no es primo");
            }

            Console.ReadKey();
        }
    }
}
