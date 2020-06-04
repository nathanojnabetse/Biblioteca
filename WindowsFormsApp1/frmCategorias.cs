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
    public partial class frmCategorias : Form
    {
        Categoria nuevaCategoria = new Categoria();

        List<Categoria> lsCategorias = new List<Categoria>();
        public List<Categoria> LsCategorias { get => lsCategorias; set => lsCategorias = value; }
        public Categoria NuevaCategoria { get => nuevaCategoria; set => nuevaCategoria = value; }
        public int ContID { get => contID; set => contID = value; }

        int contID;

        public frmCategorias()
        {
            InitializeComponent();
        }

        public frmCategorias(List<Categoria> lsCategorias, int contID)
        {
            InitializeComponent();
            this.lsCategorias = lsCategorias;
            this.contID = contID;
            lblId.Text = Convert.ToString(contID);
            estadoinicial();
            actualizarLista();
        }
        private void estadoinicial()
        {
            lbxCategorias.Enabled = false;
            foreach (Control iter in this.Controls)
            {
                if (iter is TextBox)
                {
                    iter.Enabled = false;
                }

            }

        }

        private void noestadoinicial()
        {
            lbxCategorias.Enabled = true;
            foreach (Control iter in this.Controls)
            {
                if (iter is TextBox)
                {
                    iter.Enabled = true;
                }

            }
        }

        private void actualizarLista()
        {
            lbxCategorias.Items.Clear();
            foreach (var iter in LsCategorias)
            {
                lbxCategorias.Items.Add(iter);
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Enabled == false)
            {
                noestadoinicial();
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                if (lbxCategorias.SelectedItem == null)
                {


                    try
                    {
                        Categoria categoriaaux = new Categoria(Convert.ToInt32(lblId.Text), txtNombre.Text);
                        NuevaCategoria = categoriaaux;
                        LsCategorias.Add(NuevaCategoria);
                        Console.WriteLine("CATEGORIA CREADA");
                        FrmPrincipal frmP = new FrmPrincipal(this.LsCategorias);
                        this.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Campos vacios");
                        Console.WriteLine("NO DEJE CAMPOS VACIOS //err//: " + err.Message);
                    }
                }
                else if (lbxCategorias.SelectedItem != null)
                {
                    int indice = lbxCategorias.SelectedIndex;
                    LsCategorias[indice].IdCategoria = Convert.ToInt32(lblId.Text);
                    LsCategorias[indice].NombreCategoria = txtNombre.Text;
                    FrmPrincipal frmP = new FrmPrincipal(this.LsCategorias);
                    this.Close();

                }
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            lbxCategorias.Enabled = true;
            noestadoinicial();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void lbxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Categoria ct = (Categoria)lbxCategorias.SelectedItem;
                lblId.Text = Convert.ToString(ct.IdCategoria);
                txtNombre.Text = ct.NombreCategoria;
            }
            catch (Exception err)
            {
                MessageBox.Show("Seleccione un elemento a editar");
                Console.WriteLine("NECESITA SELECCIONAR ANTES DE EDITAR //error//: " + err.Message);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Categoria delCateg = (Categoria)lbxCategorias.SelectedItem;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = false;
            actualizarLista();

            if (lbxCategorias.Enabled == false)
            {
                noestadoinicial();
                txtNombre.Enabled = false;

            }
            else
            {
                if (MessageBox.Show("¿Está seguro de querer borrar el registro seleccionado?", "Borrar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    LsCategorias.Remove(delCateg);

                    FrmPrincipal frmP = new FrmPrincipal(this.LsCategorias);
                    Console.WriteLine("CATEGORIA ELIMINADA");

                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            actualizarLista();

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
