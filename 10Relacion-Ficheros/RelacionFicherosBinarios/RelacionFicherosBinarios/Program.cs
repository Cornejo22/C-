using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RelacionFicherosBinarios
{
    class Program
    {
        /// <summary>
        ///  Te escriba en un fichero binario cuyo
        ///  nombre le pasas por parámetro (p.ej.: “datos01.bin”)
        ///  los valores enteros desde 1 hasta 100.
        /// </summary>
        /// <param name="ficheroB">Fichero binario</param>
        static void EscribeFichero1_100(string ficheroB)
        {
            FileStream fs1 = new FileStream(ficheroB, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs1);

            for (int i = 1; i <= 100; i++)
            {
                bw.Write(i);
            }

            bw.Close();
            fs1.Close();
        }

        /// <summary>
        /// Te lea del fichero que le pasas por parámetro 
        /// los 100 primeros valores enteros. 
        /// </summary>
        /// <param name="ficheroB">Fichero binario</param>
        static void LeeFicheroInt100(string ficheroB)
        {
            FileStream fs = new FileStream(ficheroB, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            int numero;

            while (fs.Position < fs.Length)
            {
                numero = br.ReadInt32();
                Console.WriteLine(numero);
            }
  
            Console.ReadKey();
            br.Close();
            fs.Close();
        }

        /// <summary>
        ///  Le pasas el nombre del fichero y 
        ///  cuántos números aleatorios queremos escribir en el 
        ///  mismo. Los números aleatorios serán entre 1 y 100 
        ///  y serán de tipo int. 
        /// </summary>
        /// <param name="ficheroB">Fichero binario</param>
        /// <param name="nAleatorio">Numero entero</param>
        static void EscribeFicheroIntAleatorio(string ficheroB, int nAleatorio)
        {
            FileStream fs = new FileStream(ficheroB, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            Random nr = new Random();
            int i;
            int n;

            for (i = 0; i < nAleatorio; i++)
            {
                n = nr.Next(1,100+1);
                bw.Write(n);
            }
            
            bw.Close();
            fs.Close();
        }

        /// <summary>
        ///  Le pasas lo siguiente: el nombre del fichero, 
        ///  número de valores que se van a generar, 
        ///  el valor mínimo y el valor máximo. 
        ///  Así, EscribeFicheroIntAleatorioPro(“datos.bin”, 10, -5, 5) 
        ///  nos escribirá diez valores aleatorios entre -5 y 5 
        ///  en el fichero datos.bin.
        /// </summary>
        /// <param name="ficheroB">Fichero binario</param>
        /// <param name="nAleatorio">Número entero</param>
        /// <param name="nMin">Número entero</param>
        /// <param name="nMax">Número entero</param>
        static void EscribeFicheroIntAleatorioPro(string ficheroB, int nAleatorio,int nMin, int nMax)
        {
            FileStream fs = new FileStream(ficheroB, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            Random nr = new Random();
            int i;
            int n;

            for (i = 0; i < nAleatorio; i++)
            {
                n = nr.Next(nMin, nMax+1);
                bw.Write(n);
            }

            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Lea del fichero que le pasas por 
        /// parámetro todos los valores enteros que haya en él.
        /// </summary>
        /// <param name="ficheroB">Fichero binario</param>
        static void LeeFicheroInt(string ficheroB)
        {
            FileStream fs = new FileStream(ficheroB, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            int n1;

            while(br.PeekChar() != -1)
            {
                n1 = br.ReadInt32();
                Console.Write(n1);
            }
            Console.ReadKey();
            br.Close();
            fs.Close();
        }

        /// <summary>
        /// Lea de un fichero todos los valores enteros, 
        /// los sume y te devuelva el resultado.
        /// </summary>
        /// <param name="ficheroB">Fichero binario</param>
        /// <returns>Numero entero</returns>
        static int SumaFicheroInt(string ficheroB)
        {
            int resultado = 0;
            FileStream fs = new FileStream(ficheroB, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            int numero;

            while(fs.Position < fs.Length)
            {
                numero = br.ReadInt32();
                resultado = resultado + numero;
            }

            return resultado;
        }

        /// <summary>
        /// Te escribe por pantalla la lista de números
        /// </summary>
        /// <param name="lista">Lista de números</param>
        static void EscribeLista(List<int> lista)
        {
            int i;

            Console.Write("[");
            for (i = 0; i < lista.Count-1; i++)
            {
                Console.Write(lista[i] + " ");
            }
            Console.Write(lista[i]);
            Console.WriteLine("]");
        }

        /// <summary>
        /// Lea de un fichero todos los valores enteros. 
        /// Los valores los irá almacenando en una 
        /// lista de enteros que devolverá
        /// </summary>
        /// <param name="ficheroB">Fichero binario</param>
        /// <returns>Una lista de numeros del fichero binario</returns>
        static List<int> LeeFicheroIntLista(string ficheroB)
        {
            List<int> lista = new List<int>();
            FileStream fs = new FileStream(ficheroB, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            int numero;
            while(fs.Position < fs.Length)
            {
                numero = br.ReadInt32();
                lista.Add(numero);
            }

            br.Close();
            fs.Close();

            return lista;
        }

        /// <summary>
        ///  Lea de un fichero los valores enteros que haya, 
        ///  los ordene y vuelva a escribir en el mismo fichero 
        ///  los valores ya ordenados.
        /// </summary>
        /// <param name="ficheroB">Fichero binario</param>
        static void OrdenaFicheroInt(string ficheroB)
        {
            FileStream fs = new FileStream(ficheroB, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            List<int> listaN = new List<int>();
            int numero;

            while(fs.Position < fs.Length)
            {
                numero = br.ReadInt32();
                listaN.Add(numero);
            }

            listaN.Sort();
            
            br.Close();
            fs.Close();

            FileStream fs2 = new FileStream(ficheroB , FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs2);
            int i;

            for (i = 0; i < listaN.Count; i++)
            {
                bw.Write(listaN[i]);
            }

            bw.Close();
            fs2.Close();

        }

        /// <summary>
        ///  Le pasaremos el nombre del fichero que queremos 
        ///  separar. La función nos creará dos ficheros que 
        ///  tendrán el mismo nombre que el de origen pero 
        ///  añadiéndole “positivos” o “negativos” detrás 
        ///  (ej.: datos.bin -> datos.binpositivos, 
        ///  datos.binnegativos). En un fichero guardaremos todos
        ///  los números positivos que haya en el primer fichero 
        ///  y en el otro los negativos. 
        /// </summary>
        /// <param name="ficheroB">Fichero binario</param>
        static void SeparaFicheroInt(string ficheroB)
        {
            FileStream fs = new FileStream(ficheroB, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            List<int> listaNeg = new List<int>();
            List<int> listaPos = new List<int>();
            int numero;

            while(fs.Position < fs.Length)
            {
                numero = br.ReadInt32();

                if(numero >= 0)
                {
                    listaPos.Add(numero);
                }
                else
                {
                    if(numero < 0)
                    {
                        listaNeg.Add(numero);
                    }
                }
            }
            br.Close();
            fs.Close();

            fs = new FileStream(ficheroB + "positivos",FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            int i;

            for (i = 0; i < listaPos.Count; i++)
            {
                bw.Write(listaPos[i]);
            }

            bw.Close();
            fs.Close();

            fs = new FileStream(ficheroB + "negativos", FileMode.Create);
            BinaryWriter bw2 = new BinaryWriter(fs);
            int i2;

            for (i2 = 0; i2 < listaNeg.Count; i2++)
            {
                bw2.Write(listaNeg[i2]);
            }

            bw2.Close();
            fs.Close();
        }

        /// <summary>
        ///  Le pasaremos un fichero que contiene enteros e 
        ///  invertirá la posición de los valores dentro del 
        ///  fichero, es decir, lo escribirá de atrás
        ///  para delante.  
        /// </summary>
        /// <param name="ficheroB">Fichero binario</param>
        static void InvierteFicheroInt(string ficheroB)
        {
            FileStream fs = new FileStream(ficheroB, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            List<int> listaN = new List<int>();
            int numero;

            while (fs.Position < fs.Length)
            {
                numero = br.ReadInt32();
                listaN.Add(numero);
            }

            listaN.Reverse();

            br.Close();
            fs.Close();

            FileStream fs2 = new FileStream(ficheroB, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs2);
            int i;

            for (i = 0; i < listaN.Count; i++)
            {
                bw.Write(listaN[i]);
            }

            fs2.Close();
            bw.Close();

        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            string opcion = "-1";

            while (opcion != "0")
            {
                Console.Clear();
                Console.WriteLine("                              MENU    ");
                Console.WriteLine("==================================================================");
                Console.WriteLine("1º-EscribeFichero1_100        2º-LeeFicheroInt100");
                Console.WriteLine("3º-EscribeFicheroIntAleatorio 4º-EscribeFicheroIntAleatorioPro”");
                Console.WriteLine("5º-LeeFicheroInt              6º-SumaFicheroInt");
                Console.WriteLine("7º-LeeFicheroIntLista         8º-OrdenarFicheroInt");
                Console.WriteLine("9º-SeparaFicheroInt          10º-InvierteFicheroInt");
                Console.WriteLine("\nDime el ejercicio : ");
                opcion = Console.ReadLine();

                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        {
                            EscribeFichero1_100("datos01.bin");
                        }
                        break;

                    case "2":
                        {
                            EscribeFichero1_100("datos100.bin");
                            LeeFicheroInt100("datos100.bin");
                        }
                        break;

                    case "3":
                        {
                            EscribeFicheroIntAleatorio("datosAleatorios.bin", 4);
                            LeeFicheroInt100("datosAleatorios.bin");
                        }
                        break;

                    case "4":
                        {
                            EscribeFicheroIntAleatorioPro("datosAleatorios2.bin", 3,-5,5);
                            LeeFicheroInt100("datosAleatorios2.bin");
                        }
                        break;

                    case "5":
                        {
                            EscribeFichero1_100("datosBinarios100.bin");
                            LeeFicheroInt100("datosBinarios100.bin");
                        }
                        break;

                    case "6":
                        {
                            EscribeFicheroIntAleatorioPro("datosBinariosSuma.bin", 6, 1, 10);
                            Console.WriteLine("La suma del fichero es : " + SumaFicheroInt("datosBinariosSuma.bin"));
                            Console.ReadKey();
                        }
                        break;

                    case "7":
                        {
                            EscribeFicheroIntAleatorioPro("datosBinariosLista.bin", 6, 1, 6);
                            EscribeLista(LeeFicheroIntLista("datosBinariosLista.bin"));
                            Console.ReadKey();
                        }
                        break;

                    case "8":
                        {
                            EscribeFicheroIntAleatorioPro("datosBOrdenados.bin", 4, 10, 20);
                            OrdenaFicheroInt("datosBOrdenados.bin");
                        }
                        break;

                    case "9":
                        {
                            EscribeFicheroIntAleatorioPro("datosBSeparados.bin", 15, -10, 20);
                            SeparaFicheroInt("datosBSeparados.bin");
                        }
                        break;

                    case "10":
                        {
                            EscribeFichero1_100("datosBInvertidos.bin");
                            InvierteFicheroInt("datosBInvertidos.bin");
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Error");
                        }
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
