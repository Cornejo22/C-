using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio3
{
    class Program
    {
        static int PalabrasDistintas(string fichero)
        {
            StreamReader sr = new StreamReader(fichero, Encoding.Default);
            int nPalabrasDistintas = 0;
            int i;
            List<string> listaPalabras = new List<string>();

            string linea = "";

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                linea = QuitaPuntuacion(linea);
                linea = linea.ToLower();

                string[] palabras = linea.Split(' ');

                for (i = 0; i < palabras.Length; i++)
                {
                    if (palabras[i] != "")
                    {
                        listaPalabras.Add(palabras[i]);
                    }
                }
            }

            sr.Close();

            List<string> pal = new List<string>();

            for (i = 0; i < listaPalabras.Count; i++)
            {
                string palabra = listaPalabras[i];

                if (pal.Contains(palabra))
                {
                    int pos = pal.IndexOf(palabra);
                }
                else
                {
                    pal.Add(palabra);
                }
            }

            nPalabrasDistintas = pal.Count;

            return nPalabrasDistintas;
        }

        static string QuitaPuntuacion(string linea)
        {
            int i;
            string resultado = "";

            for (i = 0; i < linea.Length; i++)
            {
                if (linea[i] == ' ' || char.IsLetter(linea[i]))
                {
                    resultado = resultado + linea[i];
                }
            }

            return resultado;
        }

        static void Main(string[] args)
        {
            Console.Write(PalabrasDistintas("quijote.txt"));
            Console.ReadKey();
        }
    }
}
