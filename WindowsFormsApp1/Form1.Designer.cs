namespace WindowsFormsApp1
{
    partial class FrmPrincipal
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
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnLibro = new System.Windows.Forms.Button();
            this.btnAutor = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.btnDevolución = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIBLIOTECA EPN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.Location = new System.Drawing.Point(236, 234);
            this.btnLibros.Margin = new System.Windows.Forms.Padding(2);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(93, 55);
            this.btnLibros.TabIndex = 3;
            this.btnLibros.Text = "LISTA DE LIBROS";
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.Location = new System.Drawing.Point(21, 175);
            this.btnLibro.Margin = new System.Windows.Forms.Padding(2);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(93, 55);
            this.btnLibro.TabIndex = 4;
            this.btnLibro.Text = "ADM. LIBROS";
            this.btnLibro.UseVisualStyleBackColor = true;
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // btnAutor
            // 
            this.btnAutor.Location = new System.Drawing.Point(19, 234);
            this.btnAutor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(93, 55);
            this.btnAutor.TabIndex = 5;
            this.btnAutor.Text = "AUTORES";
            this.btnAutor.UseVisualStyleBackColor = true;
            this.btnAutor.Click += new System.EventHandler(this.btnAutor_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(122, 234);
            this.btnCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(93, 55);
            this.btnCategoria.TabIndex = 6;
            this.btnCategoria.Text = "ADM CATEGORIA";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(124, 175);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(93, 55);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "ADM. USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(238, 175);
            this.btnProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(93, 55);
            this.btnProveedor.TabIndex = 8;
            this.btnProveedor.Text = "PROVEEDOR";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(122, 376);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 55);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Location = new System.Drawing.Point(21, 294);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(142, 48);
            this.btnPrestamo.TabIndex = 11;
            this.btnPrestamo.Text = "REGISTRAR PRESTAMO";
            this.btnPrestamo.UseVisualStyleBackColor = true;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // btnDevolución
            // 
            this.btnDevolución.Location = new System.Drawing.Point(187, 294);
            this.btnDevolución.Name = "btnDevolución";
            this.btnDevolución.Size = new System.Drawing.Size(144, 45);
            this.btnDevolución.TabIndex = 12;
            this.btnDevolución.Text = "REGISTRAR DEVOLUCIÓN";
            this.btnDevolución.UseVisualStyleBackColor = true;
            this.btnDevolución.Click += new System.EventHandler(this.btnDevolución_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.poli_512;
            this.pictureBox1.Location = new System.Drawing.Point(124, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(364, 466);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDevolución);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnAutor);
            this.Controls.Add(this.btnLibro);
            this.Controls.Add(this.btnLibros);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPrincipal";
            this.Text = "PRINCIPAL";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnLibro;
        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.Button btnDevolución;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

