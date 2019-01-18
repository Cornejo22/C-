namespace Ejercicio6_RelacionVisual
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
            this.TBEsp = new System.Windows.Forms.TextBox();
            this.TBIng = new System.Windows.Forms.TextBox();
            this.BTTraduIngles = new System.Windows.Forms.Button();
            this.BTTraduceEsp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBEsp
            // 
            this.TBEsp.Location = new System.Drawing.Point(12, 25);
            this.TBEsp.Multiline = true;
            this.TBEsp.Name = "TBEsp";
            this.TBEsp.Size = new System.Drawing.Size(146, 141);
            this.TBEsp.TabIndex = 0;
            this.TBEsp.TextChanged += new System.EventHandler(this.TBEsp_TextChanged);
            // 
            // TBIng
            // 
            this.TBIng.Location = new System.Drawing.Point(245, 25);
            this.TBIng.Multiline = true;
            this.TBIng.Name = "TBIng";
            this.TBIng.Size = new System.Drawing.Size(146, 141);
            this.TBIng.TabIndex = 1;
            this.TBIng.TextChanged += new System.EventHandler(this.TBIng_TextChanged);
            // 
            // BTTraduIngles
            // 
            this.BTTraduIngles.Location = new System.Drawing.Point(164, 25);
            this.BTTraduIngles.Name = "BTTraduIngles";
            this.BTTraduIngles.Size = new System.Drawing.Size(75, 23);
            this.BTTraduIngles.TabIndex = 2;
            this.BTTraduIngles.Text = "--->";
            this.BTTraduIngles.UseVisualStyleBackColor = true;
            this.BTTraduIngles.Click += new System.EventHandler(this.BTTraduIngles_Click);
            // 
            // BTTraduceEsp
            // 
            this.BTTraduceEsp.Location = new System.Drawing.Point(164, 73);
            this.BTTraduceEsp.Name = "BTTraduceEsp";
            this.BTTraduceEsp.Size = new System.Drawing.Size(75, 23);
            this.BTTraduceEsp.TabIndex = 3;
            this.BTTraduceEsp.Text = "<---";
            this.BTTraduceEsp.UseVisualStyleBackColor = true;
            this.BTTraduceEsp.Click += new System.EventHandler(this.BTTraduceEsp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Español";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingles";
            // 
            // BTLimpiar
            // 
            this.BTLimpiar.Location = new System.Drawing.Point(164, 122);
            this.BTLimpiar.Name = "BTLimpiar";
            this.BTLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BTLimpiar.TabIndex = 6;
            this.BTLimpiar.Text = "Limpiar";
            this.BTLimpiar.UseVisualStyleBackColor = true;
            this.BTLimpiar.Click += new System.EventHandler(this.BTLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 177);
            this.Controls.Add(this.BTLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTTraduceEsp);
            this.Controls.Add(this.BTTraduIngles);
            this.Controls.Add(this.TBIng);
            this.Controls.Add(this.TBEsp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBEsp;
        private System.Windows.Forms.TextBox TBIng;
        private System.Windows.Forms.Button BTTraduIngles;
        private System.Windows.Forms.Button BTTraduceEsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTLimpiar;
    }
}

