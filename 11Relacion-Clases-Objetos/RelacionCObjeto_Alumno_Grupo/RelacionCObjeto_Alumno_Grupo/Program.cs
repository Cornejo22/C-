using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RelacionCObjeto_Alumno_Grupo
{
    class Alumno
    {
        //Atributos
        private string nombre;
        private int edad;
        private decimal calificacion;

        //Constructor
        /// <summary>
        /// Nos crea un nuevo alumno pasandole el nombre,edad y calificacion
        /// </summary>
        /// <param name="nombre">String</param>
        /// <param name="edad">Entero</param>
        /// <param name="calificacion">Calificación</param>
        public Alumno(string nombre, int edad, decimal calificacion)
        {
            if (nombre != "" || edad > 17 && edad < 100 || calificacion >= 0 && calificacion <= 10)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.calificacion = calificacion;
            }
            else
            {
                throw new Exception("Cadena vacia, edad incorrecta o calificación incorrecta");
            }
        }

        /// <summary>
        /// Nos crea un nuevo alumno.
        /// </summary>
        public Alumno() { }

        //Propiedades
        /// <summary>
        /// Nos devuelve el nombre del alumno comprobando que no sea una cadena vacía.
        /// </summary>
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("La cadena esta vacia");

                }
                else
                {
                    nombre = value;
                }
            }
        }

        /// <summary>
        /// Nos devuelve la edad del alumno comprobando que no sea menor que 17 ni mayor que 100.
        /// </summary>
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if(value > 17 && value < 100)
                {
                    edad = value;
                }
                else
                {
                    throw new Exception("La edad no es correcta");
                }
            }
        }

        /// <summary>
        /// Nos devuelve la calificación del alumno comprobando que sea mayor e igual que 0 y menor e igual que 10
        /// </summary>
        public decimal Calificacion
        {
            get
            {
                return calificacion;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    calificacion = value;
                }
                else
                {
                    throw new Exception("La califcación no es correcta");
                }
            }
        }

        //Metodos
        /// <summary>
        /// Imprimiremos la ficha de alumnos.
        /// </summary>
        /// <returns>String</returns>
        public string Imprime()
        {
            string devuelto;

            devuelto = "Nombre: " + this.nombre + "\nEdad: " + this.edad +
                "\nCalificacion: " + this.calificacion + "\n";

            return devuelto;
        }
        
    }

    class Grupo
    {
        //Atributo
        private List<Alumno> listaAlumnos;

        //Constructor
        /// <summary>
        /// Nos crea un grupo de alumnos mediante una lista.
        /// </summary>
        public Grupo()
        {
            listaAlumnos = new List<Alumno>();
        }

        //Metodos
        /// <summary>
        /// Inserta un nuevo alumno,pasandole un objeto alumno, en la lista.
        /// </summary>
        /// <param name="a">Objeto alumno</param>
        public void InsertaAlumnoLista(Alumno a)
        {
            listaAlumnos.Add(a);
        }

        /// <summary>
        /// Inserta un nuevo alumno, pasandole un string, un entero, un decimal, en la lista.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="calificacion"></param>
        public void InsertaAlumnoLista(string nombre,int edad,decimal calificacion)
        {
            Alumno nA = new Alumno(nombre, edad, calificacion);
            listaAlumnos.Add(nA);
        }

        /// <summary>
        /// Imprimiremos la ficha completa del grupo de alumnos.
        /// </summary>
        /// <returns></returns>
        public string Imprime()
        {
            string devuelto = "";           

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                devuelto = devuelto + listaAlumnos[i].Imprime();
            }

            return devuelto;
        }

        /// <summary>
        /// Crearemos un fichero binario del listado de alumnos.
        /// </summary>
        /// <param name="fichero">String</param>
        public void EscribeFichero(string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter br = new BinaryWriter(fs);

            int i;
            br.Write(listaAlumnos.Count);

            for (i = 0; i < listaAlumnos.Count; i++)
            {
                br.Write(listaAlumnos[i].Nombre);
                br.Write(listaAlumnos[i].Edad);
                br.Write(listaAlumnos[i].Calificacion);
            }
            br.Close();
            fs.Close();

        }

        /// <summary>
        /// Leeremos un fichero binario que le pasamos por parámetro.
        /// </summary>
        /// <param name="fichero">String</param>
        public void LeeFichero(string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            listaAlumnos.Clear();
            br.ReadInt32();

            while (fs.Position < fs.Length)
            {
                Alumno alumnosT = new Alumno();

                alumnosT.Nombre = br.ReadString();
                alumnosT.Edad = br.ReadInt32();
                alumnosT.Calificacion = br.ReadDecimal();      

                listaAlumnos.Add(alumnosT);
            }

            br.Close();
            fs.Close();
        }

        /// <summary>
        /// Crearemos un fichero de texto de listado de alumnos.
        /// </summary>
        /// <param name="fichero">String</param>
        public void EscribeFicheroTXT(string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);
            int i;
            int numeroAlumnos = listaAlumnos.Count;
            sw.WriteLine(numeroAlumnos);

            for (i = 0; i < listaAlumnos.Count; i++)
            {
                sw.WriteLine(listaAlumnos[i].Nombre);
                sw.WriteLine(listaAlumnos[i].Edad);
                sw.WriteLine(listaAlumnos[i].Calificacion);
            }

            sw.Close();
        }

        /// <summary>
        /// Leeremos un fichero de texto que le pasamos por parámetro.
        /// </summary>
        /// <param name="fichero">String</param>
        public void LeeFicheroTXT(string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            listaAlumnos.Clear();
            int nAlumno = int.Parse(sr.ReadLine());

            while (!sr.EndOfStream)
            {
                Alumno alumnos = new Alumno();
                alumnos.Nombre = sr.ReadLine();
                alumnos.Edad = int.Parse(sr.ReadLine());
                alumnos.Calificacion = decimal.Parse(sr.ReadLine());
                listaAlumnos.Add(alumnos);
            }
            sr.Close();
        }

        /// <summary>
        /// Crearemos un fichero csv de listado de alumnos.
        /// </summary>
        /// <param name="fichero">String</param>
        public void EscribeFicheroCSV(string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);
            int i;
            int numeroAlumnos = listaAlumnos.Count;
            sw.WriteLine(numeroAlumnos);

            for (i = 0; i < listaAlumnos.Count; i++)
            {
                sw.Write(listaAlumnos[i].Nombre + ";");
                sw.Write(listaAlumnos[i].Edad + ";");
                sw.WriteLine(listaAlumnos[i].Calificacion);
                
            }
            sw.Close();
        }

        /// <summary>
        /// Leeremos un fichero csv que le pasamos por parámetro.
        /// </summary>
        /// <param name="fichero">String</param>
        public void LeeFicheroCSV(string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            string linea;
            string[] cad;
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                Alumno alumnos = new Alumno();
                linea = sr.ReadLine();
                cad = linea.Split(';');
                alumnos.Nombre = cad[0];
                alumnos.Edad = int.Parse(cad[1]);
                alumnos.Calificacion = decimal.Parse(cad[2]);
            }

            sr.Close();
        }
    }

    class Program
    {
        /// <summary>
        /// Buscaremos si existe el fichero y devolveremos un booleano
        /// </summary>
        /// <param name="fichero">String</param>
        /// <returns>False o true</returns>
        static bool FicheroExistente(string fichero)
        {
            bool devolver = false;

            if (File.Exists(fichero))
            {
                devolver = true;
            }

            return devolver;
        }

        static void Main(string[] args)
        {
            Alumno al = new Alumno();
            Grupo g1 = new Grupo();

            int opcion = -1;

            while(opcion != 0)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido");
                Console.WriteLine("Desea salir del programa, pulse 0");
                Console.WriteLine("Desea ingresar un nuevo alumno,pulse 1");
                Console.WriteLine("Desea escribir o leer un archivo binario, pulse 2");
                Console.WriteLine("Desea escribir o leer un archivo de texto, pulse 3");
                Console.WriteLine("Desea escribir o leer un archivo csv, pulse 4");
                Console.WriteLine("Desea imprimir el grupo de alumnos,pulse 5");
                while (int.TryParse(Console.ReadLine(),out opcion) == false)
                {
                    Console.WriteLine("Pulse una de las opciones anteriormente sugeridas");
                    opcion = int.Parse(Console.ReadLine());                 
                }

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Gracias,hasta pronto");
                        opcion = 0;
                        break;
                    case 1:
                        {
                            string nombre;
                            int edad;
                            decimal calificacion;
                            Console.WriteLine("Digame el nombre del alumno");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Digame la edad del alumno");
                            edad = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digame la calificación del alumno");
                            calificacion = decimal.Parse(Console.ReadLine());
                            g1.InsertaAlumnoLista(nombre, edad, calificacion);
                        }
                        break;

                    case 2:
                        {
                            string opcion2;
                            string nombreF;

                            Console.WriteLine("Introduzca 'escribir' o 'leer' para crear o leer un archivo binario");
                            opcion2 = Console.ReadLine();
                            opcion2 = opcion2.ToLower();

                            while (opcion2 != "escribir" && opcion2 != "leer")
                            {
                                Console.WriteLine("Por favor, introduzca 'escribir' o 'leer'");
                                opcion2 = Console.ReadLine();
                                opcion2 = opcion2.ToLower();
                            }

                            switch (opcion2)
                            {
                                case "escribir":
                                    {
                                        char si;
                                        Console.Write("Nombre para el fichero(sin extensiones) : ");
                                        nombreF = Console.ReadLine();
                                        if (FicheroExistente(nombreF + ".bin") == true)
                                        {
                                            Console.WriteLine("Desea sobrescribir el archivo, s(si) o n(no)");
                                            si = char.Parse(Console.ReadLine().ToLower());
                                            if (si == 's')
                                            {
                                                File.Delete(nombreF + ".bin");
                                                g1.EscribeFichero(nombreF + ".bin");
                                            }
                                            if (si == 'n')
                                            {
                                                Console.WriteLine("Digame un nombre para el nuevo archivo");
                                                nombreF = Console.ReadLine();
                                                g1.EscribeFichero(nombreF + ".bin");
                                            }
                                        }
                                        else
                                        {
                                            g1.EscribeFichero(nombreF + ".bin");
                                        }
                                    }
                                    break;
                                case "leer":
                                    {
                                        Console.WriteLine("Digame el nombre del fichero(sin extensiones) : ");
                                        nombreF = Console.ReadLine();
                                        g1.LeeFichero(nombreF + ".bin");
                                    }
                                    break;
                            }                                                              
                        }
                        break;

                    case 3:
                        {
                            string opcion2;
                            string nombreF;

                            Console.WriteLine("Introduzca 'escribir' o 'leer' para crear o leer un archivo de texto");
                            opcion2 = Console.ReadLine();
                            opcion2 = opcion2.ToLower();

                            while (opcion2 != "escribir" && opcion2 != "leer")
                            {
                                Console.WriteLine("Por favor, introduzca 'escribir' o 'leer'");
                                opcion2 = Console.ReadLine();
                                opcion2 = opcion2.ToLower();
                            }

                            switch (opcion2)
                            {
                                case "escribir":
                                    {
                                        char si;
                                        Console.Write("Nombre para el fichero(sin extensiones) : ");
                                        nombreF = Console.ReadLine();
                                        if (FicheroExistente(nombreF + ".txt") == true)
                                        {
                                            Console.WriteLine("Desea sobrescribir el archivo, s(si) o n(no)");
                                            si = char.Parse(Console.ReadLine().ToLower());
                                            if (si == 's')
                                            {
                                                File.Delete(nombreF + ".txt");
                                                g1.EscribeFichero(nombreF + ".txt");
                                            }
                                            if (si == 'n')
                                            {
                                                Console.WriteLine("Digame un nombre para el nuevo archivo");
                                                nombreF = Console.ReadLine();
                                                g1.EscribeFichero(nombreF + ".txt");
                                            }
                                        }
                                        else
                                        {
                                            g1.EscribeFichero(nombreF + ".txt");
                                        }
                                    }
                                    break;
                                case "leer":
                                    {
                                        Console.WriteLine("Digame el nombre del fichero(sin extensiones) : ");
                                        nombreF = Console.ReadLine();
                                        g1.LeeFicheroTXT(nombreF + ".txt");
                                    }
                                    break;
                            }
                        }
                        break;

                    case 4:
                        {
                            string opcion2;
                            string nombreF;

                            Console.WriteLine("Introduzca 'escribir' o 'leer' para crear o leer un archivo csv");
                            opcion2 = Console.ReadLine();
                            opcion2 = opcion2.ToLower();

                            while (opcion2 != "escribir" && opcion2 != "leer")
                            {
                                Console.WriteLine("Por favor, introduzca 'escribir' o 'leer'");
                                opcion2 = Console.ReadLine();
                                opcion2 = opcion2.ToLower();
                            }

                            switch (opcion2)
                            {
                                case "escribir":
                                    {
                                        char si;
                                        Console.Write("Nombre para el fichero(sin extensiones) : ");
                                        nombreF = Console.ReadLine();
                                        if (FicheroExistente(nombreF + ".csv") == true)
                                        {
                                            Console.WriteLine("Desea sobrescribir el archivo, s(si) o n(no)");
                                            si = char.Parse(Console.ReadLine().ToLower());
                                            if (si == 's')
                                            {
                                                File.Delete(nombreF + ".csv");
                                                g1.EscribeFichero(nombreF + ".csv");
                                            }
                                            if (si == 'n')
                                            {
                                                Console.WriteLine("Digame un nombre para el nuevo archivo");
                                                nombreF = Console.ReadLine();
                                                g1.EscribeFichero(nombreF + ".csv");
                                            }
                                        }
                                        else
                                        {
                                            g1.EscribeFichero(nombreF + ".csv");
                                        }
                                    }
                                    break;
                                case "leer":
                                    {
                                        Console.WriteLine("Digame el nombre del fichero(sin extensiones) : ");
                                        nombreF = Console.ReadLine();
                                        g1.LeeFicheroTXT(nombreF + ".csv");
                                    }
                                    break;
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine(g1.Imprime());
                        break;
                }
                Console.ReadKey();
            }
            Console.ReadKey();

           

            //!!!RECUERDA!!!
            //Hacer menu para presentarlo bonito


        }
    }
}
