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
    public partial class frmVerLibros : Form
    {
        List<Libro> lsLibros = new List<Libro>();
        public List<Libro> LsLibros { get => lsLibros; set => lsLibros = value; }

        List<Prestamo> lsPrestamos = new List<Prestamo>();
        public List<Prestamo> LsPrestamos { get => lsPrestamos; set => lsPrestamos = value; }

        public frmVerLibros()
        {
            InitializeComponent();
        }

        public frmVerLibros(List<Prestamo> lsPrestamos, List<Libro> lsLibros)
        {
            InitializeComponent();
            this.lsPrestamos = lsPrestamos;
            this.lsLibros = lsLibros;

            cargar();
        }

        private void cargar()
        {
            foreach(var iter in LsPrestamos)
            {
                lbxLibrosPres.Items.Add(iter);
            }
            foreach (var iter in lsLibros)
            {
                lbxLibrosDisp.Items.Add(iter);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
