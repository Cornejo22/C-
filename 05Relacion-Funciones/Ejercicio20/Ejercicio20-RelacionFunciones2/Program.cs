using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20_RelacionFunciones2
{
    class Program
    {
        static void ResolucionCamara(ref double x, ref double y, double pix)
        {
          
            double mgpx;
            double finalx;
            double finaly;

            mgpx = pix * 1000000;

            finalx = Math.Floor(Math.Sqrt((mgpx * (x / y))));
            finaly = Math.Floor(Math.Sqrt((mgpx * (y / x))));

            
            x = finalx;
            y = finaly;
        }
        
        static void Main(string[] args)
        {

            double x = 0;
            double y = 0;
            double pix;

            //string variable = "a";

            Console.Write("¿Cuantos pixeles tiene tu camara? ");
            while(double.TryParse(Console.ReadLine(),out pix) == false)
            {
                Console.WriteLine("No escribas cosas raras.Escribe un número");
            }
            Console.WriteLine("Relación de aspecto : ");
            Console.WriteLine();
            Console.WriteLine("Asigna a 'x(horizontal)' un número de ratio");
            while(double.TryParse(Console.ReadLine(),out x) == false)
            {
                Console.WriteLine("No escribas cosas raras.Escribe un número");

            }
            Console.WriteLine("Asigna a 'y(vertical)' un número de ratio");
            while (double.TryParse(Console.ReadLine(), out y) == false)
            {
                Console.WriteLine("No escribas cosas raras.Escribe un número");
            }
            //Console.WriteLine("A: 4:3");
            //Console.Write("B: 16:9 ");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.Write("¿Que opción eliges? ");
            //variable = Console.ReadLine();


            //if(variable == "a" || variable == "A" )
            //{
            //    x = 4;
            //    y = 3;
            //} else
            //{
            //    if (variable == "b" || variable == "B")
            //    {
            //        x = 16;
            //        y = 9;
            //    }
            //}

            ResolucionCamara(ref x, ref y, pix);
            Console.WriteLine();
            Console.WriteLine("Tu resolución es {0} x {1} ",x,y);
            Console.ReadKey();
        }
    }
}
