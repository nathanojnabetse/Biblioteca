using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLibros : Form
    {
        Libro nuevoLibro = new Libro();
        public Libro NuevoLibro { get => nuevoLibro; set => nuevoLibro = value; }

        List<Libro> lsLibros = new List<Libro>();
        public List<Libro> LsLibros { get => lsLibros; set => lsLibros = value; }
       
        List<Autor> lsAutores = new List<Autor>();
        public List<Autor> LsAutores { get => lsAutores; set => lsAutores = value; }
       
        private int contIDlibr;

        List<Categoria> lsCategorias = new List<Categoria>();
        public List<Categoria> LsCategorias { get => lsCategorias; set => lsCategorias = value; }

        List<Seccion> lsSecciones = new List<Seccion>();
        public List<Seccion> LsSecciones { get => lsSecciones; set => lsSecciones = value; }

        List<Autor> lsaux = new List<Autor>();
        public List<Autor> Lsaux { get => lsaux; set => lsaux = value; }

        List<Proveedor> lsProveedores = new List<Proveedor>();
        public List<Proveedor> LsProveedores { get => lsProveedores; set => lsProveedores = value; }

        public int ContIDlibr { get => contIDlibr; set => contIDlibr = value; }
        

        public frmLibros()
        {
            InitializeComponent();
        }

        public frmLibros(List<Libro> lsLibros, int contIDlibr, List<Autor> lsAutores, List<Categoria> lsCategorias, List<Seccion> lsSecciones, List<Proveedor> lsProveedores) 
        {
            InitializeComponent();
            this.lsLibros = lsLibros;
            this.ContIDlibr = contIDlibr;
            this.lsAutores = lsAutores;
            this.lsCategorias = lsCategorias;
            this.lsSecciones = lsSecciones;
            this.lsProveedores = lsProveedores;
            lblId.Text = Convert.ToString(contIDlibr);
            cargarTodosAutores();
            cargarLibros();
            combos();
            estadoinicial();

        }

        private void estadoinicial()
        {
           foreach(Control iter in this.Controls)
            {
                if (iter is TextBox)
                {
                    iter.Enabled = false;
                }
                if (iter is ComboBox)
                {
                    iter.Enabled = false;
                }
                if (iter is ListBox)
                {
                    iter.Enabled = false;
                }
                if (iter is DateTimePicker)
                {
                    iter.Enabled = false;
                }
                btnAñadirAutor.Enabled = false;
                button1.Enabled = false;
            }
        }
        private void noestadoinicial()
        {
            foreach (Control iter in this.Controls)
            {
                if (iter is TextBox)
                {
                    iter.Enabled = true;
                }
                if (iter is ComboBox)
                {
                    iter.Enabled = true;
                }
                if (iter is ListBox)
                {
                    iter.Enabled = true;
                }
                if (iter is DateTimePicker)
                {
                    iter.Enabled = true;
                }
            }
        }

        private void combos()
        {
            foreach(var iter in lsSecciones)
            {
                cbxSeccion.Items.Add(iter);
            }

            foreach(var iter in lsCategorias)
            {
                cbxCategoría.Items.Add(iter);
            }

            foreach(var iter in lsProveedores)
            {
                cbxProv.Items.Add(iter);
            }
        }

        private void cargarLibros()
        {
            lbxLibros.Items.Clear();
            foreach (var iter in lsLibros)
            {
                lbxLibros.Items.Add(iter);
            }
        }



        private void cargarTodosAutores()
        {
            lbxTodosAutores.Items.Clear();
            foreach (var iter in lsAutores)
            {
                lbxTodosAutores.Items.Add(iter);
            }

        }

        private void btnAñadirAutor_Click(object sender, EventArgs e)
        {
            try
            {
            lbxAutores.Items.Add(lbxTodosAutores.SelectedItem);
            lsaux.Add((Autor)lbxTodosAutores.SelectedItem);
            }
            catch(Exception err)
            {
                Console.WriteLine("NO DEJE CAMPOS VACIOS //err//: " + err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbxAutores.Items.Remove(lbxAutores.SelectedItem);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtejemplares.Enabled == false)
            {
                noestadoinicial();
                lbxLibros.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnAñadirAutor.Enabled = true;
                button1.Enabled = true;
            }
            else 
            {
                if (lbxLibros.SelectedItem == null)
                {
                    try
                    {
                        Libro libaux = new Libro(Convert.ToInt32(lblId.Text), txtNombre.Text, dtPublicación.Value, txtIsbn.Text, cbxCategoría.SelectedItem.ToString(), Convert.ToInt32(txtejemplares.Text), Convert.ToDecimal(txtPrecio.Text), (Seccion)cbxSeccion.SelectedItem, lsaux);
                        NuevoLibro = libaux;
                        lsLibros.Add(nuevoLibro);
                        Console.WriteLine("LIBRO CREADO");
                        FrmPrincipal frmP = new FrmPrincipal(this.LsAutores);
                        this.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Campos vacios");
                        Console.WriteLine("NO DEJE CAMPOS VACIOS //err//: " + err.Message);
                    }
                }
                else if (lbxLibros.SelectedItem != null)
                {
                    int indice = lbxLibros.SelectedIndex;
                    lsLibros[indice].IdAutor = Convert.ToInt32(lblId.Text);
                    lsLibros[indice].Nombre = txtNombre.Text;
                    lsLibros[indice].Isbn = txtIsbn.Text;
                    lsLibros[indice].Categoria = cbxCategoría.Text;
                    lsLibros[indice].NumEjemplares = Convert.ToInt32(txtejemplares.Text);
                    lsLibros[indice].Precio = Convert.ToDecimal(txtPrecio.Text);
                    lsLibros[indice].Seccion = (Seccion)cbxSeccion.SelectedItem;
                    lsLibros[indice].Autores = Lsaux;


                    FrmPrincipal frmP = new FrmPrincipal(this.LsAutores);
                    this.Close();

                }
            }

            

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            noestadoinicial();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAñadirAutor.Enabled = true;
            button1.Enabled = true;


        }

        private void lbxTodosAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            

        }

        private void lbxLibros_SelectedIndexChanged(object sender, EventArgs e)
        {

            Libro lb = (Libro)lbxLibros.SelectedItem;

            lblId.Text = Convert.ToString(lb.IdAutor);
            txtNombre.Text = lb.Nombre;
            txtIsbn.Text = lb.Isbn;

            if (lb.Categoria.Equals("Policial"))
            {
                cbxCategoría.SelectedIndex = 0;
            }
            else if (lb.Categoria.Equals("Romántica"))
            {
                cbxCategoría.SelectedIndex = 1;
            }
            else if (lb.Categoria.Equals("Aventura"))
            {
                cbxCategoría.SelectedIndex = 2;
            }
            else if (lb.Categoria.Equals("Terror"))
            {
                cbxCategoría.SelectedIndex = 3;
            }
            else if (lb.Categoria.Equals("Ficción"))
            {
                cbxCategoría.SelectedIndex = 4;
            }
            else if (lb.Categoria.Equals("Ciencia"))
            {
                cbxCategoría.SelectedIndex = 5;
            }
            else if (lb.Categoria.Equals("Investigación"))
            {
                cbxCategoría.SelectedIndex = 6;
            }
            else if (lb.Categoria.Equals("Biográfica"))
            {
                cbxCategoría.SelectedIndex = 7;
            }
            else if (lb.Categoria.Equals("Infantil"))
            {
                cbxCategoría.SelectedIndex = 8;
            }
            else if (lb.Categoria.Equals("Erótica"))
            {
                cbxCategoría.SelectedIndex = 9;
            }

            txtejemplares.Text = Convert.ToString(lb.NumEjemplares);
            txtPrecio.Text = Convert.ToString(lb.Precio);

            if (lb.Seccion.IdSeccion == 1)
            {
                cbxSeccion.SelectedIndex = 0;
            }
            else if(lb.Seccion.IdSeccion == 2)
            {
                cbxSeccion.SelectedIndex = 1;
            }
            else if (lb.Seccion.IdSeccion == 3)
            {
                cbxSeccion.SelectedIndex = 2;
            }
            else if (lb.Seccion.IdSeccion == 4)
            {
                cbxSeccion.SelectedIndex = 3;
            }
            else if (lb.Seccion.IdSeccion == 5)
            {
                cbxSeccion.SelectedIndex = 4;
            }
            else if (lb.Seccion.IdSeccion == 6)
            {
                cbxSeccion.SelectedIndex = 5;
            }
            else if (lb.Seccion.IdSeccion == 7)
            {
                cbxSeccion.SelectedIndex = 6;
            }
            else if (lb.Seccion.IdSeccion == 8)
            {
                cbxSeccion.SelectedIndex = 7;
            }
            else if (lb.Seccion.IdSeccion == 9)
            {
                cbxSeccion.SelectedIndex = 8;
            }
            else if (lb.Seccion.IdSeccion == 10)
            {
                cbxSeccion.SelectedIndex = 9;
            }
            lbxAutores.Items.Clear();
            foreach(var iter in lb.Autores)
            {
                lbxAutores.Items.Add(iter);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                       
            Libro dellb = (Libro)lbxLibros.SelectedItem;

            if (lbxLibros.Enabled == false)
            {
                estadoinicial();
                lbxLibros.Enabled = true;
                btnEditar.Enabled = false;
                btnAgregar.Enabled = false;
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de querer borrar el registro seleccionado?", "Borrar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    LsLibros.Remove(dellb);

                    FrmPrincipal frmP = new FrmPrincipal(this.lsLibros);
                    Console.WriteLine("LIBRO ELIMINADO");

                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }

        }

        private void frmLibros_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
