namespace Ejercicio7_RelacionVisual
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
            this.TBDiario = new System.Windows.Forms.TextBox();
            this.TBDia = new System.Windows.Forms.TextBox();
            this.TBMes = new System.Windows.Forms.TextBox();
            this.TBAnno = new System.Windows.Forms.TextBox();
            this.BTAtras = new System.Windows.Forms.Button();
            this.BTSig = new System.Windows.Forms.Button();
            this.BTGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBDiario
            // 
            this.TBDiario.Location = new System.Drawing.Point(12, 41);
            this.TBDiario.Multiline = true;
            this.TBDiario.Name = "TBDiario";
            this.TBDiario.Size = new System.Drawing.Size(260, 146);
            this.TBDiario.TabIndex = 0;
            this.TBDiario.TextChanged += new System.EventHandler(this.TBDiario_TextChanged);
            // 
            // TBDia
            // 
            this.TBDia.Location = new System.Drawing.Point(184, 15);
            this.TBDia.Name = "TBDia";
            this.TBDia.Size = new System.Drawing.Size(21, 20);
            this.TBDia.TabIndex = 1;
            this.TBDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBMes
            // 
            this.TBMes.Location = new System.Drawing.Point(211, 15);
            this.TBMes.Name = "TBMes";
            this.TBMes.Size = new System.Drawing.Size(23, 20);
            this.TBMes.TabIndex = 2;
            this.TBMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBAnno
            // 
            this.TBAnno.Location = new System.Drawing.Point(240, 15);
            this.TBAnno.Name = "TBAnno";
            this.TBAnno.Size = new System.Drawing.Size(32, 20);
            this.TBAnno.TabIndex = 3;
            this.TBAnno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTAtras
            // 
            this.BTAtras.Location = new System.Drawing.Point(12, 193);
            this.BTAtras.Name = "BTAtras";
            this.BTAtras.Size = new System.Drawing.Size(75, 23);
            this.BTAtras.TabIndex = 4;
            this.BTAtras.Text = "Atras";
            this.BTAtras.UseVisualStyleBackColor = true;
            this.BTAtras.Click += new System.EventHandler(this.BTAtras_Click);
            // 
            // BTSig
            // 
            this.BTSig.Location = new System.Drawing.Point(197, 193);
            this.BTSig.Name = "BTSig";
            this.BTSig.Size = new System.Drawing.Size(75, 23);
            this.BTSig.TabIndex = 5;
            this.BTSig.Text = "Siguiente";
            this.BTSig.UseVisualStyleBackColor = true;
            this.BTSig.Click += new System.EventHandler(this.BTSig_Click);
            // 
            // BTGuardar
            // 
            this.BTGuardar.Location = new System.Drawing.Point(103, 226);
            this.BTGuardar.Name = "BTGuardar";
            this.BTGuardar.Size = new System.Drawing.Size(75, 23);
            this.BTGuardar.TabIndex = 6;
            this.BTGuardar.Text = "Guardar";
            this.BTGuardar.UseVisualStyleBackColor = true;
            this.BTGuardar.Click += new System.EventHandler(this.BTGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTGuardar);
            this.Controls.Add(this.BTSig);
            this.Controls.Add(this.BTAtras);
            this.Controls.Add(this.TBAnno);
            this.Controls.Add(this.TBMes);
            this.Controls.Add(this.TBDia);
            this.Controls.Add(this.TBDiario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBDiario;
        private System.Windows.Forms.TextBox TBDia;
        private System.Windows.Forms.TextBox TBMes;
        private System.Windows.Forms.TextBox TBAnno;
        private System.Windows.Forms.Button BTAtras;
        private System.Windows.Forms.Button BTSig;
        private System.Windows.Forms.Button BTGuardar;
    }
}

