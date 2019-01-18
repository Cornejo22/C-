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

namespace Ejercicio15_RelacionVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string[] Annadir(string linea)
        {
            string[] trozos = linea.Split(',');
            string[] columnas = new string[trozos.Length];
            for (int i = 0; i < trozos.Length; i++)
            {
                columnas[i] = trozos[i];
            }

            return columnas;
        }

        private string Existe(string fichero)
        {
            string nombreD = "";

            string[] ficheros = Directory.GetFiles(".", "*.csv");
            

            for (int i = 0; i < ficheros.Length; i++)
            {
                string nombreF = Path.GetFileNameWithoutExtension(ficheros[i]);

                if(nombreF == fichero)
                {
                    nombreD = nombreF;
                }
                
            }

            return nombreD;
        }

        private void BTCargar_Click(object sender, EventArgs e)
        {
            string fichero = Existe(TBCargar.Text);
            LVDatos.Clear();
            StreamReader sr = new StreamReader(fichero + ".csv", Encoding.Default);
            string linea = sr.ReadLine();
            string[] columnas = Annadir(linea);

            for (int i = 0; i < columnas.Length; i++)
            {
                LVDatos.Columns.Add(columnas[i]);
            }

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                columnas = Annadir(linea);

                LVDatos.Items.Add(new ListViewItem(columnas));
            }
            sr.Close();
        }

        private void BTInsertar_Click(object sender, EventArgs e)
        {
            string linea = TBInsertar.Text;
            StreamWriter sw = new StreamWriter("listaD.csv", true, Encoding.Default);

            sw.WriteLine(linea);

            sw.Close();

            TBInsertar.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            BTInsertar.Enabled = false;
            BTBorrar.Enabled = false;
            BTCargar.Enabled = false;
        }

        private void TBInsertar_TextChanged(object sender, EventArgs e)
        {
            bool activar = !string.IsNullOrEmpty(TBInsertar.Text);

            BTInsertar.Enabled = activar;
        }

        private void BTBorrar_Click(object sender, EventArgs e)
        {
            if (LVDatos.SelectedIndices.Count > 0)
            {
                if (LVDatos.SelectedIndices.Count > 1)
                {
                    DialogResult dr = MessageBox.Show("Va a borrar varios elementos.\n¿Está seguro?", "Cuidado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        int i;

                        List<int> lista = new List<int>();
                        for (i = 0; i < LVDatos.SelectedIndices.Count; i++)
                        {
                            lista.Add(LVDatos.SelectedIndices[i]);
                        }
                        lista.Sort();
                        lista.Reverse();
                        for (i = 0; i < lista.Count; i++)
                        {
                            LVDatos.Items.RemoveAt(lista[i]);
                        }
                    }
                }
                else
                {
                    int indice = LVDatos.SelectedIndices[0];

                    LVDatos.Items.RemoveAt(indice);
                }
            }
        }

        private void LVDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (LVDatos.SelectedIndices.Count >= 1)
            {
                BTBorrar.Enabled = true;
            }
            else
            {
                BTBorrar.Enabled = false;
            }
        }

        private void TBCargar_TextChanged(object sender, EventArgs e)
        {
            bool activar = !string.IsNullOrEmpty(TBCargar.Text);

            BTCargar.Enabled = activar;
        }
    }
}
