using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double cantidaddinero;
            string tipo_moneda;
            double total;

            Console.WriteLine("Dime la cantidad ");
            cantidaddinero = double.Parse(Console.ReadLine());

            Console.WriteLine("Dime el tipo de moneda(pesetas o euros) ");
            tipo_moneda = Console.ReadLine();

            if(tipo_moneda == "euros")
            {
                total = cantidaddinero * 166.386;
                Console.WriteLine("Tu cantidad es : " + total + " pesetas");
            }
            if(tipo_moneda == "pesetas")
            {
                total = cantidaddinero / 166.386;
                Console.WriteLine("Tu cantidad es " + total + " euros");
            }

            Console.ReadKey();
        }
    }
}
