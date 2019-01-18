using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15CeliaVinnas
{
    class Program
    {
        static void Main(string[] args)
        {
            int valormaximo = 0;
            int contador;
            int numero;

            for(contador = 0; contador < 10;contador++)
            {
                Console.WriteLine("Dime el número ");
                numero = int.Parse(Console.ReadLine());

                if (numero > valormaximo)
                {
                    valormaximo = numero;
                }              
            }

            Console.WriteLine("El número máximo es : " + valormaximo);
            Console.ReadKey();
        }
    }
}
