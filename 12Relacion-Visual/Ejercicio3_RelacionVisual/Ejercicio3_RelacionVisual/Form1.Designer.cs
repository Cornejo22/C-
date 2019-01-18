namespace Ejercicio3_RelacionVisual
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
            this.TBoperador1 = new System.Windows.Forms.TextBox();
            this.TBoperador2 = new System.Windows.Forms.TextBox();
            this.TBresultado = new System.Windows.Forms.TextBox();
            this.BTSuma = new System.Windows.Forms.Button();
            this.BTResta = new System.Windows.Forms.Button();
            this.BTMultiplicacion = new System.Windows.Forms.Button();
            this.BTDivision = new System.Windows.Forms.Button();
            this.Etiqueta = new System.Windows.Forms.Label();
            this.EtiquetaSigno = new System.Windows.Forms.Label();
            this.EtiquetaIgual = new System.Windows.Forms.Label();
            this.BTLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBoperador1
            // 
            this.TBoperador1.Location = new System.Drawing.Point(12, 68);
            this.TBoperador1.Name = "TBoperador1";
            this.TBoperador1.Size = new System.Drawing.Size(55, 20);
            this.TBoperador1.TabIndex = 0;
            this.TBoperador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBoperador1.TextChanged += new System.EventHandler(this.TBoperador1_TextChanged);
            // 
            // TBoperador2
            // 
            this.TBoperador2.Location = new System.Drawing.Point(113, 68);
            this.TBoperador2.Name = "TBoperador2";
            this.TBoperador2.Size = new System.Drawing.Size(60, 20);
            this.TBoperador2.TabIndex = 1;
            this.TBoperador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBoperador2.TextChanged += new System.EventHandler(this.TBoperador2_TextChanged);
            // 
            // TBresultado
            // 
            this.TBresultado.Location = new System.Drawing.Point(218, 68);
            this.TBresultado.Name = "TBresultado";
            this.TBresultado.Size = new System.Drawing.Size(74, 20);
            this.TBresultado.TabIndex = 2;
            this.TBresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTSuma
            // 
            this.BTSuma.Location = new System.Drawing.Point(54, 118);
            this.BTSuma.Name = "BTSuma";
            this.BTSuma.Size = new System.Drawing.Size(62, 23);
            this.BTSuma.TabIndex = 3;
            this.BTSuma.Text = "+";
            this.BTSuma.UseVisualStyleBackColor = true;
            this.BTSuma.Click += new System.EventHandler(this.BTSuma_Click);
            // 
            // BTResta
            // 
            this.BTResta.Location = new System.Drawing.Point(55, 168);
            this.BTResta.Name = "BTResta";
            this.BTResta.Size = new System.Drawing.Size(61, 23);
            this.BTResta.TabIndex = 4;
            this.BTResta.Text = "-";
            this.BTResta.UseVisualStyleBackColor = true;
            this.BTResta.Click += new System.EventHandler(this.BTResta_Click);
            // 
            // BTMultiplicacion
            // 
            this.BTMultiplicacion.Location = new System.Drawing.Point(155, 118);
            this.BTMultiplicacion.Name = "BTMultiplicacion";
            this.BTMultiplicacion.Size = new System.Drawing.Size(57, 23);
            this.BTMultiplicacion.TabIndex = 5;
            this.BTMultiplicacion.Text = "x";
            this.BTMultiplicacion.UseVisualStyleBackColor = true;
            this.BTMultiplicacion.Click += new System.EventHandler(this.BTMultiplicacion_Click);
            // 
            // BTDivision
            // 
            this.BTDivision.Location = new System.Drawing.Point(155, 168);
            this.BTDivision.Name = "BTDivision";
            this.BTDivision.Size = new System.Drawing.Size(57, 23);
            this.BTDivision.TabIndex = 6;
            this.BTDivision.Text = "/";
            this.BTDivision.UseVisualStyleBackColor = true;
            this.BTDivision.Click += new System.EventHandler(this.BTDivision_Click);
            // 
            // Etiqueta
            // 
            this.Etiqueta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Etiqueta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Etiqueta.Location = new System.Drawing.Point(55, 218);
            this.Etiqueta.Name = "Etiqueta";
            this.Etiqueta.Size = new System.Drawing.Size(157, 34);
            this.Etiqueta.TabIndex = 7;
            this.Etiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EtiquetaSigno
            // 
            this.EtiquetaSigno.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EtiquetaSigno.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EtiquetaSigno.Location = new System.Drawing.Point(73, 68);
            this.EtiquetaSigno.Name = "EtiquetaSigno";
            this.EtiquetaSigno.Size = new System.Drawing.Size(34, 20);
            this.EtiquetaSigno.TabIndex = 8;
            this.EtiquetaSigno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EtiquetaIgual
            // 
            this.EtiquetaIgual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EtiquetaIgual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EtiquetaIgual.Location = new System.Drawing.Point(180, 68);
            this.EtiquetaIgual.Name = "EtiquetaIgual";
            this.EtiquetaIgual.Size = new System.Drawing.Size(32, 20);
            this.EtiquetaIgual.TabIndex = 9;
            this.EtiquetaIgual.Text = "=";
            this.EtiquetaIgual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTLimpiar
            // 
            this.BTLimpiar.Location = new System.Drawing.Point(238, 144);
            this.BTLimpiar.Name = "BTLimpiar";
            this.BTLimpiar.Size = new System.Drawing.Size(54, 23);
            this.BTLimpiar.TabIndex = 10;
            this.BTLimpiar.Text = "Limpiar";
            this.BTLimpiar.UseVisualStyleBackColor = true;
            this.BTLimpiar.Click += new System.EventHandler(this.BTLimpiar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Calculadora";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTLimpiar);
            this.Controls.Add(this.EtiquetaIgual);
            this.Controls.Add(this.EtiquetaSigno);
            this.Controls.Add(this.Etiqueta);
            this.Controls.Add(this.BTDivision);
            this.Controls.Add(this.BTMultiplicacion);
            this.Controls.Add(this.BTResta);
            this.Controls.Add(this.BTSuma);
            this.Controls.Add(this.TBresultado);
            this.Controls.Add(this.TBoperador2);
            this.Controls.Add(this.TBoperador1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBoperador1;
        private System.Windows.Forms.TextBox TBoperador2;
        private System.Windows.Forms.TextBox TBresultado;
        private System.Windows.Forms.Button BTSuma;
        private System.Windows.Forms.Button BTResta;
        private System.Windows.Forms.Button BTMultiplicacion;
        private System.Windows.Forms.Button BTDivision;
        private System.Windows.Forms.Label Etiqueta;
        private System.Windows.Forms.Label EtiquetaSigno;
        private System.Windows.Forms.Label EtiquetaIgual;
        private System.Windows.Forms.Button BTLimpiar;
        private System.Windows.Forms.Label label1;
    }
}

