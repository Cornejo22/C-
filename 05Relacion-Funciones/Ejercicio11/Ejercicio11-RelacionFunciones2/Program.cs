using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11_RelacionFunciones2
{
    class Program
    {
        static int AreaTriangulo(int b, int altura)
        {
            int area;

            area = (b * altura) / 2;

            return area;

        }

        static void Main(string[] args)
        {
            int b, altura;

            Console.Write("La base : ");
            b = int.Parse(Console.ReadLine());

            Console.Write("La altura : ");
            altura = int.Parse(Console.ReadLine());

            Console.Write("El área del triángulo es : {0} ",AreaTriangulo(b,altura));

            Console.ReadKey();
        }
    }
}
