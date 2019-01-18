using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultado;

            double a;
            double b;
            double c;

            Console.WriteLine("Dime el primer número : ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número : ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Dime el tercer número : ");
            c = double.Parse(Console.ReadLine());

            double bnegativa = b * -1;
            double balcuadrado = b * b;
            double terceravariable = -4 * a * c;
            double cuartavariable = 2 * a;
            double delta = balcuadrado + terceravariable;

            if(delta > 0)// if delta es menor que 0 no tiene solucion y if raiz == 0, solo tiene una solucion x1 = -b/(2*a) y si es mayor que 0 tiene dos soluciones
            {
                
            }

            double quintavariable = Math.Sqrt(balcuadrado + terceravariable);

            double sextavariable = (bnegativa + quintavariable) / cuartavariable;
            double septimavariable = (bnegativa - quintavariable) / cuartavariable;

            resultado = "Tu primer resultado : " + sextavariable.ToString() + "\nTu segundo resultado : " + septimavariable.ToString();

            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
