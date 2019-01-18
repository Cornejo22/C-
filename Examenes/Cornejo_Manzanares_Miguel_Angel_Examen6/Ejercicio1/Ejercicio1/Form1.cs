using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BTCargar.Enabled = false;
        }            

        private bool PentaVolica(string palabra)
        {
            string cadena = palabra;
            int[] contadores = new int[5];          
            string palabra2 = palabra.ToLower();
            bool devuelve = false;
            int i, j;
            for (i = 0; i < palabra2.Length; i++)
            {
                #region "contadoresV"
                if (palabra2[i] == 'a' || palabra2[i] == 'á')
                {
                    contadores[0]++;
                }
                if (palabra2[i] == 'e' || palabra2[i] == 'é')
                {
                    contadores[1]++;
                }
                if (palabra2[i] == 'i' || palabra2[i] == 'í')

                {
                    contadores[2]++;
                }
                if (palabra2[i] == 'o' || palabra2[i] == 'ó')
                {
                    contadores[3]++;
                }
                if (palabra2[i] == 'u' || palabra2[i] == 'ú' || palabra2[i] == 'ü')
                {
                    contadores[4]++;
                }
                #endregion
            }

            #region "if"
            if (contadores[0] >= 1)
            {
                if (contadores[1] >= 1)
                {
                    if (contadores[2] >= 1)
                    {
                        if (contadores[3] >= 1)
                        {
                            if (contadores[3] >= 1)
                            {
                                if (contadores[4] >= 1)
                                {
                                    devuelve = true;
                                    
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            return devuelve;

        }

        private void Borrar(ListBox lb)
        {
            for (int i = 0; i < lb.Items.Count; i++)
            {
                lb.Items.Clear();
            }
        }

        private void BTCargar_Click(object sender, EventArgs e)
        {
            Borrar(LBoxPalabras);
            string linea = TBLeer.Text ;
            StreamReader sr = new StreamReader(linea, Encoding.Default);
            string palabra;
            List<string> listaOrdenada = new List<string>();        

            while (!sr.EndOfStream)
            {
                palabra = sr.ReadLine().ToLower();
                string[] separadores = { " ", "\r\n","," };
                string[] trozos = palabra.Split(separadores, StringSplitOptions.None);

                for (int i = 0; i < trozos.Length; i++)
                {
                    if (PentaVolica(trozos[i]))
                    {
                        if (!listaOrdenada.Contains(trozos[i]))
                        {
                            listaOrdenada.Add(trozos[i]);
                        }     
                    }
                }
            }
            sr.Close();
            listaOrdenada.Sort();
            for (int i = 0; i < listaOrdenada.Count; i++)
            {
                LBoxPalabras.Items.Add(listaOrdenada[i]);
            }

        }

        public bool Devuelve(string cadena)
        {
            bool activar;
            return activar = !string.IsNullOrEmpty(cadena);
        }

        private void TBLeer_TextChanged(object sender, EventArgs e)
        {
            if (Devuelve(TBLeer.Text))
            {
                BTCargar.Enabled = true;
            }
            else
            {
                BTCargar.Enabled = false;
            }
        }
    }
}
