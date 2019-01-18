namespace Ejercicio5_RelacionVisual
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBCm = new System.Windows.Forms.TextBox();
            this.TBPulgadas = new System.Windows.Forms.TextBox();
            this.LBCm = new System.Windows.Forms.Label();
            this.LBPulgadas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBCm
            // 
            this.TBCm.Location = new System.Drawing.Point(12, 70);
            this.TBCm.Name = "TBCm";
            this.TBCm.Size = new System.Drawing.Size(88, 20);
            this.TBCm.TabIndex = 0;
            this.TBCm.TextChanged += new System.EventHandler(this.TBCm_TextChanged);
            // 
            // TBPulgadas
            // 
            this.TBPulgadas.Location = new System.Drawing.Point(133, 70);
            this.TBPulgadas.Name = "TBPulgadas";
            this.TBPulgadas.Size = new System.Drawing.Size(83, 20);
            this.TBPulgadas.TabIndex = 1;
            this.TBPulgadas.TextChanged += new System.EventHandler(this.TBPulgadas_TextChanged);
            // 
            // LBCm
            // 
            this.LBCm.AutoSize = true;
            this.LBCm.Location = new System.Drawing.Point(106, 73);
            this.LBCm.Name = "LBCm";
            this.LBCm.Size = new System.Drawing.Size(21, 13);
            this.LBCm.TabIndex = 2;
            this.LBCm.Text = "cm";
            // 
            // LBPulgadas
            // 
            this.LBPulgadas.AutoSize = true;
            this.LBPulgadas.Location = new System.Drawing.Point(222, 73);
            this.LBPulgadas.Name = "LBPulgadas";
            this.LBPulgadas.Size = new System.Drawing.Size(50, 13);
            this.LBPulgadas.TabIndex = 3;
            this.LBPulgadas.Text = "pulgadas";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conversor Pulgadas/Cm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 110);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBPulgadas);
            this.Controls.Add(this.LBCm);
            this.Controls.Add(this.TBPulgadas);
            this.Controls.Add(this.TBCm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBCm;
        private System.Windows.Forms.TextBox TBPulgadas;
        private System.Windows.Forms.Label LBCm;
        private System.Windows.Forms.Label LBPulgadas;
        private System.Windows.Forms.Label label1;
    }
}

