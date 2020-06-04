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
    public partial class frmRegistroNuevoUsuario : Form
    {
        Genero g1 = new Genero(1, "Masculino");
        Genero g2 = new Genero(2, "Femenino");
        Genero g3 = new Genero(3, "No definido");

        List<Genero> lsGeneros = new List<Genero>();

        Usuario nuevoUsuario = new Usuario();
        public Usuario NuevoUsuario { get => nuevoUsuario; set => nuevoUsuario = value; }

        List<Usuario> lsUsuarios = new List<Usuario>();
        public List<Usuario> LsUsuarios { get => lsUsuarios; set => lsUsuarios = value; }

        int contID;
        public int ContID { get => contID; set => contID = value; }

        //-----------------------------------------------------------------------

        public frmRegistroNuevoUsuario()
        {
            InitializeComponent();
            

            inicial();
           
        }

        private void inicial()
        {
            lsGeneros.Add(g1); lsGeneros.Add(g2); lsGeneros.Add(g3);
            foreach (var iter in lsGeneros)
            {
                cbxGeneros.Items.Add(iter);
            }
            actualizarLista();
            lblId.Text = Convert.ToString(contID);
            estadoinicial();
            txtCorreo.Text = "@epn.edu.ec";
            txtCedula.Text = "";
            lbxUsuarios.Enabled = false;

        }

        public frmRegistroNuevoUsuario(List<Usuario> lsUsuarios, int v)
        {
            InitializeComponent();
            this.lsUsuarios = lsUsuarios;
            this.contID = v;

            inicial();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtApellido.Enabled==false)
            {
                noestadoinicial();
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                if (Verificar(txtCedula.Text) == true && IsValidEmail(txtCorreo.Text) == true)
                {

                    if (lbxUsuarios.SelectedItem == null)
                    {
                        try
                        {
                            Usuario usuarioAux = new Usuario(Convert.ToInt16(lblId.Text), txtNombre.Text, txtApellido.Text, cbxGeneros.SelectedItem.ToString(), txtDireccion.Text, txtTeléfono.Text, txtCorreo.Text, txtCedula.Text);
                            NuevoUsuario = usuarioAux;
                            LsUsuarios.Add(nuevoUsuario);
                            Console.WriteLine("USUARIO CREADO");
                            this.Close();
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Campos vacios");
                            Console.WriteLine("NO DEJE CAMPOS VACIOS //err//: "+ err.Message  );
                        }

                        FrmPrincipal frmP = new FrmPrincipal(this.lsUsuarios);
                        actualizarLista();
                        this.Close();
                    }
                    else if (lbxUsuarios.SelectedItem != null)
                    {
                        int indice = lbxUsuarios.SelectedIndex;
                        lsUsuarios[indice].IdPersona = Convert.ToInt32(lblId.Text);
                        lsUsuarios[indice].Nombre = txtNombre.Text;
                        lsUsuarios[indice].Apellido = txtApellido.Text;
                        lsUsuarios[indice].Genero = cbxGeneros.SelectedItem.ToString();
                        lsUsuarios[indice].Direccion = txtDireccion.Text;
                        lsUsuarios[indice].Telefono = txtTeléfono.Text;
                        lsUsuarios[indice].Correo = txtCorreo.Text;
                        lsUsuarios[indice].Cedula = txtCedula.Text;
                        FrmPrincipal frmP = new FrmPrincipal(this.lsUsuarios);
                        actualizarLista();
                        Console.WriteLine("USUARIO EDITADO");
                        this.Close();
                    }


                }
                else
                {
                    if (Verificar(txtCedula.Text) == false)
                    {
                        txtCedula.Text = "";
                        MessageBox.Show("Cedula no valida");
                    }
                    else if (IsValidEmail(txtCorreo.Text) == false)
                    {
                        txtCorreo.Text = "";
                        MessageBox.Show("Correo Invalido");
                    }

                }
            }



            
        }

        private void estadoinicial()
        {
            lbxUsuarios.Enabled = true;
            foreach (Control iter in this.Controls)
            {
                if (iter is TextBox)
                {
                    iter.Enabled = false;
                }
                if (iter is ComboBox)
                {
                    iter.Enabled = false;
                }
                if (iter is DateTimePicker)
                {
                    iter.Enabled = false;
                }
            }
        }

        private void noestadoinicial()
        {
            lbxUsuarios.Enabled = true;
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
            }
        }
        private void actualizarLista()
        {
            lbxUsuarios.Items.Clear();
            foreach(var iter in lsUsuarios)
            {
                lbxUsuarios.Items.Add(iter);
            }
        }


        //Verificar correo
        public static bool IsValidEmail(string strIn)
        {
         
            return Regex.IsMatch(strIn,
                   @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }

        //Verificar cédula
        public bool Verificar(string cedula)
        {
            int isNumerica;
            var total = 0;
            const int tamano = 10;
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int numeroProvincias = 24;
            const int tercerDigito = 6;

            if (int.TryParse(cedula, out isNumerica) && cedula.Length == tamano)
            {
                var provincia = Convert.ToInt32(string.Concat(cedula[0], cedula[1], string.Empty));
                var digitoTres = Convert.ToInt32(cedula[2] + string.Empty);
                if ((provincia > 0 && provincia <= numeroProvincias) && digitoTres < tercerDigito)
                {
                    var DigitoVerificador = Convert.ToInt32(cedula[9] + string.Empty);
                    for (var k = 0; k < coeficientes.Length; k++)
                    {
                        var valor = Convert.ToInt32(coeficientes[k] + string.Empty) *
                                Convert.ToInt32(cedula[k] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;
                    }
                    var digitoRecibido = total >= 10 ? (total % 10) != 0 ?
                        10 - (total % 10) : (total % 10) : total;
                    return DigitoVerificador == digitoRecibido;

                }
                return true;
            }
            else
            {
                return false; 
            }
        }


        private void frmRegistroNuevoUsuario_Load(object sender, EventArgs e)
        {
           
           
        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }

        private void lbxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Usuario pr = (Usuario)lbxUsuarios.SelectedItem;
                lblId.Text = Convert.ToString(pr.IdPersona);
                txtNombre.Text = pr.Nombre;
                txtApellido.Text = pr.Apellido;

                if (pr.Genero.Equals("Masculino"))
                {
                    cbxGeneros.SelectedIndex = 0;
                }
                else if(pr.Genero.Equals("Femenino"))
                {
                    cbxGeneros.SelectedIndex = 1;
                }
                else if(pr.Genero.Equals("No definido"))
                {
                    cbxGeneros.SelectedIndex = 2;
                }

                txtDireccion.Text = pr.Direccion;
                txtTeléfono.Text = pr.Telefono;
                txtCorreo.Text = pr.Correo;
                txtCedula.Text = pr.Cedula;
            }
            catch(Exception err)
            {
                MessageBox.Show("Seleccione un elemento a editar");
                Console.WriteLine("NECESITA SELECCIONAR ANTES DE EDITAR //error//: " + err.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lbxUsuarios.Enabled = true;
            noestadoinicial();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario delUser = (Usuario)lbxUsuarios.SelectedItem;
            
            btnEditar.Enabled = false;
            btnAgregar.Enabled = false;
            actualizarLista();
            if(lbxUsuarios.Enabled == false)
            {
                estadoinicial();
             
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de querer borrar el registro seleccionado?", "Borrar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                   
                    LsUsuarios.Remove(delUser);

                    FrmPrincipal frmP = new FrmPrincipal(this.lsUsuarios);
                    Console.WriteLine("USUARIO ELIMINADO");

                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            actualizarLista();
        }

    }
}
