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
            int valormaximo = int.MinValue;
            int valorminimo = int.MaxValue;
            int valormedio;
            int contador = 0;
            int numero;
            int suma = 0;
            while (contador < 10)
            {
                Console.WriteLine("Dime el número ");
                numero = int.Parse(Console.ReadLine());

                suma = suma + numero;

                if (numero > valormaximo)
                {
                    valormaximo = numero;
                }
                if (numero < valorminimo)
                {
                    valorminimo = numero;
                }
                
                contador++;
            }
            valormedio = suma / contador;
            Console.WriteLine("El número máximo es : " + valormaximo);
            Console.WriteLine("El número mínimo es : " + valorminimo);
            Console.WriteLine("La media es : " + valormedio);
            Console.ReadKey();
        }
    }
}
