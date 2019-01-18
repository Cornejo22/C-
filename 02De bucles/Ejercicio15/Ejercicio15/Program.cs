using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int valormaximo = 0;
            int contador = 0;
            int numero;

            while(contador < 10)
            {
                Console.WriteLine("Dime el número ");
                numero = int.Parse(Console.ReadLine());

                if(numero > valormaximo)
                {
                    valormaximo = numero;
                }
                contador++;
            }

            Console.WriteLine("El número máximo es : " + valormaximo);
            Console.ReadKey();
        }
    }
}
