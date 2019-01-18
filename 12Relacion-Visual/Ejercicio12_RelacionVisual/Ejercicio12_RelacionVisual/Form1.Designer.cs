namespace Ejercicio12_RelacionVisual
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
            this.TBActualizado = new System.Windows.Forms.TextBox();
            this.TBActualizar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RBKm = new System.Windows.Forms.RadioButton();
            this.RBHm = new System.Windows.Forms.RadioButton();
            this.RBDam = new System.Windows.Forms.RadioButton();
            this.RBMetros = new System.Windows.Forms.RadioButton();
            this.RBDm = new System.Windows.Forms.RadioButton();
            this.RBCm = new System.Windows.Forms.RadioButton();
            this.RBMm = new System.Windows.Forms.RadioButton();
            this.LBValor2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBDolares = new System.Windows.Forms.RadioButton();
            this.RBLibras = new System.Windows.Forms.RadioButton();
            this.RBEuros = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBKm2 = new System.Windows.Forms.RadioButton();
            this.RBHm2 = new System.Windows.Forms.RadioButton();
            this.RBMm2 = new System.Windows.Forms.RadioButton();
            this.RBDam2 = new System.Windows.Forms.RadioButton();
            this.RBCm2 = new System.Windows.Forms.RadioButton();
            this.RBM2 = new System.Windows.Forms.RadioButton();
            this.RBDm2 = new System.Windows.Forms.RadioButton();
            this.RBDolares2 = new System.Windows.Forms.RadioButton();
            this.RBLibras2 = new System.Windows.Forms.RadioButton();
            this.RBEuros2 = new System.Windows.Forms.RadioButton();
            this.LBValor = new System.Windows.Forms.Label();
            this.BTLongitudes = new System.Windows.Forms.Button();
            this.BTDinero = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBActualizado
            // 
            this.TBActualizado.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBActualizado.ForeColor = System.Drawing.Color.Black;
            this.TBActualizado.Location = new System.Drawing.Point(173, 103);
            this.TBActualizado.Name = "TBActualizado";
            this.TBActualizado.Size = new System.Drawing.Size(98, 23);
            this.TBActualizado.TabIndex = 0;
            this.TBActualizado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TBActualizar
            // 
            this.TBActualizar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBActualizar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TBActualizar.Location = new System.Drawing.Point(173, 61);
            this.TBActualizar.Name = "TBActualizar";
            this.TBActualizar.Size = new System.Drawing.Size(98, 23);
            this.TBActualizar.TabIndex = 1;
            this.TBActualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBActualizar.TextChanged += new System.EventHandler(this.TBActualizar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "MultiConversor";
            // 
            // RBKm
            // 
            this.RBKm.AutoSize = true;
            this.RBKm.Location = new System.Drawing.Point(7, 23);
            this.RBKm.Name = "RBKm";
            this.RBKm.Size = new System.Drawing.Size(40, 17);
            this.RBKm.TabIndex = 3;
            this.RBKm.TabStop = true;
            this.RBKm.Text = "Km";
            this.RBKm.UseVisualStyleBackColor = true;
            this.RBKm.CheckedChanged += new System.EventHandler(this.RBKm_CheckedChanged);
            // 
            // RBHm
            // 
            this.RBHm.AutoSize = true;
            this.RBHm.Location = new System.Drawing.Point(7, 46);
            this.RBHm.Name = "RBHm";
            this.RBHm.Size = new System.Drawing.Size(41, 17);
            this.RBHm.TabIndex = 4;
            this.RBHm.TabStop = true;
            this.RBHm.Text = "Hm";
            this.RBHm.UseVisualStyleBackColor = true;
            this.RBHm.CheckedChanged += new System.EventHandler(this.RBHm_CheckedChanged);
            // 
            // RBDam
            // 
            this.RBDam.AutoSize = true;
            this.RBDam.Location = new System.Drawing.Point(7, 68);
            this.RBDam.Name = "RBDam";
            this.RBDam.Size = new System.Drawing.Size(47, 17);
            this.RBDam.TabIndex = 5;
            this.RBDam.TabStop = true;
            this.RBDam.Text = "Dam";
            this.RBDam.UseVisualStyleBackColor = true;
            this.RBDam.CheckedChanged += new System.EventHandler(this.RBDam_CheckedChanged);
            // 
            // RBMetros
            // 
            this.RBMetros.AutoSize = true;
            this.RBMetros.Location = new System.Drawing.Point(7, 91);
            this.RBMetros.Name = "RBMetros";
            this.RBMetros.Size = new System.Drawing.Size(34, 17);
            this.RBMetros.TabIndex = 6;
            this.RBMetros.TabStop = true;
            this.RBMetros.Text = "M";
            this.RBMetros.UseVisualStyleBackColor = true;
            this.RBMetros.CheckedChanged += new System.EventHandler(this.RBMetros_CheckedChanged);
            // 
            // RBDm
            // 
            this.RBDm.AutoSize = true;
            this.RBDm.Location = new System.Drawing.Point(7, 114);
            this.RBDm.Name = "RBDm";
            this.RBDm.Size = new System.Drawing.Size(41, 17);
            this.RBDm.TabIndex = 7;
            this.RBDm.TabStop = true;
            this.RBDm.Text = "Dm";
            this.RBDm.UseVisualStyleBackColor = true;
            this.RBDm.CheckedChanged += new System.EventHandler(this.RBDm_CheckedChanged);
            // 
            // RBCm
            // 
            this.RBCm.AutoSize = true;
            this.RBCm.Location = new System.Drawing.Point(7, 137);
            this.RBCm.Name = "RBCm";
            this.RBCm.Size = new System.Drawing.Size(40, 17);
            this.RBCm.TabIndex = 8;
            this.RBCm.TabStop = true;
            this.RBCm.Text = "Cm";
            this.RBCm.UseVisualStyleBackColor = true;
            this.RBCm.CheckedChanged += new System.EventHandler(this.RBCm_CheckedChanged);
            // 
            // RBMm
            // 
            this.RBMm.AutoSize = true;
            this.RBMm.Location = new System.Drawing.Point(7, 159);
            this.RBMm.Name = "RBMm";
            this.RBMm.Size = new System.Drawing.Size(42, 17);
            this.RBMm.TabIndex = 9;
            this.RBMm.TabStop = true;
            this.RBMm.Text = "Mm";
            this.RBMm.UseVisualStyleBackColor = true;
            this.RBMm.CheckedChanged += new System.EventHandler(this.RBMm_CheckedChanged);
            // 
            // LBValor2
            // 
            this.LBValor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBValor2.Location = new System.Drawing.Point(286, 103);
            this.LBValor2.Name = "LBValor2";
            this.LBValor2.Size = new System.Drawing.Size(32, 20);
            this.LBValor2.TabIndex = 10;
            this.LBValor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBKm);
            this.groupBox1.Controls.Add(this.RBHm);
            this.groupBox1.Controls.Add(this.RBMm);
            this.groupBox1.Controls.Add(this.RBDam);
            this.groupBox1.Controls.Add(this.RBCm);
            this.groupBox1.Controls.Add(this.RBMetros);
            this.groupBox1.Controls.Add(this.RBDm);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(73, 178);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Longitudes";
            // 
            // RBDolares
            // 
            this.RBDolares.AutoSize = true;
            this.RBDolares.Location = new System.Drawing.Point(5, 68);
            this.RBDolares.Name = "RBDolares";
            this.RBDolares.Size = new System.Drawing.Size(61, 17);
            this.RBDolares.TabIndex = 12;
            this.RBDolares.TabStop = true;
            this.RBDolares.Text = "Dolares";
            this.RBDolares.UseVisualStyleBackColor = true;
            this.RBDolares.CheckedChanged += new System.EventHandler(this.RBDolares_CheckedChanged);
            // 
            // RBLibras
            // 
            this.RBLibras.AutoSize = true;
            this.RBLibras.Location = new System.Drawing.Point(5, 46);
            this.RBLibras.Name = "RBLibras";
            this.RBLibras.Size = new System.Drawing.Size(53, 17);
            this.RBLibras.TabIndex = 11;
            this.RBLibras.TabStop = true;
            this.RBLibras.Text = "Libras";
            this.RBLibras.UseVisualStyleBackColor = true;
            this.RBLibras.CheckedChanged += new System.EventHandler(this.RBLibras_CheckedChanged);
            // 
            // RBEuros
            // 
            this.RBEuros.AutoSize = true;
            this.RBEuros.Location = new System.Drawing.Point(5, 23);
            this.RBEuros.Name = "RBEuros";
            this.RBEuros.Size = new System.Drawing.Size(52, 17);
            this.RBEuros.TabIndex = 10;
            this.RBEuros.TabStop = true;
            this.RBEuros.Text = "Euros";
            this.RBEuros.UseVisualStyleBackColor = true;
            this.RBEuros.CheckedChanged += new System.EventHandler(this.RBEuros_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBKm2);
            this.groupBox2.Controls.Add(this.RBHm2);
            this.groupBox2.Controls.Add(this.RBMm2);
            this.groupBox2.Controls.Add(this.RBDam2);
            this.groupBox2.Controls.Add(this.RBCm2);
            this.groupBox2.Controls.Add(this.RBM2);
            this.groupBox2.Controls.Add(this.RBDm2);
            this.groupBox2.Location = new System.Drawing.Point(335, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(74, 178);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Longitudes";
            // 
            // RBKm2
            // 
            this.RBKm2.AutoSize = true;
            this.RBKm2.Location = new System.Drawing.Point(6, 23);
            this.RBKm2.Name = "RBKm2";
            this.RBKm2.Size = new System.Drawing.Size(40, 17);
            this.RBKm2.TabIndex = 3;
            this.RBKm2.TabStop = true;
            this.RBKm2.Text = "Km";
            this.RBKm2.UseVisualStyleBackColor = true;
            this.RBKm2.CheckedChanged += new System.EventHandler(this.RBKm2_CheckedChanged);
            // 
            // RBHm2
            // 
            this.RBHm2.AutoSize = true;
            this.RBHm2.Location = new System.Drawing.Point(6, 46);
            this.RBHm2.Name = "RBHm2";
            this.RBHm2.Size = new System.Drawing.Size(41, 17);
            this.RBHm2.TabIndex = 4;
            this.RBHm2.TabStop = true;
            this.RBHm2.Text = "Hm";
            this.RBHm2.UseVisualStyleBackColor = true;
            this.RBHm2.CheckedChanged += new System.EventHandler(this.RBHm2_CheckedChanged);
            // 
            // RBMm2
            // 
            this.RBMm2.AutoSize = true;
            this.RBMm2.Location = new System.Drawing.Point(6, 159);
            this.RBMm2.Name = "RBMm2";
            this.RBMm2.Size = new System.Drawing.Size(42, 17);
            this.RBMm2.TabIndex = 9;
            this.RBMm2.TabStop = true;
            this.RBMm2.Text = "Mm";
            this.RBMm2.UseVisualStyleBackColor = true;
            this.RBMm2.CheckedChanged += new System.EventHandler(this.RBMm2_CheckedChanged);
            // 
            // RBDam2
            // 
            this.RBDam2.AutoSize = true;
            this.RBDam2.Location = new System.Drawing.Point(6, 68);
            this.RBDam2.Name = "RBDam2";
            this.RBDam2.Size = new System.Drawing.Size(47, 17);
            this.RBDam2.TabIndex = 5;
            this.RBDam2.TabStop = true;
            this.RBDam2.Text = "Dam";
            this.RBDam2.UseVisualStyleBackColor = true;
            this.RBDam2.CheckedChanged += new System.EventHandler(this.RBDam2_CheckedChanged);
            // 
            // RBCm2
            // 
            this.RBCm2.AutoSize = true;
            this.RBCm2.Location = new System.Drawing.Point(6, 137);
            this.RBCm2.Name = "RBCm2";
            this.RBCm2.Size = new System.Drawing.Size(40, 17);
            this.RBCm2.TabIndex = 8;
            this.RBCm2.TabStop = true;
            this.RBCm2.Text = "Cm";
            this.RBCm2.UseVisualStyleBackColor = true;
            this.RBCm2.CheckedChanged += new System.EventHandler(this.RBCm2_CheckedChanged);
            // 
            // RBM2
            // 
            this.RBM2.AutoSize = true;
            this.RBM2.Location = new System.Drawing.Point(6, 91);
            this.RBM2.Name = "RBM2";
            this.RBM2.Size = new System.Drawing.Size(34, 17);
            this.RBM2.TabIndex = 6;
            this.RBM2.TabStop = true;
            this.RBM2.Text = "M";
            this.RBM2.UseVisualStyleBackColor = true;
            this.RBM2.CheckedChanged += new System.EventHandler(this.RBM2_CheckedChanged);
            // 
            // RBDm2
            // 
            this.RBDm2.AutoSize = true;
            this.RBDm2.Location = new System.Drawing.Point(6, 114);
            this.RBDm2.Name = "RBDm2";
            this.RBDm2.Size = new System.Drawing.Size(41, 17);
            this.RBDm2.TabIndex = 7;
            this.RBDm2.TabStop = true;
            this.RBDm2.Text = "Dm";
            this.RBDm2.UseVisualStyleBackColor = true;
            this.RBDm2.CheckedChanged += new System.EventHandler(this.RBDm2_CheckedChanged);
            // 
            // RBDolares2
            // 
            this.RBDolares2.AutoSize = true;
            this.RBDolares2.Location = new System.Drawing.Point(5, 68);
            this.RBDolares2.Name = "RBDolares2";
            this.RBDolares2.Size = new System.Drawing.Size(61, 17);
            this.RBDolares2.TabIndex = 12;
            this.RBDolares2.TabStop = true;
            this.RBDolares2.Text = "Dolares";
            this.RBDolares2.UseVisualStyleBackColor = true;
            this.RBDolares2.CheckedChanged += new System.EventHandler(this.RBDolares2_CheckedChanged);
            // 
            // RBLibras2
            // 
            this.RBLibras2.AutoSize = true;
            this.RBLibras2.Location = new System.Drawing.Point(6, 46);
            this.RBLibras2.Name = "RBLibras2";
            this.RBLibras2.Size = new System.Drawing.Size(53, 17);
            this.RBLibras2.TabIndex = 11;
            this.RBLibras2.TabStop = true;
            this.RBLibras2.Text = "Libras";
            this.RBLibras2.UseVisualStyleBackColor = true;
            this.RBLibras2.CheckedChanged += new System.EventHandler(this.RBLibras2_CheckedChanged);
            // 
            // RBEuros2
            // 
            this.RBEuros2.AutoSize = true;
            this.RBEuros2.Location = new System.Drawing.Point(6, 23);
            this.RBEuros2.Name = "RBEuros2";
            this.RBEuros2.Size = new System.Drawing.Size(52, 17);
            this.RBEuros2.TabIndex = 10;
            this.RBEuros2.TabStop = true;
            this.RBEuros2.Text = "Euros";
            this.RBEuros2.UseVisualStyleBackColor = true;
            this.RBEuros2.CheckedChanged += new System.EventHandler(this.RBEuros2_CheckedChanged);
            // 
            // LBValor
            // 
            this.LBValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBValor.Location = new System.Drawing.Point(286, 61);
            this.LBValor.Name = "LBValor";
            this.LBValor.Size = new System.Drawing.Size(32, 20);
            this.LBValor.TabIndex = 13;
            this.LBValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTLongitudes
            // 
            this.BTLongitudes.Location = new System.Drawing.Point(116, 171);
            this.BTLongitudes.Name = "BTLongitudes";
            this.BTLongitudes.Size = new System.Drawing.Size(75, 23);
            this.BTLongitudes.TabIndex = 14;
            this.BTLongitudes.Text = "Longitudes";
            this.BTLongitudes.UseVisualStyleBackColor = true;
            this.BTLongitudes.Click += new System.EventHandler(this.BTLongitudes_Click);
            // 
            // BTDinero
            // 
            this.BTDinero.Location = new System.Drawing.Point(224, 171);
            this.BTDinero.Name = "BTDinero";
            this.BTDinero.Size = new System.Drawing.Size(75, 23);
            this.BTDinero.TabIndex = 15;
            this.BTDinero.Text = "Dinero";
            this.BTDinero.UseVisualStyleBackColor = true;
            this.BTDinero.Click += new System.EventHandler(this.BTDinero_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RBEuros);
            this.groupBox3.Controls.Add(this.RBDolares);
            this.groupBox3.Controls.Add(this.RBLibras);
            this.groupBox3.Location = new System.Drawing.Point(91, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(73, 91);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dinero";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RBEuros2);
            this.groupBox4.Controls.Add(this.RBDolares2);
            this.groupBox4.Controls.Add(this.RBLibras2);
            this.groupBox4.Location = new System.Drawing.Point(415, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(73, 91);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dinero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(501, 227);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BTDinero);
            this.Controls.Add(this.BTLongitudes);
            this.Controls.Add(this.LBValor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBValor2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBActualizar);
            this.Controls.Add(this.TBActualizado);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBActualizado;
        private System.Windows.Forms.TextBox TBActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBKm;
        private System.Windows.Forms.RadioButton RBHm;
        private System.Windows.Forms.RadioButton RBDam;
        private System.Windows.Forms.RadioButton RBMetros;
        private System.Windows.Forms.RadioButton RBDm;
        private System.Windows.Forms.RadioButton RBCm;
        private System.Windows.Forms.RadioButton RBMm;
        private System.Windows.Forms.Label LBValor2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBDolares;
        private System.Windows.Forms.RadioButton RBLibras;
        private System.Windows.Forms.RadioButton RBEuros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBDolares2;
        private System.Windows.Forms.RadioButton RBLibras2;
        private System.Windows.Forms.RadioButton RBEuros2;
        private System.Windows.Forms.RadioButton RBKm2;
        private System.Windows.Forms.RadioButton RBHm2;
        private System.Windows.Forms.RadioButton RBMm2;
        private System.Windows.Forms.RadioButton RBDam2;
        private System.Windows.Forms.RadioButton RBCm2;
        private System.Windows.Forms.RadioButton RBM2;
        private System.Windows.Forms.RadioButton RBDm2;
        private System.Windows.Forms.Label LBValor;
        private System.Windows.Forms.Button BTLongitudes;
        private System.Windows.Forms.Button BTDinero;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

