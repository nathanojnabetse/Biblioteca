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
    public partial class FrmDevolucion : Form
    {
        Prestamo devolucion = new Prestamo();
        public Prestamo Devolucion { get => devolucion; set => devolucion = value; }

        List<Prestamo> lsPrestamos = new List<Prestamo>();
        public List<Prestamo> LsPrestamos { get => lsPrestamos; set => lsPrestamos = value; }

        List<Usuario> lsUsuarios = new List<Usuario>();
        public List<Usuario> LsUsuarios { get => lsUsuarios; set => lsUsuarios = value; }

        public FrmDevolucion()
        {
            InitializeComponent();
        }

        public FrmDevolucion(List<Prestamo> lsPrestamos)
        {
            InitializeComponent();
            this.lsPrestamos = lsPrestamos;
            cargarPrestamos();
        }

        public FrmDevolucion(List<Usuario> lsUsuarios)
        {
            InitializeComponent();
            this.lsUsuarios = lsUsuarios;
            cargarPrestamos();
        }

        public FrmDevolucion(List<Usuario> lsUsuarios, List<Prestamo> lsPrestamos)
        {
            InitializeComponent();
            this.lsPrestamos = lsPrestamos;
            this.lsUsuarios = lsUsuarios;
            cargarPrestamos();
        }

        private void cargarPrestamos()
        {
            
                
                    lbxPrestamos.Items.Clear();
                    foreach (var iter2 in LsPrestamos)
                    {
                        lbxPrestamos.Items.Add(iter2);
              
                    }



           

        }

        private void FrmDevolucion_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            Prestamo dev = (Prestamo)lbxPrestamos.SelectedItem;
            DateTime fechaDev = DateTime.Now;
            try
            {
                if (dev.FechaLimite.Year <= DateTime.Now.Year && dev.FechaLimite.Month <= DateTime.Now.Month && dev.FechaLimite.Day <= DateTime.Now.Day)
                {
                    lsPrestamos.Remove(dev);
                    dev.LibroPrestado.NumEjemplares++;
                    this.Close();

                }
                else
                {
                    lsPrestamos.Remove(dev);
                    dev.LibroPrestado.NumEjemplares++;
                    Decimal multa = dev.Multa;
                    int dif = -1 * Convert.ToInt16(DateTime.Now.Day - dev.FechaLimite.Day);

                    if (dif >= 0)
                    {
                        lsPrestamos.Remove(dev);
                       this.Close();
                    }
                    else
                    {
                        Decimal pago = dev.Multa * dif;
                        MessageBox.Show("Se debe cancelar una multa de: " + pago + "\nPor" + dif + "días de retraso");
                    }

                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Faltan datos " + err.Message);
            }
           

            this.Close();
        }
    }
}
