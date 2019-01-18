using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_RelacionVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTSuma_Click(object sender, EventArgs e)
        {          
            double resultado;
            bool prueba1 = double.TryParse(TBoperador1.Text, out resultado);
            bool prueba2 = double.TryParse(TBoperador2.Text, out resultado);
            if (TBoperador1.Text != "" && TBoperador2.Text != "" && prueba1 == true && prueba2 == true)
            {
                TBresultado.Text = (double.Parse(TBoperador1.Text) + double.Parse(TBoperador2.Text)).ToString();
                Etiqueta.Text = "Sumando";
                EtiquetaSigno.Text = "+";
            }
            else
            {
                MessageBox.Show("Debes ingresar números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTMultiplicacion_Click(object sender, EventArgs e)
        {           
            double resultado;
            bool prueba1 = double.TryParse(TBoperador1.Text, out resultado);
            bool prueba2 = double.TryParse(TBoperador2.Text, out resultado);
            if (TBoperador1.Text != "" && TBoperador2.Text != "" && prueba1 == true && prueba2 == true)
            {
                TBresultado.Text = (double.Parse(TBoperador1.Text) * double.Parse(TBoperador2.Text)).ToString();
                Etiqueta.Text = "Multiplicando";
                EtiquetaSigno.Text = "x";
            }
            else
            {
                MessageBox.Show("Debes ingresar números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTResta_Click(object sender, EventArgs e)
        {          
            double resultado;
            bool prueba1 = double.TryParse(TBoperador1.Text, out resultado);
            bool prueba2 = double.TryParse(TBoperador2.Text, out resultado);
            if (TBoperador1.Text != "" && TBoperador2.Text != "" && prueba1 == true && prueba2 == true)
            {
                TBresultado.Text = (double.Parse(TBoperador1.Text) - double.Parse(TBoperador2.Text)).ToString();
                Etiqueta.Text = "Restando";
                EtiquetaSigno.Text = "-";
            }
            else
            {
                MessageBox.Show("Debes ingresar números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTDivision_Click(object sender, EventArgs e)
        {         
            double resultado;
            bool prueba1 = double.TryParse(TBoperador1.Text, out resultado);
            bool prueba2 = double.TryParse(TBoperador2.Text, out resultado);
            if (TBoperador1.Text != "" && TBoperador2.Text != "" && prueba1 == true && prueba2 == true)
            {
                TBresultado.Text = (double.Parse(TBoperador1.Text) / double.Parse(TBoperador2.Text)).ToString();
                Etiqueta.Text = "Dividiendo";
                EtiquetaSigno.Text = "/";
            }
            else
            {
                MessageBox.Show("Debes ingresar números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTLimpiar_Click(object sender, EventArgs e)
        {
            EtiquetaSigno.Text = "";
            Etiqueta.Text = "";
            TBoperador1.Clear();
            TBoperador2.Clear();
            TBresultado.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BTLimpiar.Enabled = false;
        }

        private void TBoperador1_TextChanged(object sender, EventArgs e)
        {
            var bl = !string.IsNullOrEmpty(TBoperador1.Text) &&
                               !string.IsNullOrEmpty(TBoperador2.Text);
            BTLimpiar.Enabled = bl;
        }

        private void TBoperador2_TextChanged(object sender, EventArgs e)
        {
            var bl = !string.IsNullOrEmpty(TBoperador1.Text) &&
                              !string.IsNullOrEmpty(TBoperador2.Text);
            BTLimpiar.Enabled = bl;
        }
    }
}

