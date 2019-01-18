using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12_RelacionFunciones2
{
    class Program
    {
        static double PulgadasACentimetros(double pulgadas)
        {
            double centimetros;

            centimetros = pulgadas * 2.54;

            return centimetros;
        }

        static double CentimetrosAPulgadas(double centimetros)
        {
            double pulgadas;

            pulgadas = centimetros / 2.54;

            return pulgadas;
        }

        static void Main(string[] args)
        {
            double longitud;
            Console.Write("Dime la longitud a convertir : ");
            longitud = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} centimetros a pulgadas : {1} ",longitud,CentimetrosAPulgadas(longitud));
            Console.Write("{0} pulgadas a centimetros : {1} ",longitud,PulgadasACentimetros(longitud));

            Console.ReadKey();
        }
    }
}
