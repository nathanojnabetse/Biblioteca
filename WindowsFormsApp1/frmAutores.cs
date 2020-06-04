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
    public partial class frmAutores : Form
    {
        Autor nuevoAutor = new Autor();
        public Autor NuevoAutor { get => nuevoAutor; set => nuevoAutor = value; }

        List<Autor> lsAutores = new List<Autor>();
        public List<Autor> LsAutores { get => lsAutores; set => lsAutores = value; }
        

        int contID;
        public int ContID { get => contID; set => contID = value; }

        public frmAutores()
        {
            InitializeComponent();
        }

        public frmAutores(List<Autor> lsAutores, int contID)
        {
            InitializeComponent();
            this.lsAutores = lsAutores;
            this.ContID = contID;
            lblId.Text = Convert.ToString(contID);
            estadoinicial();
            actualizarLista();
        }

        private void estadoinicial()
        {
            lbxAutores.Enabled = false;
            foreach (Control iter in this.Controls)
            {
                if (iter is TextBox)
                {
                    iter.Enabled = false;
                }
               
            }
        }

        private void actualizarLista()
        {
            lbxAutores.Items.Clear();
            foreach(var iter in LsAutores )
            {
                lbxAutores.Items.Add(iter);
            }
        }
        private void noestadoinicial()
        {
            lbxAutores.Enabled = true;
            foreach (Control iter in this.Controls)
            {
                if (iter is TextBox)
                {
                    iter.Enabled = true;
                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Enabled == false)
            {
                noestadoinicial();
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                if (lbxAutores.SelectedItem == null)
                {


                    try
                    {
                        Autor autoraux = new Autor(Convert.ToInt32(lblId.Text), txtNombre.Text, txtApellido.Text, txtApellido2.Text);
                        NuevoAutor = autoraux;
                        lsAutores.Add(nuevoAutor);
                        Console.WriteLine("AUTOR CREADO");
                        FrmPrincipal frmP = new FrmPrincipal(this.LsAutores);
                        this.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Campos vacios");
                        Console.WriteLine("NO DEJE CAMPOS VACIOS //err//: " + err.Message);
                    }
                }
                else if (lbxAutores.SelectedItem != null)
                {
                    int indice = lbxAutores.SelectedIndex;
                    lsAutores[indice].IdAutor = Convert.ToInt32(lblId.Text);
                    lsAutores[indice].NombreAutor = txtNombre.Text;
                    lsAutores[indice].Apellido1Autor = txtApellido.Text;
                    lsAutores[indice].Apellido2Autor = txtApellido2.Text;
                    FrmPrincipal frmP = new FrmPrincipal(this.LsAutores);
                    this.Close();

                }
            }


            


           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lbxAutores.Enabled = true;
            noestadoinicial();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void lbxAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Autor au = (Autor)lbxAutores.SelectedItem;
                lblId.Text = Convert.ToString(au.IdAutor);
                txtNombre.Text = au.NombreAutor;
                txtApellido.Text = au.Apellido1Autor;
                txtApellido2.Text = au.Apellido2Autor;
            }
            catch (Exception err)
            {
                MessageBox.Show("Seleccione un elemento a editar");
                Console.WriteLine("NECESITA SELECCIONAR ANTES DE EDITAR //error//: " + err.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Autor delAutor = (Autor)lbxAutores.SelectedItem;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = false;
            actualizarLista();
            if (lbxAutores.Enabled == false)
            {
                estadoinicial();
                lbxAutores.Enabled = true;

            }
            else
            {
                if (MessageBox.Show("¿Está seguro de querer borrar el registro seleccionado?", "Borrar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    LsAutores.Remove(delAutor);

                    FrmPrincipal frmP = new FrmPrincipal(this.lsAutores);
                    Console.WriteLine("AUTOR ELIMINADO");

                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            actualizarLista();



        }

        private void frmAutores_Load(object sender, EventArgs e)
        {

        }
    }
}
