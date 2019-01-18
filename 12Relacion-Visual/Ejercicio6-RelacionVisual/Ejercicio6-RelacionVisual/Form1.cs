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

namespace Ejercicio6_RelacionVisual
{
    public partial class Form1 : Form
    {
        List<string> listaEsp = new List<string>();
        List<string> listaIng = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BTTraduceEsp.Enabled = false;
            BTTraduIngles.Enabled = false;
            StreamReader sr = new StreamReader("EspIng.txt", Encoding.Default);
            string linea;
            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();

                string[] trozos = linea.Split(',');
                listaEsp.Add(trozos[0]);
                listaIng.Add(trozos[1].Substring(1));
            }

            sr.Close();
        }

        private void BTTraduIngles_Click(object sender, EventArgs e)
        {
            string linea = TBEsp.Text.ToLower();
            int pos = -1;
            for (int i = 0; i < listaEsp.Count; i++)
            {
                if(linea == listaEsp[i])
                {
                    pos = i;
                    i = listaEsp.Count;
                }
            }

            if (pos == -1)
            {
                MessageBox.Show("No se encuentra en el fichero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TBIng.Text = listaIng[pos];
            }
        }

        private void BTTraduceEsp_Click(object sender, EventArgs e)
        {
            string linea = TBIng.Text.ToLower();
            int pos = -1;
            for (int i = 0; i < listaIng.Count; i++)
            {
                if (linea == listaIng[i])
                {
                    pos = i;
                    i = listaIng.Count;
                }
            }

            if(pos == -1)
            {
                MessageBox.Show("No se encuentra en el fichero","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                TBEsp.Text = listaEsp[pos];
            }
        }

        private void BTLimpiar_Click(object sender, EventArgs e)
        {
            TBEsp.Clear();
            TBIng.Clear();
        }

        private void TBEsp_TextChanged(object sender, EventArgs e)
        {
            var bl = !string.IsNullOrEmpty(TBEsp.Text);
                               
            BTTraduIngles.Enabled = bl;
        }

        private void TBIng_TextChanged(object sender, EventArgs e)
        {

            var bl = !string.IsNullOrEmpty(TBIng.Text);

            BTTraduceEsp.Enabled = bl;
        }
    }
}
