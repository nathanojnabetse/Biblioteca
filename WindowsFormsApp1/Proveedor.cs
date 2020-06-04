using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Proveedor
    {
        //Atributos
        int idProveedor;
        string nombreProv;
        string direccion;
        string telefono;
        string correo;
        List<Libro> librosVenta;

        //Set y Gets
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string NombreProv { get => nombreProv; set => nombreProv = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public List<Libro> LibrosVenta { get => librosVenta; set => librosVenta = value; }

        //contructores
        public Proveedor()
        {
        }

        public Proveedor(int id, string nombre, string direccion, string telefono, string correo, List<Libro> libros)
        {
            this.idProveedor = id;
            this.nombreProv = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
            this.librosVenta = libros;
        }

        public Proveedor(int id, string nombre, string direccion, string telefono, string correo)
        {
            this.idProveedor = id;
            this.nombreProv = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
       
        }

        //Override
        public override string ToString()
        {
            return nombreProv;
        }
    }
}
