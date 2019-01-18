using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static string EliminaTags(string cadena)
        {
            return System.Text.RegularExpressions.Regex.Replace(cadena, "<.*?>", String.Empty);
        }

        static string EliminaTags2(string cadena)
        {
            string caD = "" ;
            int i;

            for (i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] == '<')
                {
                    while(cadena[i] != '>')
                    {
                        i++;
                    }
                }
                else
                {
                    caD = caD + cadena[i];
                }
            }

            return caD;
        }

        static void Main(string[] args)
        {
            string cadena = "<p> Esto es texto normal <b>y esto es texto en negrita</b>.</p>";
            string cadena2 = "<p>Test paragraph.</p><!-- Comment --> <a href=#fragment>Other text</a>";
            Console.Write(cadena);
            Console.WriteLine("La cadena sin tags: ");
            Console.WriteLine();
            Console.WriteLine(EliminaTags(cadena2));
            Console.Write(EliminaTags2(cadena));

            Console.ReadKey();
        }
    }
}
