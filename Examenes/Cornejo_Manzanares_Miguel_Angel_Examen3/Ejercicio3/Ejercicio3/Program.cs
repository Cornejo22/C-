using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static string OrdenaPalabrasComas(string cadena)
        {
            int i;
            string min = "";
            string caD = "";    
            List<string> lista = new List<string>();
            string[] trozos = cadena.Split(',');
            lista.AddRange(trozos);

            for (i = 0; i < lista.Count; i++)
            {
                min = lista.Min();
                lista.Remove(min);

                if(i == lista.Count)
                {
                    caD = caD + min;
                }
                else
                {
                    caD = caD + min + ",";
                }
             
                i--;
            }
            
            return caD;
        }
        static void Main(string[] args)
        {
            string cadena = "hola,don,pepito,pasó,usted,ya,por,casa";
            Console.WriteLine(cadena);          
            Console.Write(OrdenaPalabrasComas(cadena));

            Console.ReadKey();
        }
    }
}
