using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RelacionFicherosDirectorios
{
    class Program
    {
        static int CuantosFicheros(string extension)
        {
            int cantidadF = 0;

            string[] ficheros = Directory.GetFiles(".");

            int i;
            for (i = 0; i < ficheros.Length; i++)
            {
                if(Path.GetExtension(ficheros[i]) == extension)
                {
                    cantidadF++;
                }
            }

            return cantidadF;
        }

        static int CuantosFicherosPro(string extension,string ruta)
        {
            int cantidad = 0;

            string[] ficheros = Directory.GetFiles(ruta);

            int i;
            for (i = 0; i < ficheros.Length; i++)
            {
                if (Path.GetExtension(ficheros[i]) == extension)
                {
                    cantidad++;
                }
            }

            return cantidad;
        }

        static void CreaBackup(string fichero)
        {
            string ficheronuevo;
            ficheronuevo = fichero + ".bak";
            if (File.Exists(fichero))
            {
                while (File.Exists(ficheronuevo))
                {
                    ficheronuevo = ficheronuevo + ".bak";
                }
                File.Copy(fichero, ficheronuevo);
            }
        }

        static void RenombraMasivo(string extension, string extension2)
        {

            string[] ficheros = Directory.GetFiles(".");
            string ficheronuevo;
            int i;
            for (i = 0; i < ficheros.Length; i++)
            {
                if (Path.GetExtension(ficheros[i]) == extension)
                {
                    ficheronuevo = Path.ChangeExtension(ficheros[i], extension2);
                    File.Move(ficheros[i], ficheronuevo);
                }
            }
        }
        
        static int CuentaLineasFicheros(string extension)
        {
            int totalL = 0;
            StreamReader sr;

            string[] ficheros = Directory.GetFiles(".");

            int i;
            for (i = 0; i < ficheros.Length; i++)
            {
                if (Path.GetExtension(ficheros[i]) == extension)
                {
                    sr = new StreamReader(ficheros[i]);
                    while (!sr.EndOfStream)
                    {
                        sr.ReadLine();
                        totalL++;
                    }                                    
                }
            }

            return totalL;
        }

        static string FicheroMasGrande()
        {
            string nombreFichero = "";
            
            string[] ficheros = Directory.GetFiles(".");
            long tam = new FileInfo(ficheros[0]).Length;

            int i;
            for (i = 0; i < ficheros.Length; i++)
            {
                long tam2 = new FileInfo(ficheros[i]).Length;
                if (tam2 > tam)
                {
                    nombreFichero = ficheros[i];
                    tam = new FileInfo(ficheros[i]).Length;
                }
            }
                return nombreFichero;
        }

        static void ClasificaFicheros()
        {
            string extensionF;
            List<string> listaN = new List<string>();
            List<string> listaExtra = new List<string>();

            string[] ficheros = Directory.GetFiles(".");

            int i;
            int j;
            int contador = 0;

            for (i = 0; i < ficheros.Length; i++)
            {
                extensionF = Path.GetExtension(ficheros[i]);
                if (!listaN.Contains(extensionF))
                {
                    listaN.Add(extensionF);
                }
                listaExtra.Add(extensionF);
                
            }
            int[] listaC = new int[listaN.Count];
        
            for ( i = 0; i < listaN.Count; i++)
            {
                contador = 0;
                for (j = 0; j < listaExtra.Count; j++)
                {                   
                    if(listaN[i] == listaExtra[j])
                    {
                        contador++;
                    }
                }

                listaC[i] = contador;
            }

            for (i = 0; i < listaN.Count; i++)
            {
                Console.WriteLine("La extension " + listaN[i] + " --> " + listaC[i]);
            }
        }

        static void Main(string[] args)
        {

            string opcion = "-1";

            while(opcion != "0")
            {
                Console.Clear();
                Console.WriteLine("        MENU");
                Console.WriteLine("=====================");
                Console.WriteLine("1º-CuantosFicheros        2º-CuantosFicherosPro");
                Console.WriteLine("3º-CreaBackup             4º-RenombraMasivo");
                Console.WriteLine("5º-CuentaLineasFicheros   6º-FicheroMasGrande");
                Console.WriteLine("7º- ClasificaFicheros");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        {
                            //string[] ficheros = Directory.GetFiles(".");

                            //int i;
                            //for (i = 0; i < ficheros.Length; i++)
                            //{
                            //    Console.WriteLine(Path.GetExtension(ficheros[i]));
                            //}

                            Console.WriteLine("Hay " + CuantosFicheros(".txt")); 
                        }
                        break;

                    case "2":
                        {
                            Console.WriteLine("Hay " + CuantosFicherosPro(".exe","C:\\Windows"));
                        }
                        break;

                    case "3":
                        {
                            CreaBackup("Prueba.txt");
                        }
                        break;

                    case "4":
                        {
                            RenombraMasivo(".texto", ".txt");
                        }
                        break;

                    case "5":
                        {
                            Console.WriteLine("Hay: " + CuentaLineasFicheros(".txt") );
                        }
                        break;

                    case "6":
                        {
                            Console.WriteLine("El fichero más grande es : " + FicheroMasGrande());
                        }
                        break;

                    case "7":
                        {
                            ClasificaFicheros();
                        }
                        break;
                    
                    default:
                        {
                            Console.WriteLine("Error");
                        }
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
