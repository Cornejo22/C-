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

namespace Ejercicio10_RelacionVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BTAnnadir.Enabled = false;
            BTBorrar.Enabled = false;
            StreamReader sr = new StreamReader("diccionario.txt",Encoding.Default);
            string linea = "";

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                LBPalabras.Items.Add(linea);
            }

            sr.Close();           
        }

        private void LBPalabras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LBPalabras.Items.ToString() != "")
            {
                BTBorrar.Enabled = true;
            }
            
        }

        private void TBEspannol_TextChanged(object sender, EventArgs e)
        {
            var bl = !string.IsNullOrEmpty(TBEspannol.Text) && !string.IsNullOrEmpty(TBIngles.Text);

            BTAnnadir.Enabled = bl;
        }

        private void TBIngles_TextChanged(object sender, EventArgs e)
        {
            var bl = !string.IsNullOrEmpty(TBIngles.Text) && !string.IsNullOrEmpty(TBEspannol.Text);

            BTAnnadir.Enabled = bl;
        }

        private void BTAnnadir_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("diccionario.txt",false,Encoding.Default);
            string linea;

            if(TBEspannol.Text == " " || TBIngles.Text == " ")
            {
                MessageBox.Show("Casillas vacias","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                linea = TBEspannol.Text + "," + TBIngles.Text;

                LBPalabras.Items.Add(linea);
                MessageBox.Show("Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            sw.Close();

            TBEspannol.Clear();
            TBIngles.Clear();

        }

        private void BTBorrar_Click(object sender, EventArgs e)
        {
            int pos = LBPalabras.SelectedIndex;
            if (pos == -1)
            {
                MessageBox.Show("Casilla erronea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LBPalabras.Items.RemoveAt(pos);
                StreamWriter sw = new StreamWriter("diccionario.txt");

                for (int i = 0; i < LBPalabras.Items.Count; i++)
                {
                    sw.WriteLine(LBPalabras.Items[i]);
                    
                }
                MessageBox.Show("Borrado", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sw.Close();
            }

            BTBorrar.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw2 = new StreamWriter("diccionario.txt",false,Encoding.Default);
            string linea;

            for (int i = 0; i < LBPalabras.Items.Count; i++)
            {
                linea = LBPalabras.Items[i].ToString();
                sw2.WriteLine(linea);
            }
            sw2.Close();
        }
    }
}
