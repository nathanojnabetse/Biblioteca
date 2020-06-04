using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Persona
    {
        //Atributos
        int idPersona;
        string nombre;
        string apellido;
        string genero;
        string direccion;
        string telefono;
        string correo;
        string cedula;

        //Set y gets
        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Cedula { get => cedula; set => cedula = value; }

        //Cosntructores
        public Persona()
        {
        }

        

        public Persona(int id, string nombre, string apellido, string genero, string direccion, string telefono, string correo, string cedula)
        {
            this.idPersona = id;
           
            this.nombre = nombre;
            this.apellido = apellido;
            this.genero = genero;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
            this.cedula = cedula;
        }

        //Override
        public override string ToString()
        {
            return idPersona +" "+ nombre + "// " + apellido + "//" + cedula;
        }
    }
}
