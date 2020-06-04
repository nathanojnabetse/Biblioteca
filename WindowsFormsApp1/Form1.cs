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
    public partial class FrmPrincipal : Form
    {
   
        List<Usuario> lsUsuarios = new List<Usuario>();
        public List<Usuario> LsUsuarios { get => lsUsuarios; set => lsUsuarios = value; }
        
        List<Autor> lsAutores = new List<Autor>();
        public List<Autor> LsAutores { get => lsAutores; set => lsAutores = value; }
        
        List<Categoria> lsCategorias = new List<Categoria>();
        public List<Categoria> LsCategorias { get => lsCategorias; set => lsCategorias = value; }
        
        List<Seccion> lsSecciones = new List<Seccion>();
        public List<Seccion> LsSecciones { get => lsSecciones; set => lsSecciones = value; }
        
        List<Libro> lsLibros = new List<Libro>();
        public List<Libro> LsLibros { get => lsLibros; set => lsLibros = value; }
       
        List<Proveedor> lsProveedores = new List<Proveedor>();
        public List<Proveedor> LsProveedores { get => lsProveedores; set => lsProveedores = value; }
        
        List<Prestamo> lsPrestamos = new List<Prestamo>();
        public List<Prestamo> LsPrestamos { get => lsPrestamos; set => lsPrestamos = value; }
        
        List<Prestamo> lsDevoluciones = new List<Prestamo>();
        public List<Prestamo> LsDevoluciones { get => lsDevoluciones; set => lsDevoluciones = value; }

        //-----PREDETERMINADOS

        Usuario u1 = new Usuario(1, "Juan", "Caicedo", "Masculino", "Quito norte", "2530096", "juan@hotmail.com", "1718723735");
        Usuario u2 = new Usuario(2, "Maria", "Pinos", "Femenino", "La Tola", "2406972", "maria@hotmail.com", "1705384632");
        Usuario u3 = new Usuario(3, "Pepe", "Estevez", "No definido", "Sangolqui", "2697530", "pepeExotico@hotmail.com", "170587643");
        Usuario u4 = new Usuario(4, "Diego", "Alvarez", "Masculino", "El dorado", "2645987", "diegoaALV@hotmail.com", "1801885573");
        Usuario u5 = new Usuario(5, "Sofia", "Garcia", "Femenino", "San bartolo", "2236547", "sofixxx@hotmail.com", "1804743381");
         
        Autor a1 = new Autor(1,"Charles","Bukowski","Andernach" );
        Autor a2 = new Autor(2, "Juan", "Rulfo", "Vizcaino");
        Autor a3 = new Autor(3, "Agatha", "Christie", "Miller");
        Autor a4 = new Autor(4, "Juan", "Montalvo", "Icaza");
        Autor a5 = new Autor(5, "Stephen", "King", "Smith");
        Autor a6 = new Autor(6, "Oscar", "Wilde", " ");
        Autor a7 = new Autor(7, "Adolfo", "Hitler", "Fuhrer");
        Autor a8 = new Autor(8, "Gabriel", "Garcia", "Marquez");
        Autor a9 = new Autor(9, "Mario", "Vargas", "LLosa");
        Autor a10 = new Autor(10, "Yukino", "kawabata", "Shun");
     

        Categoria c1 = new Categoria(1, "Policial");
        Categoria c2 = new Categoria(2, "Romántica");
        Categoria c3 = new Categoria(3, "Aventura");
        Categoria c4 = new Categoria(4, "Terror");
        Categoria c5 = new Categoria(5, "Ficción");
        Categoria c6 = new Categoria(6, "Ciencia");
        Categoria c7 = new Categoria(7, "Investigación");
        Categoria c8 = new Categoria(8, "Biográfica");
        Categoria c9 = new Categoria(9, "Infantil");
        Categoria c10 = new Categoria(10, "Erótica");

        Seccion s1 = new Seccion(1, "LIEE I", "A", 1);
        Seccion s2 = new Seccion(2, "LIEE I", "A", 2);
        Seccion s3 = new Seccion(3, "LIEE II", "B", 1);
        Seccion s4 = new Seccion(4, "LIEE II", "B", 2);
        Seccion s5 = new Seccion(5, "LIEE III", "C", 1);
        Seccion s6 = new Seccion(6, "LIEE III", "C", 2);
        Seccion s7 = new Seccion(7, "LIEE IV", "D", 1);
        Seccion s8 = new Seccion(8, "LIEE IV", "D", 2);
        Seccion s9 = new Seccion(9, "LIEE V", "E", 1);
        Seccion s10 = new Seccion(10, "LIEE V", "E", 2);

        

        int contID = 5;
        int contIDau =10;
        int contIDcat = 10;
        int contIDlibr = 3;
        int contIDprov = 3;
        int contPrest = 2;

        public FrmPrincipal()

        {
            InitializeComponent();

            lsUsuarios.Add(u1); lsUsuarios.Add(u2); lsUsuarios.Add(u3); lsUsuarios.Add(u4); lsUsuarios.Add(u5);
            lsAutores.Add(a1); lsAutores.Add(a2); lsAutores.Add(a3); lsAutores.Add(a4);lsAutores.Add(a5); lsAutores.Add(a6); lsAutores.Add(a7); lsAutores.Add(a8); lsAutores.Add(a9); lsAutores.Add(a10);
            LsCategorias.Add(c1); LsCategorias.Add(c2); LsCategorias.Add(c3); LsCategorias.Add(c4); LsCategorias.Add(c5); LsCategorias.Add(c6); LsCategorias.Add(c7); LsCategorias.Add(c8); LsCategorias.Add(c9); LsCategorias.Add(c10);
            LsSecciones.Add(s1); LsSecciones.Add(s2); LsSecciones.Add(s3); LsSecciones.Add(s4); LsSecciones.Add(s5); LsSecciones.Add(s6); LsSecciones.Add(s7); LsSecciones.Add(s8); LsSecciones.Add(s9); LsSecciones.Add(s10);

            List<Autor> lsL1 = new List<Autor>();
            lsL1.Add(a1);
            Libro l1 = new Libro(1, "Pulp - the book", new DateTime(1994, 12, 15), "987987-654dsf-44", "Biográfica",5 , Convert.ToDecimal(15.9), s1, lsL1);

            List<Autor> lsL2 = new List<Autor>();
            lsL1.Add(a2);
            Libro l2 = new Libro(2, "Pedro Páramo", new DateTime(1955, 05, 11), "asd-64a-II", "Ficción", 8, Convert.ToDecimal(10.5), s2, lsL2);
            
            List<Autor> lsL3 = new List<Autor>();
            lsL1.Add(a3);
            Libro l3 = new Libro(3, "Diez negritos", new DateTime(1939, 01, 27), "78956-AS5456", "Policial", 2, Convert.ToDecimal(3.50), s3, lsL3);

            List<Autor> lsL4 = new List<Autor>();
            lsL1.Add(a4);
            Libro l4 = new Libro(4, "Las Catilinarias", new DateTime(1980, 6, 01), "123-879-654", "Erótica", 15, Convert.ToDecimal(3.50), s4, lsL4);

            List<Autor> lsL5 = new List<Autor>();
            lsL1.Add(a5);
            Libro l5 = new Libro(5, "El resplandor", new DateTime(1980, 08, 27), "841sada-asd6", "Terror", 45, Convert.ToDecimal(3.50), s5, lsL5);

            List<Autor> lsL6 = new List<Autor>();
            lsL1.Add(a6);
            Libro l6 = new Libro(6, "Dorian Gray", new DateTime(1890, 01, 16), "cvb-654ert-4546", "Ficción", 9, Convert.ToDecimal(3.50), s6, lsL6);

            List<Autor> lsL7 = new List<Autor>();
            lsL1.Add(a3);
            Libro l7 = new Libro(7, "Mi lucha   ", new DateTime(1925, 10, 17), "666-666-666", "Biográfica", 666, Convert.ToDecimal(6.66), s7, lsL7);

            List<Autor> lsL8 = new List<Autor>();
            lsL1.Add(a8);
            Libro l8 = new Libro(8, "La hojarasca", new DateTime(1955, 02, 02), "45789l-987hg", "Ficción", 100, Convert.ToDecimal(3.50), s8, lsL8);

            List<Autor> lsL9 = new List<Autor>();
            lsL1.Add(a9);
            Libro l9 = new Libro(9, "La fiesta del chivo", new DateTime(2000, 06, 30), "fsyr3-89", "Ficción", 9, Convert.ToDecimal(25.5), s9, lsL9);

            List<Autor> lsL10 = new List<Autor>();
            lsL1.Add(a10);
            Libro l10 = new Libro(10, "El pais de nieve", new DateTime(1961, 09, 02), "fdkjdd-8gk99", "Biográfica", 15, Convert.ToDecimal(28.75), s10, lsL10);

            


            lsLibros.Add(l1); lsLibros.Add(l2); lsLibros.Add(l3); lsLibros.Add(l4); lsLibros.Add(l5); lsLibros.Add(l6); lsLibros.Add(l7); lsLibros.Add(l8); lsLibros.Add(l9); lsLibros.Add(l10);

            Proveedor p1 = new Proveedor(1, "ABYA-YALA", "Av. 12 de Octubre N2422 y Wilson", "(593-2) 3962800 ext. 2638", "editorial@abyayala.org", lsLibros);
            Proveedor p2 = new Proveedor(2, "Santillana", "Av. Victor Emilio Estrada 626 y Ficus", "04 461 1460 0", "comunicacionesecuador@santillana.com",lsLibros);
            Proveedor p3 = new Proveedor(3, "Océano", "Isla Santa Fe N43-184 y Río Coca", "02) 224-5800", "info@oceano.com.ec", lsLibros);
            lsProveedores.Add(p1); lsProveedores.Add(p2); lsProveedores.Add(p3);
        }




        public FrmPrincipal(List<Usuario> lsUsuarios)
        {
            InitializeComponent();
            this.lsUsuarios = lsUsuarios;
        }

        public FrmPrincipal(List<Autor> lsAutores)
        {
            InitializeComponent();
            this.lsAutores = lsAutores;
        }

        public FrmPrincipal(List<Categoria> lsCategorias)
        {
            InitializeComponent();
            this.lsCategorias = lsCategorias;
        }

        public FrmPrincipal(List<Libro> lsLibros)
        {
            InitializeComponent();
            this.lsLibros = lsLibros;
        }

        public FrmPrincipal(List<Proveedor> lsProveedores)
        {
            InitializeComponent();
            this.lsProveedores = lsProveedores;
        }

        public FrmPrincipal(List<Prestamo> lsPrestamos)
        {
            InitializeComponent();
            this.lsPrestamos = lsPrestamos;
            Console.WriteLine(  "llego");
            foreach (var iter in this.lsPrestamos)
            {
                Console.WriteLine(iter);
            }
        }


        private void btnLibro_Click(object sender, EventArgs e)
        {
            contIDlibr++;
            frmLibros frmL = new frmLibros(this.LsLibros,contIDlibr,this.LsAutores,this.LsCategorias,this.LsSecciones,this.LsProveedores);
            frmL.LsAutores = lsAutores;
            frmL.LsLibros = lsLibros;
            frmL.ContIDlibr = contIDlibr;
            frmL.LsCategorias = lsCategorias;
            frmL.LsSecciones = LsSecciones;
            frmL.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            contID++;
            frmRegistroNuevoUsuario frmRUN = new frmRegistroNuevoUsuario(this.lsUsuarios, contID);
            frmRUN.LsUsuarios = LsUsuarios;
            frmRUN.ContID = (contID);
            frmRUN.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("---");
            //foreach (var iter in lsPrestamos)
            //{
            //    Console.WriteLine(iter);
            //}

            this.Close();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            
            contIDau++;
            frmAutores frmA = new frmAutores(this.lsAutores, contIDau);
            frmA.LsAutores = lsAutores;
            frmA.ContID = contIDau;
            frmA.Show();


        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            contIDcat++;
            frmCategorias frmC = new frmCategorias(this.LsCategorias, contIDcat);
            frmC.LsCategorias = lsCategorias;
            frmC.ContID = contIDcat;
            frmC.Show();

        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            frmVerLibros frVL = new frmVerLibros(this.LsPrestamos,this.LsLibros);
            frVL.LsLibros = lsLibros;
            frVL.LsPrestamos = LsPrestamos;
            frVL.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            contIDprov++;
            
            frmProveedor frmProv = new frmProveedor(this.lsProveedores,contIDprov);
            frmProv.LsProveedores = lsProveedores;
            frmProv.ContID = (contIDprov);
            frmProv.ShowDialog();


        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            contPrest++;
            FrmPrestamo frmP = new FrmPrestamo(this.LsUsuarios, this.LsLibros,this.LsPrestamos);
            frmP.LsUsuarios = lsUsuarios;
            frmP.LsLibros = lsLibros;
            frmP.LsPrestamos = lsPrestamos;
            frmP.ContIDprest = contPrest;
            frmP.Show();

        }

        private void btnDevolución_Click(object sender, EventArgs e)
        {

            FrmDevolucion frmDevolucion = new FrmDevolucion(this.LsUsuarios,this.lsPrestamos);
            frmDevolucion.LsUsuarios = lsUsuarios;
            frmDevolucion.LsPrestamos = lsPrestamos;
            frmDevolucion.Show();
        }
    }
}
