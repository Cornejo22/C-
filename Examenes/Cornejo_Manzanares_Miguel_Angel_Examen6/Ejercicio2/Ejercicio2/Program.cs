using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio2
{
    class EquipoBaloncesto
    {
        //Atributos
        private string nombre;
        private int victorias, derrotas, puntosAnotados, puntosRecibidos;

        //Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }        
        }

        public int Victorias
        {
            get
            {
                return victorias;
            }         
        }

        public int Derrotas
        {
            get
            {
                return derrotas;
            }       
        }

        public int PuntosAnotados
        {
            get
            {
                return puntosAnotados;
            }         
        }

        public int PuntosRecibidos
        {
            get
            {
                return puntosRecibidos;
            }
        }

       //Constructores
       public EquipoBaloncesto(string nombre)
        {
            this.nombre = nombre;
            victorias = 0;
            derrotas = 0;
            puntosAnotados = 0;
            puntosRecibidos = 0;
        }

        public EquipoBaloncesto(string nombre,int victorias,int derrotas,int puntosAnotados, int puntosRecibidos)
        {
            this.nombre = nombre;
            this.victorias = victorias;
            this.derrotas = derrotas;
            this.puntosRecibidos = puntosRecibidos;
            this.puntosAnotados = puntosAnotados;
        }

        //Metodos
        public override string ToString()
        {
            return nombre;
        }
    }

    class LigaBaloncesto
    {
        //Atributos
        List<EquipoBaloncesto> listaEquipos;

        //Constructor
        public LigaBaloncesto()
        {
            listaEquipos = new List<EquipoBaloncesto>();
        }

        //Metodos
        public void CargarLista(string fichero)
        {
            StreamReader sr = new StreamReader(fichero, Encoding.Default);
            string linea = "";
            string[] trozos;
            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                trozos = linea.Split(';');
                EquipoBaloncesto eb = new EquipoBaloncesto(trozos[0], int.Parse(trozos[1]), int.Parse(trozos[2]), int.Parse(trozos[3]), int.Parse(trozos[4]));
                listaEquipos.Add(eb);               
            }
            sr.Close();
        }

        public void GuardarLiga(string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero + "csv",true, Encoding.Default);

            for (int i = 0; i < listaEquipos.Count; i++)
            {
                sw.Write(listaEquipos[i].Nombre + ";");
                sw.Write(listaEquipos[i].Victorias + ";");
                sw.Write(listaEquipos[i].Derrotas + ";");
                sw.Write(listaEquipos[i].PuntosAnotados + ";");
                sw.WriteLine(listaEquipos[i].PuntosRecibidos);
            }
            sw.Close();
        }

        //Propiedades
        public string Clasificacion
        {           
            get
            {
                string cadena = "";                
                int diferencia;

                for (int i = 0; i < listaEquipos.Count; i++)
                {
                    diferencia = listaEquipos[i].PuntosAnotados - listaEquipos[i].PuntosRecibidos;

                    if (diferencia >= 0)
                    {

                        cadena = cadena + "\n" + listaEquipos[i].Nombre.PadRight(25) + " " + listaEquipos[i].Victorias + "-"
                            + listaEquipos[i].Derrotas.ToString().PadRight(5) + " " + "+" + diferencia;
                    }
                    else
                    {
                        cadena = cadena + "\n" + listaEquipos[i].Nombre.PadRight(25) + " " + listaEquipos[i].Victorias
                            + "-" + listaEquipos[i].Derrotas.ToString().PadRight(5) + " " + diferencia.ToString().PadLeft(4);
                    }                   
                }

                

                return cadena ;
            }           
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LigaBaloncesto lb = new LigaBaloncesto();
            lb.CargarLista("liga.csv");

            Console.WriteLine(lb.Clasificacion);

            Console.ReadKey();
        }
    }
}
