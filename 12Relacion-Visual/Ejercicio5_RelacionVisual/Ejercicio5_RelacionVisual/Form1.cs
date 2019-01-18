using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5_RelacionVisual
{
    public partial class Form1 : Form
    {
        public bool estaM = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void TBCm_TextChanged(object sender, EventArgs e)
        {
            if (estaM == false)
            {
                estaM = true;
                double medida;
                if (double.TryParse(TBCm.Text, out medida))
                {
                    double resultado = Math.Round(medida / 2.54, 3);
                    TBPulgadas.Text = resultado.ToString();
                }
                estaM = false;
            }
        }

        private void TBPulgadas_TextChanged(object sender, EventArgs e)
        {
            if (estaM == false)
            {
                estaM = true;
                double medida;
                if (double.TryParse(TBPulgadas.Text, out medida))
                {
                    double resultado = medida * 2.54;
                    TBCm.Text = resultado.ToString();
                }
                estaM = false;
            }
        }
    }
}
