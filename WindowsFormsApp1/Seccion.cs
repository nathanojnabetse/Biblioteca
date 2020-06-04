using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Seccion
    {
        //Atributos
        int idSeccion;
        string nombre;
        string estanteria;
        int fila;

        //Set y Gets
        public int IdSeccion { get => idSeccion; set => idSeccion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Estanteria { get => estanteria; set => estanteria = value; }
        public int Fila { get => fila; set => fila = value; }

        //Constructores
        public Seccion()
        {
        }

        public Seccion(int id, string nombre, string estanteria, int fila)
        {
            this.idSeccion = id;
            this.nombre = nombre;
            this.estanteria = estanteria;
            this.fila = fila;
        }

        //Override 
        public override string ToString()
        {
            return "SECCION: " + nombre + "  ESTANTERIA: " + estanteria + "  FILA: " + fila;
        }
    }
}
