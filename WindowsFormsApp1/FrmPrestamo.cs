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
    public partial class FrmPrestamo : Form
    {

        List<Usuario> lsUsuarios = new List<Usuario>();
        public List<Usuario> LsUsuarios { get => lsUsuarios; set => lsUsuarios = value; }

        List<Libro> lsLibros = new List<Libro>();
        public List<Libro> LsLibros { get => lsLibros; set => lsLibros = value; }

        List<Prestamo> lsPrestamos = new List<Prestamo>();
        public List<Prestamo> LsPrestamos { get => lsPrestamos; set => lsPrestamos = value; }

        Prestamo nuevoPrestamo = new Prestamo();
        public Prestamo NuevoPrestamo { get => nuevoPrestamo; set => nuevoPrestamo = value; }

        private int contIDprest;
        public int ContIDprest { get => contIDprest; set => contIDprest = value; }
       

        public FrmPrestamo()
        {
            InitializeComponent();
        }

        public FrmPrestamo(List<Usuario> lsUsuraios, List<Libro> lsLibros, List<Prestamo> lsPrestamos)
        {
            InitializeComponent();
            this.lsUsuarios = lsUsuraios; 
            this.lsLibros = lsLibros;
            this.lsPrestamos = lsPrestamos;
            //dtPrestamo.Value = DateTime.Now; 
            lblFecha.Text = Convert.ToString(DateTime.Now);
            lblId.Text = Convert.ToString(contIDprest);
            cargarLibros();
            cargarUsuarios();
            //estadoinicial();

        }



        private void estadoinicial()
        {
            foreach (Control iter in this.Controls)
            {
                if (iter is TextBox)
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
          
                btnRegistrar.Enabled = false;
            }
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

        private void cargarLibros()
        {
            lbxLibros.Items.Clear();
            foreach (var iter in lsLibros)
            {
                lbxLibros.Items.Add(iter);
            }
        }

        private void cargarUsuarios()
        {
            lbxUsuario.Items.Clear();
            foreach(var iter in lsUsuarios)
            {
                lbxUsuario.Items.Add(iter);
            }
          }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private int verificarFecha()
        {
            int dia = dtLimite.Value.Day;
            int mes = dtLimite.Value.Month;
            int anio = dtLimite.Value.Year;

            if (anio>= DateTime.Now.Year && mes>= DateTime.Now.Month && dia >DateTime.Now.Day)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
            try
            {
                Libro libro = (Libro)lbxLibros.SelectedItem;
                Persona persona = (Persona)lbxUsuario.SelectedItem;

                Prestamo prestAux = new Prestamo(Convert.ToInt32(lblId.Text), DateTime.Now, dtLimite.Value, Convert.ToDecimal(txtMulta.Text), libro,persona);
               
                if (verificarFecha() == 1)
                {
                    if (libro.NumEjemplares > 0)
                    {
                        nuevoPrestamo = prestAux;
                        libro.NumEjemplares--;
                        lsPrestamos.Add(nuevoPrestamo);
                        Console.WriteLine("PRÉSTAMO AÑANIDO");
                        FrmPrincipal frmP = new FrmPrincipal(this.lsPrestamos);
                        Console.WriteLine("---");


                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No hay ejemplares Disponibles" + "\nSeleecione otro libro");
                    }

                }
                else
                {
                    MessageBox.Show("Error en la fecha");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Faltan datos " + err.Message); 
            }

            
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {

        }
    }
}
