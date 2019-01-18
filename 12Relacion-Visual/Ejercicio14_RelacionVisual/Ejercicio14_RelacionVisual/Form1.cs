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

namespace Ejercicio14_RelacionVisual
{
    public partial class Form1 : Form
    {
        Random r = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("titulosPeliculas.txt", Encoding.Default);
            string linea = "";            
            while (!sr.EndOfStream)
            {
                linea = sr.ReadToEnd();                              
            }

            sr.Close();
            string[] trozos = linea.Split(',');
            for (int i = 0; i < trozos.Length; i++)
            {
                CBTitulos1.Items.Add(trozos[i]);
            }

            sr = new StreamReader("titulosPeliculas2.txt", Encoding.Default);
            while (!sr.EndOfStream)
            {
                linea = sr.ReadToEnd();
            }
            sr.Close();
            trozos = linea.Split(',');
            for (int i = 0; i < trozos.Length; i++)
            {
                CBTitulos2.Items.Add(trozos[i]);
            }
        }

        private void BTGenerar_Click(object sender, EventArgs e)
        {
            LBTituloG.ForeColor = Color.Black;
            int pos = CBTitulos1.SelectedIndex;
            int pos2 = CBTitulos2.SelectedIndex;

            LBTituloG.Text = CBTitulos1.Items[pos].ToString() + " " +
                CBTitulos2.Items[pos2].ToString(); 
        }

        private void BTAleatorio_Click(object sender, EventArgs e)
        {         
            int pos = r.Next(0, CBTitulos1.Items.Count);
            int pos2 = r.Next(0, CBTitulos2.Items.Count);

            LBTituloG.Text = CBTitulos1.Items[pos].ToString() + " " +
               CBTitulos2.Items[pos2].ToString();

            Color c = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            LBTituloG.ForeColor = c;

        }
    }
}
