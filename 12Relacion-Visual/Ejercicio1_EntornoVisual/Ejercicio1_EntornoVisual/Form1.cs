using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_EntornoVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonP_Click(object sender, EventArgs e)
        {
            string cadena = "Hola Mundo";
            Etiqueta.Text = cadena;
        }
    }
}
