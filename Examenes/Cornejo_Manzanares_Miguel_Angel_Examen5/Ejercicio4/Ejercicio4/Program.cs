using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio4
{
    class Program
    {
        static void EstadisticasNBA()
        {
            string[] ficheros = Directory.GetFiles(".");
            
            string nombreF = "";

            for (int i = 0; i < ficheros.Length; i++)
            {
                int totalPart = 0;
                double puntos = 0;
                double media;
                if (Path.GetExtension(ficheros[i]) == ".stat")
                {
                    FileStream fs = new FileStream(ficheros[i], FileMode.Open);
                    BinaryReader br = new BinaryReader(fs);

                    nombreF = Path.GetFileName(ficheros[i]);
                    int pos = nombreF.IndexOf(".");
                    nombreF = nombreF.Substring(0, pos);
                    while (fs.Position < fs.Length)
                    {
                        int numero = br.ReadInt32();
                        puntos = puntos + numero;
                        totalPart++;
                    }

                    media = puntos / totalPart;
                    Console.WriteLine(nombreF + " " + Math.Round(media, 2));
                    br.Close();
                    fs.Close();
                }
            }
        }            
        
        static void Main(string[] args)
        {
            EstadisticasNBA();
            Console.ReadKey();
        }
    }
}
