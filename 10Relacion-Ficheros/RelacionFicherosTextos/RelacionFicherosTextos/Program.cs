using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RelacionFicherosTextos
{
    class Program
    {
        /// <summary>
        ///  Le pasas un nombre de fichero y 
        ///  te crea un fichero con ese nombre que 
        ///  contiene 10 números aleatorios en diferentes líneas. 
        /// </summary>
        /// <param name="fichero">Cadena</param>
        static void EscribeFicheroNumRandom10(string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);
            Random nr = new Random();

            int numero;
            int i = 0;
            while (i < 10)
            {
                numero = nr.Next(1, 11); ;
                sw.WriteLine(numero);
                i++;
            }
            sw.Close();
        }

        /// <summary>
        ///  Le pasas un fichero con 10 líneas 
        ///  (que debe contener enteros en diferentes líneas, 
        ///  como el del ejercicio anterior) y 
        ///  te devuelve la suma de todos los números 
        ///  contenidos en el fichero. 
        /// </summary>
        /// <param name="fichero">Cadena</param>
        /// <returns>La suma</returns>
        static int SumaFicheroInt10(string fichero)
        {
            StreamReader sr = new StreamReader(fichero,Encoding.Default);

            int suma = 0;

            while (sr.EndOfStream == false)
            {                
                suma = suma + int.Parse(sr.ReadLine());
            }

            sr.Close();

            return suma;
        }

        /// <summary>
        /// le pasas un nombre de fichero y un entero y 
        /// te escribe tantos números aleatorios 
        /// como le hayas dicho en un fichero de texto.
        /// </summary>
        /// <param name="fichero">Cadena</param>
        /// <param name="numero">Variable Int</param>
        static void EscribeFicheroNumRandom(string fichero,int numero)
        {
            StreamWriter sw = new StreamWriter(fichero);
            int i = 0;
            int numeroal;
            Random r = new Random();
            while(i < numero)
            {
                numeroal = r.Next(1, 11);
                sw.WriteLine(numeroal);
                i++;
            }

            sw.Close();
        }

        /// <summary>
        ///  Le pasas un nombre de fichero y te devuelve 
        ///  un entero resultante de sumar todos 
        ///  los números contenidos en el fichero 
        ///  (que puede tener tantas líneas como haga falta).
        /// </summary>
        /// <param name="fichero">Cadena</param>
        /// <returns>La suma</returns>
        static int SumaFicheroInt(string fichero)
        {
            int suma = 0;
            StreamReader sr = new StreamReader(fichero, Encoding.Default);

            while(sr.EndOfStream == false)
            {
                suma = suma + int.Parse(sr.ReadLine());
            }

            sr.Close();
            return suma;
        }

        /// <summary>
        ///  Le pasas un nombre de fichero. 
        ///  La función ira pidiendo al usuario que
        ///  escriba líneas de texto, que se irán 
        ///  guardando en el fichero, 
        ///  hasta que introduzca una línea en blanco (“”). 
        /// </summary>
        /// <param name="fichero">Cadena</param>
        static void EscribeFicheroTexto(string fichero)
        {
            string linea = " ";
            StreamWriter sw = new StreamWriter(fichero);

            while(linea != "")
            {
                Console.WriteLine(" Dime la frase : ");
                linea = Console.ReadLine();
                sw.WriteLine(linea);
            }

            sw.Close();
           
        }

        /// <summary>
        ///  Le pasas un nombre de fichero y te pone el contenido de fichero por pantalla.
        /// </summary>
        /// <param name="fichero">Cadena</param>
        static void LeeFicheroTexto(string fichero)
        {
            StreamReader sr = new StreamReader(fichero,Encoding.Default);
            string linea = "";

            while(sr.EndOfStream == false)
            {
                linea = sr.ReadLine();

                Console.WriteLine(linea);
            }

            sr.Close();

        }

        /// <summary>
        ///  Le pasas dos nombres de fichero y 
        ///  copias el contenido del primer fichero en el segundo
        /// </summary>
        /// <param name="fichero">Cadena</param>
        /// <param name="fichero2">Cadena</param>
        static void CopiaFicheroTexto(string fichero,string fichero2)
        {
            StreamReader sr = new StreamReader(fichero, Encoding.Default);
            StreamWriter sw2 = new StreamWriter(fichero2);
            string linea;

            while (sr.EndOfStream == false)
            {
                linea = sr.ReadLine();
                sw2.WriteLine(linea);
            }

            sr.Close();
            sw2.Close();

        }

        /// <summary>
        /// Le pasamos un cadena y nos la devuelve invertida(de detrás para delante, vamos).
        /// </summary>
        /// <param name="cadena">Variable tipo String</param>
        /// <returns>Variable tipo String</returns>
        static string InvierteCadena(string cadena)
        {
            string caD = "";
            int i;

            for (i = cadena.Length - 1; i >= 0; i--)
            {
                caD = caD + cadena[i];
            }

            return caD;
        }

        /// <summary>
        ///  La pasas dos nombres de fichero y 
        ///  te copia las líneas del primer fichero 
        ///  al segundo ficheros pero invertidas
        /// </summary>
        /// <param name="fichero">Cadena</param>
        /// <param name="fichero2">Cadena</param>
        static void InvierteLineasFichero(string fichero,string fichero2)
        {
            StreamReader sr = new StreamReader(fichero, Encoding.Default);
            StreamWriter sw2 = new StreamWriter(fichero2);
            string linea;

            while (sr.EndOfStream == false)
            {
                linea = sr.ReadLine();
                sw2.WriteLine(InvierteCadena(linea));
            }

            sr.Close();
            sw2.Close();
        }

        /// <summary>
        ///  Le pasas un nombre de fichero y 
        ///  te invierte el contenido del fichero
        /// </summary>
        /// <param name="fichero">Cadena</param>
        static void InvierteFicheroTexto(string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            
            List<string> listacadenas = new List<string>();

            string linea;
            while(sr.EndOfStream == false)
            {
                linea = sr.ReadLine();
                listacadenas.Add(linea);
            }
           
            sr.Close();
            int i;
            listacadenas.Reverse();

            StreamWriter sw = new StreamWriter(fichero);
            for (i = 0; i < listacadenas.Count; i++)
            {
                linea = listacadenas[i];
                sw.WriteLine(linea);
            }
            
            sw.Close();
        }

        /// <summary>
        ///  Le pasas dos nombres de fichero. 
        ///  Te cogerá el primer fichero (que contendrá frases) 
        ///  y te separará las palabras, 
        ///  que escribirá en el segundo fichero
        /// </summary>
        /// <param name="fichero">Cadena</param>
        /// <param name="fichero2">Cadena</param>
        static void SeparaPalabrasFichero(string fichero,string fichero2)
        {
            StreamReader sr = new StreamReader(fichero,Encoding.Default);
            StreamWriter sw = new StreamWriter(fichero2);
            int i;
            string linea;
            string[] lineas;

            while (sr.EndOfStream == false)
            {
                linea = sr.ReadLine();   
                lineas = linea.Split(' ');
                
                for (i = 0; i < lineas.Length; i++)
                {
                    sw.WriteLine(lineas[i]);
                }

            }          

            sr.Close();
            sw.Close();
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            string opcion = "-1";

            while (opcion != "0")
            {
                Console.Clear();

                Console.WriteLine("                             MENU");
                Console.WriteLine("====================================================================");
                Console.WriteLine(" 1º-EscribeFicheroNumRandom10  2º-SumaFicheroInt10");
                Console.WriteLine(" 3º-EscribeFicheroNumRandom    4º-SumaFicheroInt");
                Console.WriteLine(" 5º-EscribeFicheroTexto        6º-LeeFicheroTexto");
                Console.WriteLine(" 7º-CopiaFicheroTexto          8º-InvierteLineasFichero");
                Console.WriteLine(" 9º-InvierteFicheroTexto      10º-SeparaPalabrasFichero");
                Console.Write("\nDime el ejercicio : ");
                opcion = Console.ReadLine();

                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        {
                            EscribeFicheroNumRandom10("ficheroRandom10.txt");
                            System.Diagnostics.Process.Start("notepad.exe", Directory.GetCurrentDirectory() + "\\ficheroRandom10.txt");
                        }
                        break;

                    case "2":
                        {
                            Console.WriteLine(SumaFicheroInt10("SumaFicheroInt10.txt"));
                            System.Diagnostics.Process.Start("notepad.exe", Directory.GetCurrentDirectory() + "\\SumaFicheroInt10.txt");
                        }
                        break;
                    case "3":
                        {
                            int numero;
                            Console.WriteLine("Dime el numero de aleatorios que quieres en el fichero de texto");
                            numero = int.Parse(Console.ReadLine());

                            EscribeFicheroNumRandom("ficheroRandom.txt", numero);
                            // Para abrir el 
                            // bloc de notas
                            System.Diagnostics.Process.Start("notepad.exe", Directory.GetCurrentDirectory() + "\\ficheroRandom.txt");
                        }
                        break;
                    case "4":
                        {
                            Console.WriteLine(SumaFicheroInt("SumaFicheroInt.txt"));
                            System.Diagnostics.Process.Start("notepad.exe", Directory.GetCurrentDirectory() + "\\SumaFicheroInt.txt");

                        }
                        break;

                    case "5":
                        {
                            EscribeFicheroTexto("ficheroTexto.txt");
                            System.Diagnostics.Process.Start("notepad.exe", Directory.GetCurrentDirectory() + "\\ficheroTexto.txt");
                        }
                        break;

                    case "6":
                        {
                            EscribeFicheroTexto("leerfichero.txt");
                            LeeFicheroTexto("leerfichero.txt");
                        }
                        break;

                    case "7":
                        {
                            
                            CopiaFicheroTexto("Copiafichero1.txt", "Copiafichero2.txt");
                            Console.WriteLine("Tu segundo fichero : ");
                            LeeFicheroTexto("Copiafichero2.txt");
                        }
                        break;

                    case "8":
                        {
                            
                            InvierteLineasFichero("InvierteFichero1.txt", "InvierteFichero2.txt");
                            Console.WriteLine("Tu fichero 1 : ");
                            LeeFicheroTexto("InvierteFichero1.txt");
                            Console.WriteLine();
                            Console.WriteLine("Tu fichero 2 : ");
                            LeeFicheroTexto("InvierteFichero2.txt");
                        }
                        break;

                    case "9":
                        {
                            InvierteFicheroTexto("invierteFTexto.txt");
                            //LeeFicheroTexto("invierteFTexto.txt");
                            System.Diagnostics.Process.Start("notepad.exe", Directory.GetCurrentDirectory() + "\\invierteFTexto.txt");
                        }
                        break;

                    case "10":
                        {
                            SeparaPalabrasFichero("sPalabraFichero.txt", "sPalabraFichero2.txt");
                            System.Diagnostics.Process.Start("notepad.exe", Directory.GetCurrentDirectory() + "\\sPalabraFichero2.txt");

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