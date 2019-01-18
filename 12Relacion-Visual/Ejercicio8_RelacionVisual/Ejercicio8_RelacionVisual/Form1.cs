using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8_RelacionVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTCentrar_Click(object sender, EventArgs e)
        {
            LBVocal.Location = new Point(123,50);
        }

        private void BTIzq_Click(object sender, EventArgs e)
        {
            LBVocal.Left = LBVocal.Left - 10;
        }

        private void BTDer_Click(object sender, EventArgs e)
        {
            LBVocal.Left = LBVocal.Left + 10;
        }

        private void BTArriba_Click(object sender, EventArgs e)
        {
            LBVocal.Top = LBVocal.Top - 10;
        }

        private void BTAbajo_Click(object sender, EventArgs e)
        {
            LBVocal.Top = LBVocal.Top + 10;
        }

        private void BTIzqA_Click(object sender, EventArgs e)
        {
            LBVocal.Left = LBVocal.Left - 10;
            LBVocal.Top = LBVocal.Top - 10;
        }

        private void BTDerA_Click(object sender, EventArgs e)
        {
            LBVocal.Top = LBVocal.Top - 10;
            LBVocal.Left = LBVocal.Left + 10;
        }

        private void BTIzqAbajo_Click(object sender, EventArgs e)
        {
            LBVocal.Left = LBVocal.Left - 10;
            LBVocal.Top = LBVocal.Top + 10;
        }

        private void BTDerAbajo_Click(object sender, EventArgs e)
        {
            LBVocal.Left = LBVocal.Left + 10;
            LBVocal.Top = LBVocal.Top + 10;
        }
    }
}
