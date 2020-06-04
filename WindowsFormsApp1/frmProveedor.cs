using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class frmProveedor : Form
    {
        Proveedor nuevoProveedor = new Proveedor();
        public Proveedor NuevoProveedor { get => nuevoProveedor; set => nuevoProveedor = value; }

        List<Proveedor> lsProveedores = new List<Proveedor>();
        public List<Proveedor> LsProveedores { get => lsProveedores; set => lsProveedores = value; }

        int contID;
        public int ContID { get => contID; set => contID = value; }


        public frmProveedor()
        {
            InitializeComponent();
        }

        public frmProveedor(List<Proveedor> lsProveedores, int cont)
        {
            InitializeComponent();
            this.lsProveedores = lsProveedores;
            this.contID = cont;

            inicial();
            actualizarLista();
        }

        
        private void estadoinicial()
        {
            lbxProveedor.Enabled = true;
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
            lbxProveedor.Enabled = true;
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
            lbxProveedor.Items.Clear();
            foreach (var iter in lsProveedores)
            {
                lbxProveedor.Items.Add(iter);
            }
        }
        private void inicial()
        {

            actualizarLista();
            lblId.Text = Convert.ToString(contID);
            estadoinicial();
            txtCorreo.Text = "@hotmail.com";
            lbxProveedor.Enabled = false;

        }

        //Verificar correo
        public static bool IsValidEmail(string strIn)
        {

            return Regex.IsMatch(strIn,
                   @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void frmProveedor_Load(object sender, EventArgs e)
        {

        }

        private void cbxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Enabled == false)
            {
                noestadoinicial();
                btnEliminar.Enabled = false;
                btnEditar.Enabled = false;
            }
            else
            {
                if (lbxProveedor.SelectedItem == null)
                {
                    try
                    {
                        Proveedor provAux = new Proveedor(Convert.ToInt16(lblId.Text), txtNombre.Text, txtDireccion.Text, txtTeléfono.Text, txtCorreo.Text);

                        if (IsValidEmail(txtCorreo.Text) == true)
                        {

                            nuevoProveedor = provAux;
                            lsProveedores.Add(nuevoProveedor);
                            Console.WriteLine("PROVEEDOR CREADO");

                            FrmPrincipal frmP = new FrmPrincipal(this.lsProveedores);
                            actualizarLista();
                            this.Close();
                        }
                    }

                    catch (Exception err)
                    {
                        Console.WriteLine(err);
                        MessageBox.Show("Campos Vacíos");
                    }
                }
                else if (lbxProveedor.SelectedItem != null)
                {
                    int indice = lbxProveedor.SelectedIndex;
                    lsProveedores[indice].IdProveedor = Convert.ToInt32(lblId.Text);
                    lsProveedores[indice].NombreProv = txtNombre.Text;
                    lsProveedores[indice].Direccion = txtDireccion.Text;
                    lsProveedores[indice].Telefono = txtTeléfono.Text;
                    lsProveedores[indice].Correo = txtCorreo.Text;

                    FrmPrincipal frmP = new FrmPrincipal(this.lsProveedores);
                    actualizarLista();
                    this.Close();

                }

                actualizarLista();
                this.Close();
            }

        }
        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lbxProveedor.Enabled = true;
            noestadoinicial();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Proveedor prov = (Proveedor)lbxProveedor.SelectedItem;

            btnEditar.Enabled = false;
            btnAgregar.Enabled = false;
            actualizarLista();
            if (lbxProveedor.Enabled == false)
            {
                estadoinicial();
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de querer borrar el registro seleccionado?", "Borrar Proveedor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LsProveedores.Remove(prov);

                    FrmPrincipal frmP = new FrmPrincipal(this.lsProveedores);
                    Console.WriteLine("PROVEEDOR ELIMINADO");

                    this.Close();
                }

                else
                {
                    this.Close();
                }
            }
            actualizarLista();
        }

        private void lbxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Proveedor p = (Proveedor)lbxProveedor.SelectedItem;
                lblId.Text = Convert.ToString(p.IdProveedor);
                txtNombre.Text = p.NombreProv;
                txtDireccion.Text = p.Direccion;
                txtCorreo.Text = p.Direccion;
                txtTeléfono.Text = p.Telefono;
            }
            catch (Exception err)
            {
                MessageBox.Show("Seleccione un elemento a editar");
                Console.WriteLine("NECESITA SELECCIONAR ANTES DE EDITAR //error//: " + err.Message);
            }
        }
    }
}
