namespace Ejercicio8_RelacionVisual
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBVocal = new System.Windows.Forms.Label();
            this.BTCentrar = new System.Windows.Forms.Button();
            this.BTAbajo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTArriba = new System.Windows.Forms.Button();
            this.BTIzq = new System.Windows.Forms.Button();
            this.BTDerA = new System.Windows.Forms.Button();
            this.BTDer = new System.Windows.Forms.Button();
            this.BTDerAbajo = new System.Windows.Forms.Button();
            this.BTIzqAbajo = new System.Windows.Forms.Button();
            this.BTIzqA = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBVocal
            // 
            this.LBVocal.AutoSize = true;
            this.LBVocal.Location = new System.Drawing.Point(123, 50);
            this.LBVocal.Name = "LBVocal";
            this.LBVocal.Size = new System.Drawing.Size(15, 13);
            this.LBVocal.TabIndex = 0;
            this.LBVocal.Text = "O";
            // 
            // BTCentrar
            // 
            this.BTCentrar.Location = new System.Drawing.Point(105, 186);
            this.BTCentrar.Name = "BTCentrar";
            this.BTCentrar.Size = new System.Drawing.Size(75, 23);
            this.BTCentrar.TabIndex = 1;
            this.BTCentrar.Text = "Centrar";
            this.BTCentrar.UseVisualStyleBackColor = true;
            this.BTCentrar.Click += new System.EventHandler(this.BTCentrar_Click);
            // 
            // BTAbajo
            // 
            this.BTAbajo.Location = new System.Drawing.Point(105, 227);
            this.BTAbajo.Name = "BTAbajo";
            this.BTAbajo.Size = new System.Drawing.Size(75, 23);
            this.BTAbajo.TabIndex = 2;
            this.BTAbajo.Text = "↓";
            this.BTAbajo.UseVisualStyleBackColor = true;
            this.BTAbajo.Click += new System.EventHandler(this.BTAbajo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.LBVocal);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 113);
            this.panel1.TabIndex = 3;
            // 
            // BTArriba
            // 
            this.BTArriba.Location = new System.Drawing.Point(105, 141);
            this.BTArriba.Name = "BTArriba";
            this.BTArriba.Size = new System.Drawing.Size(75, 23);
            this.BTArriba.TabIndex = 4;
            this.BTArriba.Text = " ↑ ";
            this.BTArriba.UseVisualStyleBackColor = true;
            this.BTArriba.Click += new System.EventHandler(this.BTArriba_Click);
            // 
            // BTIzq
            // 
            this.BTIzq.Location = new System.Drawing.Point(12, 186);
            this.BTIzq.Name = "BTIzq";
            this.BTIzq.Size = new System.Drawing.Size(75, 23);
            this.BTIzq.TabIndex = 5;
            this.BTIzq.Text = "← ";
            this.BTIzq.UseVisualStyleBackColor = true;
            this.BTIzq.Click += new System.EventHandler(this.BTIzq_Click);
            // 
            // BTDerA
            // 
            this.BTDerA.Location = new System.Drawing.Point(197, 141);
            this.BTDerA.Name = "BTDerA";
            this.BTDerA.Size = new System.Drawing.Size(75, 23);
            this.BTDerA.TabIndex = 6;
            this.BTDerA.Text = "↗";
            this.BTDerA.UseVisualStyleBackColor = true;
            this.BTDerA.Click += new System.EventHandler(this.BTDerA_Click);
            // 
            // BTDer
            // 
            this.BTDer.Location = new System.Drawing.Point(197, 186);
            this.BTDer.Name = "BTDer";
            this.BTDer.Size = new System.Drawing.Size(75, 23);
            this.BTDer.TabIndex = 7;
            this.BTDer.Text = "→";
            this.BTDer.UseVisualStyleBackColor = true;
            this.BTDer.Click += new System.EventHandler(this.BTDer_Click);
            // 
            // BTDerAbajo
            // 
            this.BTDerAbajo.Location = new System.Drawing.Point(197, 227);
            this.BTDerAbajo.Name = "BTDerAbajo";
            this.BTDerAbajo.Size = new System.Drawing.Size(75, 23);
            this.BTDerAbajo.TabIndex = 8;
            this.BTDerAbajo.Text = "↘";
            this.BTDerAbajo.UseVisualStyleBackColor = true;
            this.BTDerAbajo.Click += new System.EventHandler(this.BTDerAbajo_Click);
            // 
            // BTIzqAbajo
            // 
            this.BTIzqAbajo.Location = new System.Drawing.Point(12, 227);
            this.BTIzqAbajo.Name = "BTIzqAbajo";
            this.BTIzqAbajo.Size = new System.Drawing.Size(75, 23);
            this.BTIzqAbajo.TabIndex = 9;
            this.BTIzqAbajo.Text = "↙";
            this.BTIzqAbajo.UseVisualStyleBackColor = true;
            this.BTIzqAbajo.Click += new System.EventHandler(this.BTIzqAbajo_Click);
            // 
            // BTIzqA
            // 
            this.BTIzqA.Location = new System.Drawing.Point(12, 141);
            this.BTIzqA.Name = "BTIzqA";
            this.BTIzqA.Size = new System.Drawing.Size(75, 23);
            this.BTIzqA.TabIndex = 10;
            this.BTIzqA.Text = "↖";
            this.BTIzqA.UseVisualStyleBackColor = true;
            this.BTIzqA.Click += new System.EventHandler(this.BTIzqA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BTIzqA);
            this.Controls.Add(this.BTIzqAbajo);
            this.Controls.Add(this.BTDerAbajo);
            this.Controls.Add(this.BTDer);
            this.Controls.Add(this.BTDerA);
            this.Controls.Add(this.BTIzq);
            this.Controls.Add(this.BTArriba);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTAbajo);
            this.Controls.Add(this.BTCentrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBVocal;
        private System.Windows.Forms.Button BTCentrar;
        private System.Windows.Forms.Button BTAbajo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTArriba;
        private System.Windows.Forms.Button BTIzq;
        private System.Windows.Forms.Button BTDerA;
        private System.Windows.Forms.Button BTDer;
        private System.Windows.Forms.Button BTDerAbajo;
        private System.Windows.Forms.Button BTIzqAbajo;
        private System.Windows.Forms.Button BTIzqA;
    }
}

