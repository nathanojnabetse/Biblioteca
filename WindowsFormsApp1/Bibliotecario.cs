using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Bibliotecario:Persona
    {
        //Atributos
        int numeroHoras;

        //Set y Gets
        public int NumeroHoras { get => numeroHoras; set => numeroHoras = value; }

        //Constructores 
        public Bibliotecario()
        {
        }

        public Bibliotecario(int id, string nombre, string apellido, string genero, string direccion, string telefono, string correo, string cedula, int horas)
            : base(id, nombre, apellido, genero, direccion, telefono, correo, cedula)
        {
            this.numeroHoras = horas;
        }

        public override string ToString()
        {
            return "NOMBRE: " + Nombre + "   APELLIDO: " + Apellido + "   HORAS DE TRABAJO: " + numeroHoras;
        }
    }
}
