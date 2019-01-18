namespace Ejercicio11_RelacionVisual
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
            this.NUDNumDados = new System.Windows.Forms.NumericUpDown();
            this.NUDNumCaras = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBTiradas = new System.Windows.Forms.ListBox();
            this.TBSuma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTTirar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumCaras)).BeginInit();
            this.SuspendLayout();
            // 
            // NUDNumDados
            // 
            this.NUDNumDados.Location = new System.Drawing.Point(86, 50);
            this.NUDNumDados.Name = "NUDNumDados";
            this.NUDNumDados.Size = new System.Drawing.Size(64, 20);
            this.NUDNumDados.TabIndex = 0;
            // 
            // NUDNumCaras
            // 
            this.NUDNumCaras.Location = new System.Drawing.Point(86, 97);
            this.NUDNumCaras.Name = "NUDNumCaras";
            this.NUDNumCaras.Size = new System.Drawing.Size(64, 20);
            this.NUDNumCaras.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nº de Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nº de Caras";
            // 
            // LBTiradas
            // 
            this.LBTiradas.FormattingEnabled = true;
            this.LBTiradas.Location = new System.Drawing.Point(12, 128);
            this.LBTiradas.Name = "LBTiradas";
            this.LBTiradas.Size = new System.Drawing.Size(218, 95);
            this.LBTiradas.TabIndex = 4;
            // 
            // TBSuma
            // 
            this.TBSuma.Location = new System.Drawing.Point(154, 229);
            this.TBSuma.Name = "TBSuma";
            this.TBSuma.Size = new System.Drawing.Size(42, 20);
            this.TBSuma.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado de las tiradas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Generador De Tiradas";
            // 
            // BTTirar
            // 
            this.BTTirar.Location = new System.Drawing.Point(176, 88);
            this.BTTirar.Name = "BTTirar";
            this.BTTirar.Size = new System.Drawing.Size(54, 29);
            this.BTTirar.TabIndex = 8;
            this.BTTirar.Text = "Tirar";
            this.BTTirar.UseVisualStyleBackColor = true;
            this.BTTirar.Click += new System.EventHandler(this.BTTirar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 261);
            this.Controls.Add(this.BTTirar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBSuma);
            this.Controls.Add(this.LBTiradas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUDNumCaras);
            this.Controls.Add(this.NUDNumDados);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumCaras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUDNumDados;
        private System.Windows.Forms.NumericUpDown NUDNumCaras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LBTiradas;
        private System.Windows.Forms.TextBox TBSuma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTTirar;
    }
}

