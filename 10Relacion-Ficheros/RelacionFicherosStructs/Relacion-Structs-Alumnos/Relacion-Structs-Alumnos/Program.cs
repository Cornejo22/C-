using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Relacion_Structs_Alumnos
{
    class Program
    {
        struct ficha_alumno
        {
            public string nombre;
            public int edad;
            public decimal calificacion;
        }

        /// <summary>
        ///  Le pasas la lista de alumnos y 
        ///  te pide un nuevo alumno desde el teclado,
        ///  cuyos datos se añadirán a la lista. 
        /// </summary>
        /// <param name="lista_alumnos">Lista de alumnos</param>
        static void LeeAlumnoLista(List<ficha_alumno> lista_alumnos)
        {
            ficha_alumno fa;
            Console.WriteLine("Dime el nombre del alumno : ");
            fa.nombre = Console.ReadLine();
            while (fa.nombre == "")
            {
                Console.WriteLine("El nombre no puede estar vacio,vuelve a escribirlo ");
                fa.nombre = Console.ReadLine();
            }
            Console.WriteLine("Dime la edad del alumno :  ");
            while (int.TryParse(Console.ReadLine(), out fa.edad) == false)
            {
                Console.WriteLine("No es un número,vuelva a escribir la edad correctamente");
            }
            Console.WriteLine("Dime la calificación del alumno :  ");
            while (decimal.TryParse(Console.ReadLine(), out fa.calificacion) == false || fa.calificacion < 0 || fa.calificacion > 10)
            {
                Console.WriteLine("No es un número o el número no esta entre 0 y 10,vuelva a escribir la nota correctamente");
            }
            lista_alumnos.Add(fa);
        }

        /// <summary>
        /// Le pasas la lista de alumnos y te la imprime por pantalla. 
        /// </summary>
        /// <param name="lista_alumnos">Lista de alumnos</param>
        static void ImprimeListaAlumnos(List<ficha_alumno> lista_alumnos)
        {
            int i;
            int contador = 1;

            Console.WriteLine("Numero de alumnos totales : " + lista_alumnos.Count);

            for (i = 0; i < lista_alumnos.Count; i++)
            {
                Console.WriteLine("Ficha del alumno " + contador);
                Console.WriteLine("Nombre: " + lista_alumnos[i].nombre);
                Console.WriteLine("Edad : " + lista_alumnos[i].edad);
                Console.WriteLine("Calificación : " + lista_alumnos[i].calificacion);
                Console.WriteLine();
                contador++;
            }
        }

        /// <summary>
        /// Le pasas la lista y el nombre del fichero 
        /// y te escribe la lista en el fichero.
        /// </summary>
        /// <param name="lista_alumnos">Lista de alumnos</param>
        /// <param name="fichero">Fichero tipo binario(variable string)</param>
        static void EscribeFicheroAlumnos(List<ficha_alumno> lista_alumnos, string fichero)
        {
            FileStream fs = new FileStream(fichero,FileMode.Create);
            BinaryWriter br = new BinaryWriter(fs);
            //int cantidadAlumnos = lista_alumnos.Count;
            int i;
            br.Write(lista_alumnos.Count);

            for (i = 0; i < lista_alumnos.Count; i++)
            {
                br.Write(lista_alumnos[i].nombre);
                br.Write(lista_alumnos[i].edad);
                br.Write(lista_alumnos[i].calificacion);
            }


            br.Close();
            fs.Close();

        }

        /// <summary>
        ///  Le pasas una lista y el nombre del fichero 
        ///  y leerá la lista desde el fichero. 
        /// </summary>
        /// <param name="lista_alumnos">Lista de alumnos</param>
        /// <param name="fichero">Fichero tipo binario(variable string)</param>
        static void LeeFicheroAlumnos(List<ficha_alumno> lista_alumnos, string fichero)
        {

            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            lista_alumnos.Clear();
            br.ReadInt32();

            while (fs.Position < fs.Length)
            {
                ficha_alumno alumnos;

                alumnos.nombre = br.ReadString();
                alumnos.edad = br.ReadInt32();
                alumnos.calificacion = br.ReadDecimal();

                lista_alumnos.Add(alumnos);
            }

            br.Close();
            fs.Close();

        }

        //static void EscribeFicheroAlumnosTxtPro(List<ficha_alumno> lista_alumnos, string fichero)
        //{
        //    StreamWriter sw = new StreamWriter(fichero);
        //    int i;
        //    string linea = "";
        //    int numeroAlumnos = lista_alumnos.Count;
        //    linea = "Numero de alumnos : " + numeroAlumnos.ToString();
        //    sw.WriteLine(linea);
        //    int contador = 0;

        //    for (i = 0; i < lista_alumnos.Count; i++)
        //    {
        //        if (i == 1)
        //        {
        //            while (contador < lista_alumnos[0].nombre.Length)
        //            {
        //                sw.Write("-");
        //                contador++;
        //            }
        //        }
        //        sw.WriteLine();
        //        linea = lista_alumnos[i].nombre;
        //        sw.WriteLine("Nombre : " + linea);
        //        linea = lista_alumnos[i].edad.ToString();
        //        sw.WriteLine("Edad : " + linea);
        //        linea = lista_alumnos[i].calificacion.ToString();
        //        sw.WriteLine("Calificación " + linea);
        //    }

        //    sw.Close();
        //}

        /// <summary>
        /// Similar a la función EscribeFicheroAlumnos 
        /// pero usando un fichero de texto. 
        /// </summary>
        /// <param name="lista_alumnos">Lista de alumnos</param>
        /// <param name="fichero">Fichero tipo TXT(variable string)</param>
        static void EscribeFicheroAlumnosTxT(List<ficha_alumno> lista_alumnos, string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);
            int i;
            int numeroAlumnos = lista_alumnos.Count;
            sw.WriteLine(numeroAlumnos);

            for (i = 0; i < lista_alumnos.Count; i++)
            {   
                sw.WriteLine(lista_alumnos[i].nombre);
                sw.WriteLine(lista_alumnos[i].edad);
                sw.WriteLine(lista_alumnos[i].calificacion);
            }

            sw.Close();
        }

        /// <summary>
        ///  Similar a la función LeeFicheroAlumnos 
        ///  pero que funciona con los ficheros de texto del 
        ///  ejercicio anterior. 
        /// </summary>
        /// <param name="lista_alumnos">Lista de alumnos</param>
        /// <param name="fichero">Fichero tipo TXT(variable string)</param>
        static void LeeFicheroAlumnosTxT(List<ficha_alumno> lista_alumnos, string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            lista_alumnos.Clear();
            int nAlumno = int.Parse(sr.ReadLine());

            while (!sr.EndOfStream)
            {
                ficha_alumno alumnos;
                alumnos.nombre = sr.ReadLine();
                alumnos.edad = int.Parse(sr.ReadLine());
                alumnos.calificacion = decimal.Parse(sr.ReadLine());
                lista_alumnos.Add(alumnos);
            }

            sr.Close();
        }

        /// <summary>
        /// En este caso, no vamos a guardar el número de registros 
        /// en la primera línea, ya que los ficheros CSV estándar no lo hacen.
        /// </summary>
        /// <param name="lista_alumnos">Lista de alumnos</param>
        /// <param name="fichero">Fichero tipo CSV(variable string)</param>
        static void EscribeFicherAlumnosCSV(List<ficha_alumno> lista_alumnos,string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);
            int i;
            int numeroAlumnos = lista_alumnos.Count;
            sw.WriteLine(numeroAlumnos);

            for (i = 0; i < lista_alumnos.Count; i++)
            {
                sw.Write(lista_alumnos[i].nombre + ";");
                sw.Write(lista_alumnos[i].edad + ";");
                sw.Write(lista_alumnos[i].calificacion);
            }

            sw.Close();
        }

        /// <summary>
        ///  Lee los datos del fichero anterior en una lista
        /// </summary>
        /// <param name="lista_alumnos">Lista de alumnos</param>
        /// <param name="fichero">Fichero tipo CSV(variable string)</param>
        static void LeeFicheroAlumnosCSV(List<ficha_alumno> lista_alumnos,string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            string linea;
            string[] cad;
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                ficha_alumno alumnos;
                linea = sr.ReadLine();
                cad = linea.Split(';');
                alumnos.nombre = cad[0];
                alumnos.edad = int.Parse(cad[1]);
                alumnos.calificacion = decimal.Parse(cad[2]);             
            }

            sr.Close();
        }

        static void Main(string[] args)
        {
            List<ficha_alumno> alumnos = new List<ficha_alumno>();

            string opcion = "-1";

            while (opcion != "0")
            {
                Console.Clear();
                Console.WriteLine("                    MENU");
                Console.WriteLine("=====================================================");
                Console.WriteLine("1º-LeeAlumnoLista            2º-ImprimeListaAlumnos");
                Console.WriteLine("3º-EscribeFicheroAlumnos     4º-LeeFicheroAlumnos");
                Console.WriteLine("5º-EscribeFicheroAlumnosTxT  6º-LeeFicheroAlumnosTxT");
                Console.WriteLine("7º-EscribeFicheroAlumnosCSV  8º-LeeFicheroAlumnosCSV");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        {
                            Console.Clear();
                            string opcion2 = "si";
                            while (opcion2 == "si")
                            {
                                LeeAlumnoLista(alumnos);
                                Console.WriteLine("¿Quiere introducir más datos?(Si) o (No)");
                                opcion2 = Console.ReadLine();
                                opcion2 = opcion2.ToLower();
                                if (opcion2 == "no")
                                {
                                    opcion2 = "no";
                                }
                                Console.Clear();
                            }
                        }
                        break;

                    case "2":
                        {
                            Console.Clear();
                            ImprimeListaAlumnos(alumnos);
                        }
                        break;
                    case "3":
                        {
                            Console.Clear();
                            EscribeFicheroAlumnos(alumnos, "ficheroAlumnos.bin");
                        }
                        break;
                    case "4":
                        {
                            Console.Clear();
                            LeeFicheroAlumnos(alumnos, "ficheroAlumnos.bin");
                        }
                        break;

                    case "5":
                        {
                            Console.Clear();
                            EscribeFicheroAlumnosTxT(alumnos, "ficheroAlumnos.txt");
                        }
                        break;

                    case "6":
                        {
                            Console.Clear();
                            LeeFicheroAlumnosTxT(alumnos, "ficheroAlumnos.txt");
                        }
                        break;

                    case "7":
                        {
                            Console.Clear();
                            EscribeFicherAlumnosCSV(alumnos, "ficheroAlumnos.csv");
                        }
                        break;

                    case "8":
                        {
                            Console.Clear();
                            LeeFicheroAlumnosCSV(alumnos, "ficheroAlumnos.csv");
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

