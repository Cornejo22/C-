using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio2
{
    class Libro
    {
        //Atributos
        private string isbn,autor,titulo;
        private int nPaginas;
        private bool leido;

        //Propiedades
        public string Isbn
        {
            get
            {
                return isbn;
            }
        }

        public string Autor
        {
            get
            {
                return autor;
            }
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }
        }

        public int NPaginas
        {
            get
            {
                return nPaginas;
            }
        }

        public bool Leido
        {
            get
            {
                return leido;
            }
            set
            {
                leido = value;
            }
        }

        //Constructores
        public Libro(string isbn,string autor, string titulo,int nPaginas)
        {
            if(isbn == "" || autor == "" || titulo == ""|| nPaginas <= 0)
            {
                throw new Exception("Autor,título,isbn vacios o número de paginas igual o menor que 0");
            }
            else
            {
                this.isbn = isbn;
                this.autor = autor;
                this.titulo = titulo;
                this.nPaginas = nPaginas;
                leido = false;
            }
        }

        //Metodos
        public override string ToString()
        {
            string cadena;

            cadena = titulo + "(" + autor + ")" + "[" + leido + "]";

            return cadena;
        }
    }

    class Biblioteca
    {
        //Atributos
        private List<Libro> listaLibros;

        //Constructor
        public Biblioteca()
        {
            listaLibros = new List<Libro>();
        }

        //Metodos
        public override string ToString()
        {
            string cadena = "";

            for (int i = 0; i < listaLibros.Count; i++)
            {
                cadena = cadena + "\n" + listaLibros[i];
            }

            return cadena;
        }

        public bool InsertaLibro(Libro l)
        {
            bool existe = false;
            bool insertado = false;
            for (int i = 0; i < listaLibros.Count; i++)
            {
                if(listaLibros[i].Isbn == l.Isbn)
                {
                    existe = true;
                    i = listaLibros.Count;
                }
            }

            if(existe == false)
            {
                listaLibros.Add(l);
                insertado = true;
            }

            return insertado;
        }

        public int MarcarLeidoTitulo(string cadena)
        {
            string cadena2 = cadena.ToLower();
            int nLibrosMarcados = 0;

            for (int i = 0; i < listaLibros.Count; i++)
            {
                string libroA = listaLibros[i].Titulo.ToLower();
                string[] trozos = libroA.Split(' ');
                for (int j = 0; j < trozos.Length; j++)
                {
                    if(trozos[j] == cadena2)
                    {
                        listaLibros[i].Leido = true;
                        nLibrosMarcados++;
                    }
                }
            }

            return nLibrosMarcados;
        }

        public void GuardarCSV(string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);
            int i;
           
            for (i = 0; i < listaLibros.Count; i++)
            {
                sw.Write(listaLibros[i].Isbn + ";");
                sw.Write(listaLibros[i].Titulo + ";");
                sw.Write(listaLibros[i].Autor + ";");
                sw.Write(listaLibros[i].NPaginas + ";");
                sw.WriteLine(listaLibros[i].Leido);

            }
            sw.Close();
        }

        public void LeerCSV(string fichero)
        {
            StreamReader sr = new StreamReader(fichero, Encoding.Default);
            string linea;
            string[] cad;

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                cad = linea.Split(';');
                Libro l = new Libro(cad[0], cad[1], cad[2], int.Parse(cad[3]));
                listaLibros.Add(l);
            }

            sr.Close();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca bib = new Biblioteca();
            bib.LeerCSV("biblio.csv");

            int opcion = -1;

            while (opcion != 0)
            {
                Console.Clear();
                Console.WriteLine("GESTIÓN DE BIBLIOTECA PERSONAL");
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                Console.WriteLine("1- Listado de libros");
                Console.WriteLine("2- Añadir un libro");
                Console.WriteLine("3- Marcar un libro como leído");
                Console.WriteLine();
                Console.WriteLine("0- Salir (se grabarán las modificaciones)");
                Console.WriteLine();
                Console.Write("Opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine(bib);
                            Console.WriteLine();
                            Console.WriteLine("Pulse una tecla para volver al menú...");
                            Console.ReadKey();
                            break;
                        case 2:
                            {
                                string isbn;
                                string titulo;
                                string autor;
                                int npaginas;

                                Console.Clear();
                                Console.WriteLine("NUEVO LIBRO");
                                Console.WriteLine("-----------");
                                Console.WriteLine();

                                Console.Write("Introduzca el ISBN: ");
                                while ((isbn = Console.ReadLine()) == "")
                                {
                                    Console.Write("El ISBN no puede estar en blanco, escríbalo de nuevo: ");
                                }

                                Console.Write("Introduzca el título: ");
                                while ((titulo = Console.ReadLine()) == "")
                                {
                                    Console.Write("El título no puede estar en blanco, escríbalo de nuevo: ");
                                }

                                Console.Write("Introduzca el autor: ");
                                while ((autor = Console.ReadLine()) == "")
                                {
                                    Console.Write("El autor no puede estar en blanco, escríbalo de nuevo: ");
                                }

                                Console.Write("Introduzca el número de páginas: ");
                                while (!int.TryParse(Console.ReadLine(), out npaginas) || npaginas <= 0)
                                {
                                    Console.Write("El número de páginas debe ser un entero mayor que cero, escríbalo de nuevo: ");
                                }

                                Libro l = new Libro(isbn, titulo, autor, npaginas);
                                if (bib.InsertaLibro(l))
                                {
                                    Console.WriteLine("Libro insertado con éxito");
                                }
                                else
                                {
                                    Console.WriteLine("El libro no se ha podido insertar: ISBN duplicado");
                                }
                                Console.WriteLine();
                                Console.WriteLine("Pulse una tecla para volver al menú...");
                                Console.ReadKey();
                            }
                            break;
                        case 3:
                            {
                                string cadena;
                                Console.Clear();
                                Console.WriteLine("Introduzca el título o parte del título a marcar como leído");

                                while ((cadena = Console.ReadLine()) == "")
                                {
                                    Console.WriteLine("No puede usar una cadena en blanco. Escriba el título:");
                                }

                                int marcados = bib.MarcarLeidoTitulo(cadena);

                                if (marcados > 1)
                                {
                                    Console.WriteLine("Marcados " + marcados + " libros como leídos");
                                }
                                else
                                {
                                    if (marcados == 1)
                                    {
                                        Console.WriteLine("El libro se ha marcado como leído");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se ha encontrado ningún libro con ese título");
                                    }
                                }

                                Console.WriteLine();
                                Console.WriteLine("Pulse una tecla para volver al menú...");
                                Console.ReadKey();
                            }
                            break;
                    }
                }
                else
                {
                    opcion = -1;
                }
            }

            bib.GuardarCSV("biblio.csv");
            Console.WriteLine("¡Hasta pronto!");
            Console.ReadKey();
        }
    }
}
