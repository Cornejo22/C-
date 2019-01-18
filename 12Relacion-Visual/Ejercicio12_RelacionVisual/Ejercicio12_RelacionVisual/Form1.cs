using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio12_RelacionVisual
{
    public partial class Form1 : Form
    {
        RadioButton[] RBlongitudes;
        RadioButton[] RBdinero;
        string click;        
        public Form1()
        {
            InitializeComponent();

            RBdinero = new RadioButton[] { RBDolares, RBDolares2, RBEuros, RBEuros2, RBLibras, RBLibras2 };
            RBlongitudes = new RadioButton[] { RBKm, RBKm2, RBHm, RBHm2, RBDam,
                RBDam2, RBMetros, RBM2, RBDm, RBDm2, RBCm, RBCm2, RBMm, RBMm2 };
        }

        public void DesactivaRB()
        {
            for(int i = 0; i < RBdinero.Length;i++)
            {
                RBdinero[i].Checked = false;
                RBdinero[i].Enabled = false;
            }

            for (int i = 0; i < RBlongitudes.Length; i++)
            {
                RBlongitudes[i].Checked = false;
                RBlongitudes[i].Enabled = false;
            }
           
        }

        #region "clickL"
        private void BTLongitudes_Click(object sender, EventArgs e)
        {
            LBValor.Text = "";
            LBValor2.Text = "";
            click = "longitud";
            TBActualizar.Clear();
            TBActualizado.Clear();
            TBActualizar.Enabled = true;

            //RBKm.Enabled = true;
            //RBKm2.Enabled = true;
            //RBHm.Enabled = true;
            //RBHm2.Enabled = true;
            //RBDam.Enabled = true;
            //RBDam2.Enabled = true;
            //RBMetros.Enabled = true;
            //RBM2.Enabled = true;
            //RBCm.Enabled = true;
            //RBCm2.Enabled = true;
            //RBDm.Enabled = true;
            //RBDm2.Enabled = true;
            //RBMm.Enabled = true;
            //RBMm2.Enabled = true;

            //RBDolares.Enabled = false;
            //RBDolares2.Enabled = false;
            //RBEuros.Enabled = false;
            //RBEuros2.Enabled = false;
            //RBLibras.Enabled = false;
            //RBLibras2.Enabled = false;

            DesactivaRB();
        }
        #endregion

        #region "clickDinero"
        private void BTDinero_Click(object sender, EventArgs e)
        {
            click = "dinero";
            LBValor.Text = "";
            LBValor2.Text = "";
            TBActualizar.Clear();
            TBActualizado.Clear();
            TBActualizar.Enabled = true;

            //RBDolares.Enabled = false;
            //RBDolares2.Enabled = false;
            //RBEuros.Enabled = false;
            //RBEuros2.Enabled = false;
            //RBLibras.Enabled = false;
            //RBLibras2.Enabled = false;

            //RBKm.Enabled = false;
            //RBKm2.Enabled = false;
            //RBHm.Enabled = false;
            //RBHm2.Enabled = false;
            //RBDam.Enabled = false;
            //RBDam2.Enabled = false;
            //RBMetros.Enabled = false;
            //RBM2.Enabled = false;
            //RBCm.Enabled = false;
            //RBCm2.Enabled = false;
            //RBDm.Enabled = false;
            //RBDm2.Enabled = false;
            //RBMm.Enabled = false;
            //RBMm2.Enabled = false;

            DesactivaRB();
        }

        #endregion

        #region "CargaF"
        private void Form1_Load(object sender, EventArgs e)
        {
            TBActualizado.Enabled = false;
            TBActualizar.Enabled = false;
            RBKm.Enabled = false;
            RBKm2.Enabled = false;
            RBHm.Enabled = false;
            RBHm2.Enabled = false;
            RBDam.Enabled = false;
            RBDam2.Enabled = false;
            RBMetros.Enabled = false;
            RBM2.Enabled = false;
            RBCm.Enabled = false;
            RBCm2.Enabled = false;
            RBDm.Enabled = false;
            RBDm2.Enabled = false;
            RBMm.Enabled = false;
            RBMm2.Enabled = false;

            RBDolares.Enabled = false;
            RBDolares2.Enabled = false;
            RBEuros.Enabled = false;
            RBEuros2.Enabled = false;
            RBLibras.Enabled = false;
            RBLibras2.Enabled = false;
        }
        #endregion

        #region "chequearCambios"
        private void RBKm_CheckedChanged(object sender, EventArgs e)
        {
            if (RBKm.Checked)
            {
                LBValor.Text = "Km";
                Actualizar();
            }
        }

        private void RBHm_CheckedChanged(object sender, EventArgs e)
        {
            if (RBHm.Checked)
            {
                LBValor.Text = "Hm";
                Actualizar();
            }
        }

        private void RBDam_CheckedChanged(object sender, EventArgs e)
        {
            if (RBDam.Checked)
            {
                LBValor.Text = "Dam";
                Actualizar();
            }
        }

        private void RBMetros_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMetros.Checked)
            {
                LBValor.Text = "M";
                Actualizar();
            }
        }

        private void RBDm_CheckedChanged(object sender, EventArgs e)
        {
            if (RBDm.Checked)
            {
                LBValor.Text = "Dm";
                Actualizar();
            }
        }

        private void RBCm_CheckedChanged(object sender, EventArgs e)
        {
            if (RBCm.Checked)
            {
                LBValor.Text = "Cm";
                Actualizar();
            }
        }

        private void RBMm_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMm.Checked)
            {
                LBValor.Text = "Mm";
                Actualizar();
            }
        }

        private void RBEuros_CheckedChanged(object sender, EventArgs e)
        {
            if (RBEuros.Checked)
            {
                LBValor.Text = "€";
                Actualizar();
            }
        }

        private void RBLibras_CheckedChanged(object sender, EventArgs e)
        {
            if (RBLibras.Checked)
            {
                LBValor.Text = "£";
                Actualizar();
            }
        }

        private void RBDolares_CheckedChanged(object sender, EventArgs e)
        {
            if (RBDolares.Checked)
            {
                LBValor.Text = "$";
                Actualizar();
            }
        }

        private void RBKm2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBKm2.Checked)
            {
                LBValor2.Text = "Km";
                Actualizar();
            }
        }

        private void RBHm2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBHm2.Checked)
            {
                LBValor2.Text = "Hm";
                Actualizar();
            }
        }

        private void RBDam2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBDam2.Checked)
            {
                LBValor2.Text = "Dam";
                Actualizar();
            }
        }

        private void RBM2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBM2.Checked)
            {
                LBValor2.Text = "M";
                Actualizar();
            }
        }

        private void RBDm2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBDm2.Checked)
            {
                LBValor2.Text = "Dm";
                Actualizar();
            }
        }

        private void RBCm2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBCm2.Checked)
            {
                LBValor2.Text = "Cm";
                Actualizar();
            }
        }

        private void RBMm2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMm2.Checked)
            {
                LBValor2.Text = "Mm";
                Actualizar();
            }
        }

        private void RBEuros2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBEuros2.Checked)
            {
                LBValor2.Text = "€";
                Actualizar();
            }
        }

        private void RBLibras2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBLibras2.Checked)
            {
                LBValor2.Text = "£";
                Actualizar();
            }
        }

        private void RBDolares2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBDolares2.Checked)
            {
                LBValor2.Text = "$";
                Actualizar();
            }
        }

        #endregion

        private void Actualizar()
        {
            decimal valor1, valor2;

            #region "actualizarDinero"
            if (click == "dinero")
            {
                if (decimal.TryParse(TBActualizar.Text, out valor1) &&
                  (RBEuros.Checked || RBDolares.Checked || RBLibras.Checked) &&
            (RBEuros2.Checked || RBDolares2.Checked || RBLibras2.Checked))
                {
                    TBActualizado.Text = TBActualizar.Text;
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBEuros.Checked && RBLibras2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 0.782222m;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBEuros.Checked && RBDolares2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 1.1275m;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBLibras.Checked && RBEuros2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 1.27883m;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBLibras.Checked && RBDolares2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 1.44365m;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBDolares.Checked && RBEuros2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 0.88691796m;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBDolares.Checked && RBLibras2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 0.692688671m;
                    TBActualizado.Text = valor2.ToString();
                }

            }
            #endregion

            #region "longitud"
            if (click == "longitud")
            {
                if (decimal.TryParse(TBActualizar.Text, out valor1) &&
                 (RBKm.Checked || RBHm.Checked || RBDam.Checked || RBMetros.Checked || RBDm.Checked || RBCm.Checked || RBDm.Checked) &&
           (RBKm2.Checked || RBHm2.Checked || RBDam2.Checked || RBM2.Checked || RBDm2.Checked || RBCm2.Checked || RBDm2.Checked))
                {
                    TBActualizado.Text = TBActualizar.Text;
                }
                #region "Km"
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBKm.Checked && RBHm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 10;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBKm.Checked && RBDam2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 100;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBKm.Checked && RBM2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 1000;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBKm.Checked && RBDm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 10000;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBKm.Checked && RBCm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 100000;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBKm.Checked && RBMm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 1000000;
                    TBActualizado.Text = valor2.ToString();
                }
                #endregion

                #region "Hm"
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBHm.Checked && RBKm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 10;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBHm.Checked && RBDam2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 10;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBHm.Checked && RBM2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 100;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBHm.Checked && RBDm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 1000;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBHm.Checked && RBCm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 10000;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBHm.Checked && RBMm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 100000;
                    TBActualizado.Text = valor2.ToString();
                }

                #endregion

                #region "Dam"
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBDam.Checked && RBKm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 100;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBDam.Checked && RBHm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 10;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBDam.Checked && RBM2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 10;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBDam.Checked && RBDm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 100;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBDam.Checked && RBCm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 1000;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBDam.Checked && RBMm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 10000;
                    TBActualizado.Text = valor2.ToString();
                }
                #endregion

                #region "Metros"
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBMetros.Checked && RBKm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 1000;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBMetros.Checked && RBHm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 100;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                    (RBMetros.Checked && RBDam2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 10;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBMetros.Checked && RBDm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 10;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBMetros.Checked && RBCm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 100;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBMetros.Checked && RBMm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 1000;
                    TBActualizado.Text = valor2.ToString();
                }
                #endregion

                #region "Dm"
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBDm.Checked && RBKm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 10000;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBDm.Checked && RBHm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 1000;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBDm.Checked && RBDam2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 100;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBDm.Checked && RBM2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 10;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBDm.Checked && RBCm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 10;
                    TBActualizado.Text = valor2.ToString();
                }

                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBDm.Checked && RBMm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 100;
                    TBActualizado.Text = valor2.ToString();
                }

                #endregion

                #region"Cm"
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                      (RBCm.Checked && RBKm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 100000;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                      (RBCm.Checked && RBHm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 10000;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                      (RBCm.Checked && RBDam2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 1000;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                      (RBCm.Checked && RBM2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 100;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                      (RBCm.Checked && RBDm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 10;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                      (RBCm.Checked && RBMm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) * 10;
                    TBActualizado.Text = valor2.ToString();
                }
                #endregion

                #region "Dm"
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                      (RBMm.Checked && RBKm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 1000000;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                     (RBMm.Checked && RBHm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 100000;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                     (RBMm.Checked && RBDam2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 10000;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                     (RBMm.Checked && RBM2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 1000;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBMm.Checked && RBDm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 100;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBMm.Checked && RBCm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text) / 10;
                    TBActualizado.Text = valor2.ToString();
                }
                if ((decimal.TryParse(TBActualizar.Text, out valor2)) &&
                   (RBMm.Checked && RBMm2.Checked))
                {
                    valor2 = decimal.Parse(TBActualizar.Text);
                    TBActualizado.Text = valor2.ToString();
                }
                #endregion

                #endregion

            }
        }

        private void TBActualizar_TextChanged(object sender, EventArgs e)
        {
            bool activar = !string.IsNullOrEmpty(TBActualizar.Text);
            if (click == "longitud")
            {
                RBKm.Enabled = activar;
                RBKm2.Enabled = activar;
                RBHm.Enabled = activar;
                RBHm2.Enabled = activar;
                RBDam.Enabled = activar;
                RBDam2.Enabled = activar;
                RBMetros.Enabled = activar;
                RBM2.Enabled = activar;
                RBCm.Enabled = activar;
                RBCm2.Enabled = activar;
                RBDm.Enabled = activar;
                RBDm2.Enabled = activar;
                RBMm.Enabled = activar;
                RBMm2.Enabled = activar;
            }
            if(click == "dinero")
            {
                RBDolares.Enabled = activar;
                RBDolares2.Enabled = activar;
                RBEuros.Enabled = activar;
                RBEuros2.Enabled = activar;
                RBLibras.Enabled = activar;
                RBLibras2.Enabled = activar;
            }

        }
    }
}
