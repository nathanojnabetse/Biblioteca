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
    public partial class FrmAdmUsuario : Form
    {
        public List<Usuario> lsuarios; 

        public FrmAdmUsuario()
        {
            InitializeComponent();
        }

        public FrmAdmUsuario(List<Usuario> lsuarios)
        {
            this.lsuarios = lsuarios;
            InitializeComponent();
        }

        private void FrmAdmUsuario_Load(object sender, EventArgs e)
        {
            imprimir();
        }

        private void imprimir()
        {
            listBox1.Items.Clear();
            foreach(Usuario aux in lsuarios)
            {
                listBox1.Items.Add(aux);
            }
        }
    }
}
