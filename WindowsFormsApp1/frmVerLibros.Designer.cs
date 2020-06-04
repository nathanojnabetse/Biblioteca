namespace WindowsFormsApp1
{
    partial class frmVerLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabLibros = new System.Windows.Forms.TabControl();
            this.tbLibrosDisp = new System.Windows.Forms.TabPage();
            this.lbxLibrosDisp = new System.Windows.Forms.ListBox();
            this.tbLibrosPres = new System.Windows.Forms.TabPage();
            this.lbxLibrosPres = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLibros.SuspendLayout();
            this.tbLibrosDisp.SuspendLayout();
            this.tbLibrosPres.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLibros
            // 
            this.tabLibros.Controls.Add(this.tbLibrosDisp);
            this.tabLibros.Controls.Add(this.tbLibrosPres);
            this.tabLibros.Location = new System.Drawing.Point(12, 12);
            this.tabLibros.Name = "tabLibros";
            this.tabLibros.SelectedIndex = 0;
            this.tabLibros.Size = new System.Drawing.Size(571, 213);
            this.tabLibros.TabIndex = 0;
            // 
            // tbLibrosDisp
            // 
            this.tbLibrosDisp.Controls.Add(this.label13);
            this.tbLibrosDisp.Controls.Add(this.label12);
            this.tbLibrosDisp.Controls.Add(this.label11);
            this.tbLibrosDisp.Controls.Add(this.label10);
            this.tbLibrosDisp.Controls.Add(this.lbxLibrosDisp);
            this.tbLibrosDisp.Location = new System.Drawing.Point(4, 22);
            this.tbLibrosDisp.Name = "tbLibrosDisp";
            this.tbLibrosDisp.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbLibrosDisp.Size = new System.Drawing.Size(563, 187);
            this.tbLibrosDisp.TabIndex = 0;
            this.tbLibrosDisp.Text = "Libros disponibles";
            this.tbLibrosDisp.UseVisualStyleBackColor = true;
            // 
            // lbxLibrosDisp
            // 
            this.lbxLibrosDisp.FormattingEnabled = true;
            this.lbxLibrosDisp.Location = new System.Drawing.Point(4, 20);
            this.lbxLibrosDisp.Name = "lbxLibrosDisp";
            this.lbxLibrosDisp.Size = new System.Drawing.Size(554, 160);
            this.lbxLibrosDisp.TabIndex = 1;
            // 
            // tbLibrosPres
            // 
            this.tbLibrosPres.Controls.Add(this.label3);
            this.tbLibrosPres.Controls.Add(this.label2);
            this.tbLibrosPres.Controls.Add(this.label1);
            this.tbLibrosPres.Controls.Add(this.lbxLibrosPres);
            this.tbLibrosPres.Location = new System.Drawing.Point(4, 22);
            this.tbLibrosPres.Name = "tbLibrosPres";
            this.tbLibrosPres.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbLibrosPres.Size = new System.Drawing.Size(563, 187);
            this.tbLibrosPres.TabIndex = 1;
            this.tbLibrosPres.Text = "Libros Prestados";
            this.tbLibrosPres.UseVisualStyleBackColor = true;
            // 
            // lbxLibrosPres
            // 
            this.lbxLibrosPres.FormattingEnabled = true;
            this.lbxLibrosPres.Location = new System.Drawing.Point(3, 19);
            this.lbxLibrosPres.Name = "lbxLibrosPres";
            this.lbxLibrosPres.Size = new System.Drawing.Size(554, 160);
            this.lbxLibrosPres.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(261, 238);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(404, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 59;
            this.label13.Text = "UBICACION";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(279, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "AÑO ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "DISPONIBLES";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PRESTADO A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "FECHA MÁXIMA DE ENTREGA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "LIBRO";
            // 
            // frmVerLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 273);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabLibros);
            this.Name = "frmVerLibros";
            this.Text = "frmVerLibros";
            this.tabLibros.ResumeLayout(false);
            this.tbLibrosDisp.ResumeLayout(false);
            this.tbLibrosDisp.PerformLayout();
            this.tbLibrosPres.ResumeLayout(false);
            this.tbLibrosPres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLibros;
        private System.Windows.Forms.TabPage tbLibrosDisp;
        private System.Windows.Forms.ListBox lbxLibrosDisp;
        private System.Windows.Forms.TabPage tbLibrosPres;
        private System.Windows.Forms.ListBox lbxLibrosPres;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}