namespace WindowsFormsApp1
{
    partial class frmLibros
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.sección = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtejemplares = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dtPublicación = new System.Windows.Forms.DateTimePicker();
            this.cbxCategoría = new System.Windows.Forms.ComboBox();
            this.cbxSeccion = new System.Windows.Forms.ComboBox();
            this.lbxTodosAutores = new System.Windows.Forms.ListBox();
            this.lbxAutores = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAñadirAutor = new System.Windows.Forms.Button();
            this.lbxLibros = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxProv = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Libro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(53, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(53, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "F. de publicación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(53, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISBN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(53, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoría:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(53, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "# Ejemplares:";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.BackColor = System.Drawing.Color.Transparent;
            this.Precio.ForeColor = System.Drawing.Color.Black;
            this.Precio.Location = new System.Drawing.Point(53, 188);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(40, 13);
            this.Precio.TabIndex = 6;
            this.Precio.Text = "Precio:";
            // 
            // sección
            // 
            this.sección.AutoSize = true;
            this.sección.BackColor = System.Drawing.Color.Transparent;
            this.sección.ForeColor = System.Drawing.Color.Black;
            this.sección.Location = new System.Drawing.Point(53, 216);
            this.sección.Name = "sección";
            this.sección.Size = new System.Drawing.Size(49, 13);
            this.sección.TabIndex = 7;
            this.sección.Text = "Sección:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(144, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(10, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = ".";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(147, 107);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(100, 20);
            this.txtIsbn.TabIndex = 10;
            // 
            // txtejemplares
            // 
            this.txtejemplares.Location = new System.Drawing.Point(146, 160);
            this.txtejemplares.Name = "txtejemplares";
            this.txtejemplares.Size = new System.Drawing.Size(100, 20);
            this.txtejemplares.TabIndex = 11;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(146, 185);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 12;
            // 
            // dtPublicación
            // 
            this.dtPublicación.Location = new System.Drawing.Point(146, 81);
            this.dtPublicación.Name = "dtPublicación";
            this.dtPublicación.Size = new System.Drawing.Size(101, 20);
            this.dtPublicación.TabIndex = 16;
            // 
            // cbxCategoría
            // 
            this.cbxCategoría.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoría.FormattingEnabled = true;
            this.cbxCategoría.Location = new System.Drawing.Point(147, 133);
            this.cbxCategoría.Name = "cbxCategoría";
            this.cbxCategoría.Size = new System.Drawing.Size(99, 21);
            this.cbxCategoría.TabIndex = 17;
            // 
            // cbxSeccion
            // 
            this.cbxSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSeccion.FormattingEnabled = true;
            this.cbxSeccion.Location = new System.Drawing.Point(147, 211);
            this.cbxSeccion.Name = "cbxSeccion";
            this.cbxSeccion.Size = new System.Drawing.Size(99, 21);
            this.cbxSeccion.TabIndex = 18;
            // 
            // lbxTodosAutores
            // 
            this.lbxTodosAutores.FormattingEnabled = true;
            this.lbxTodosAutores.Location = new System.Drawing.Point(320, 43);
            this.lbxTodosAutores.Name = "lbxTodosAutores";
            this.lbxTodosAutores.Size = new System.Drawing.Size(159, 186);
            this.lbxTodosAutores.TabIndex = 19;
            this.lbxTodosAutores.SelectedIndexChanged += new System.EventHandler(this.lbxTodosAutores_SelectedIndexChanged);
            // 
            // lbxAutores
            // 
            this.lbxAutores.FormattingEnabled = true;
            this.lbxAutores.Location = new System.Drawing.Point(147, 244);
            this.lbxAutores.Name = "lbxAutores";
            this.lbxAutores.Size = new System.Drawing.Size(98, 108);
            this.lbxAutores.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(53, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Autor(es):";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(449, 325);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(61, 23);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(376, 325);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(61, 23);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(301, 325);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(61, 23);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAñadirAutor
            // 
            this.btnAñadirAutor.Location = new System.Drawing.Point(320, 244);
            this.btnAñadirAutor.Name = "btnAñadirAutor";
            this.btnAñadirAutor.Size = new System.Drawing.Size(161, 23);
            this.btnAñadirAutor.TabIndex = 30;
            this.btnAñadirAutor.Text = "Añadir a la lista de autores";
            this.btnAñadirAutor.UseVisualStyleBackColor = true;
            this.btnAñadirAutor.Click += new System.EventHandler(this.btnAñadirAutor_Click);
            // 
            // lbxLibros
            // 
            this.lbxLibros.FormattingEnabled = true;
            this.lbxLibros.Location = new System.Drawing.Point(535, 43);
            this.lbxLibros.Name = "lbxLibros";
            this.lbxLibros.Size = new System.Drawing.Size(521, 303);
            this.lbxLibros.TabIndex = 31;
            this.lbxLibros.SelectedIndexChanged += new System.EventHandler(this.lbxLibros_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Retirar de la lista de autores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(53, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Proveedor:";
            // 
            // cbxProv
            // 
            this.cbxProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProv.FormattingEnabled = true;
            this.cbxProv.Location = new System.Drawing.Point(146, 366);
            this.cbxProv.Name = "cbxProv";
            this.cbxProv.Size = new System.Drawing.Size(99, 21);
            this.cbxProv.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "AUTORES";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(548, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "NOMBRE";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(648, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "DISPONIBLES";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(784, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "AÑO ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(901, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "UBICACION";
            // 
            // frmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 448);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxProv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbxLibros);
            this.Controls.Add(this.btnAñadirAutor);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbxAutores);
            this.Controls.Add(this.lbxTodosAutores);
            this.Controls.Add(this.cbxSeccion);
            this.Controls.Add(this.cbxCategoría);
            this.Controls.Add(this.dtPublicación);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtejemplares);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.sección);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLibros";
            this.Text = "frmLibros";
            this.Load += new System.EventHandler(this.frmLibros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label sección;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtejemplares;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DateTimePicker dtPublicación;
        private System.Windows.Forms.ComboBox cbxCategoría;
        private System.Windows.Forms.ComboBox cbxSeccion;
        private System.Windows.Forms.ListBox lbxTodosAutores;
        private System.Windows.Forms.ListBox lbxAutores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAñadirAutor;
        private System.Windows.Forms.ListBox lbxLibros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxProv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}