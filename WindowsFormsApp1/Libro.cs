using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Libro
    {
        //Atributos
        int idAutor;
        string nombre;
        DateTime fechaPublicacion;
        string isbn;
        string categoria;
        int numEjemplares;
        decimal precio;
        Seccion seccion;
        List<Autor> autores = new List<Autor>();


        //Set y Gets
        public int IdAutor { get => idAutor; set => idAutor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int NumEjemplares { get => numEjemplares; set => numEjemplares = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public List<Autor> Autores { get => autores; set => autores = value; }
        internal Seccion Seccion { get => seccion; set => seccion = value; }

        //Constructores
        public Libro()
        {
        }

        public Libro(int id, string nombre, DateTime fecha, string isbn, string categoria, int ejemplares, decimal precio, Seccion seccion, List<Autor> autores)
        {
            this.idAutor = id;
            this.nombre = nombre;
            this.fechaPublicacion = fecha;
            this.isbn = isbn;
            this.categoria = categoria;
            this.numEjemplares = ejemplares;
            this.precio = precio;
            this.seccion = seccion;
            this.autores = autores;
        }


        //Override
        public override string ToString()
        {
            return nombre + "\t\t" + numEjemplares + "\t\t" + fechaPublicacion.Year + "\t" + seccion;
        }
    
}
}
