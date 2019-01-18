namespace Ejercicio14_RelacionVisual
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
            this.CBTitulos1 = new System.Windows.Forms.ComboBox();
            this.CBTitulos2 = new System.Windows.Forms.ComboBox();
            this.BTGenerar = new System.Windows.Forms.Button();
            this.LBTituloG = new System.Windows.Forms.Label();
            this.BTAleatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBTitulos1
            // 
            this.CBTitulos1.FormattingEnabled = true;
            this.CBTitulos1.Location = new System.Drawing.Point(30, 129);
            this.CBTitulos1.Name = "CBTitulos1";
            this.CBTitulos1.Size = new System.Drawing.Size(92, 21);
            this.CBTitulos1.TabIndex = 0;
            // 
            // CBTitulos2
            // 
            this.CBTitulos2.FormattingEnabled = true;
            this.CBTitulos2.Location = new System.Drawing.Point(152, 129);
            this.CBTitulos2.Name = "CBTitulos2";
            this.CBTitulos2.Size = new System.Drawing.Size(92, 21);
            this.CBTitulos2.TabIndex = 1;
            // 
            // BTGenerar
            // 
            this.BTGenerar.Location = new System.Drawing.Point(47, 171);
            this.BTGenerar.Name = "BTGenerar";
            this.BTGenerar.Size = new System.Drawing.Size(75, 23);
            this.BTGenerar.TabIndex = 2;
            this.BTGenerar.Text = "Generar";
            this.BTGenerar.UseVisualStyleBackColor = true;
            this.BTGenerar.Click += new System.EventHandler(this.BTGenerar_Click);
            // 
            // LBTituloG
            // 
            this.LBTituloG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBTituloG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTituloG.Location = new System.Drawing.Point(30, 21);
            this.LBTituloG.Name = "LBTituloG";
            this.LBTituloG.Size = new System.Drawing.Size(214, 84);
            this.LBTituloG.TabIndex = 3;
            this.LBTituloG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTAleatorio
            // 
            this.BTAleatorio.Location = new System.Drawing.Point(152, 171);
            this.BTAleatorio.Name = "BTAleatorio";
            this.BTAleatorio.Size = new System.Drawing.Size(75, 23);
            this.BTAleatorio.TabIndex = 4;
            this.BTAleatorio.Text = "Aletorio";
            this.BTAleatorio.UseVisualStyleBackColor = true;
            this.BTAleatorio.Click += new System.EventHandler(this.BTAleatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.BTAleatorio);
            this.Controls.Add(this.LBTituloG);
            this.Controls.Add(this.BTGenerar);
            this.Controls.Add(this.CBTitulos2);
            this.Controls.Add(this.CBTitulos1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBTitulos1;
        private System.Windows.Forms.ComboBox CBTitulos2;
        private System.Windows.Forms.Button BTGenerar;
        private System.Windows.Forms.Label LBTituloG;
        private System.Windows.Forms.Button BTAleatorio;
    }
}

