namespace Ejercicio4_RelacionVisual
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTMayor = new System.Windows.Forms.Button();
            this.BTAcertado = new System.Windows.Forms.Button();
            this.BTMenor = new System.Windows.Forms.Button();
            this.LBIntentos = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.BTReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adivino";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTMayor
            // 
            this.BTMayor.Location = new System.Drawing.Point(197, 42);
            this.BTMayor.Name = "BTMayor";
            this.BTMayor.Size = new System.Drawing.Size(75, 23);
            this.BTMayor.TabIndex = 1;
            this.BTMayor.Text = "Mayor";
            this.BTMayor.UseVisualStyleBackColor = true;
            this.BTMayor.Click += new System.EventHandler(this.BTMayor_Click);
            // 
            // BTAcertado
            // 
            this.BTAcertado.Location = new System.Drawing.Point(197, 71);
            this.BTAcertado.Name = "BTAcertado";
            this.BTAcertado.Size = new System.Drawing.Size(75, 23);
            this.BTAcertado.TabIndex = 2;
            this.BTAcertado.Text = "Acierto";
            this.BTAcertado.UseVisualStyleBackColor = true;
            this.BTAcertado.Click += new System.EventHandler(this.BTAcertado_Click);
            // 
            // BTMenor
            // 
            this.BTMenor.Location = new System.Drawing.Point(197, 100);
            this.BTMenor.Name = "BTMenor";
            this.BTMenor.Size = new System.Drawing.Size(75, 23);
            this.BTMenor.TabIndex = 3;
            this.BTMenor.Text = "Menor";
            this.BTMenor.UseVisualStyleBackColor = true;
            this.BTMenor.Click += new System.EventHandler(this.BTMenor_Click);
            // 
            // LBIntentos
            // 
            this.LBIntentos.AutoSize = true;
            this.LBIntentos.Location = new System.Drawing.Point(12, 100);
            this.LBIntentos.Name = "LBIntentos";
            this.LBIntentos.Size = new System.Drawing.Size(108, 13);
            this.LBIntentos.TabIndex = 5;
            this.LBIntentos.Text = "Numero de intentos : ";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(12, 64);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(124, 13);
            this.labelNumero.TabIndex = 6;
            this.labelNumero.Text = "El número adivinado : 50";
            this.labelNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTReiniciar
            // 
            this.BTReiniciar.Location = new System.Drawing.Point(197, 130);
            this.BTReiniciar.Name = "BTReiniciar";
            this.BTReiniciar.Size = new System.Drawing.Size(75, 23);
            this.BTReiniciar.TabIndex = 7;
            this.BTReiniciar.Text = "Reiniciar";
            this.BTReiniciar.UseVisualStyleBackColor = true;
            this.BTReiniciar.Click += new System.EventHandler(this.BTReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 172);
            this.Controls.Add(this.BTReiniciar);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.LBIntentos);
            this.Controls.Add(this.BTMenor);
            this.Controls.Add(this.BTAcertado);
            this.Controls.Add(this.BTMayor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTMayor;
        private System.Windows.Forms.Button BTAcertado;
        private System.Windows.Forms.Button BTMenor;
        private System.Windows.Forms.Label LBIntentos;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Button BTReiniciar;
    }
}

