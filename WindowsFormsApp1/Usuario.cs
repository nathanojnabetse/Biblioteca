using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Usuario:Persona
    {
        //Atributos
        List<Prestamo> prestamosLibros;

        //Set y Get
        public List<Prestamo> PrestamosLibros { get => prestamosLibros; set => prestamosLibros = value; }

        //Cosntructores
        public Usuario()
        {
        }


        public Usuario(int id, string nombre, string apellido, string genero, string direccion, string telefono, string correo, string cedula, List<Prestamo> prestamos)
            : base(id, nombre, apellido, genero, direccion, telefono, correo, cedula)
        {

            this.prestamosLibros = prestamos;
        }

        public Usuario( int id, string nombre, string apellido, string genero, string direccion, string telefono, string correo, string cedula) 
            : base( id, nombre, apellido, genero, direccion, telefono, correo, cedula)
        {
            
        }


 

        //Override
        public override string ToString()
        {
            return Nombre + "\t" + Apellido + "\t" + prestamosLibros;
        }
    }
}
