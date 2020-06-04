using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Autor
    {
        //Atributos
        //Atributos
        int idAutor;
        string nombreAutor;
        string apellido1Autor;
        string apellido2Autor;

        //Set y Gets
        public int IdAutor { get => idAutor; set => idAutor = value; }
        public string NombreAutor { get => nombreAutor; set => nombreAutor = value; }
        public string Apellido1Autor { get => apellido1Autor; set => apellido1Autor = value; }
        public string Apellido2Autor { get => apellido2Autor; set => apellido2Autor = value; }

        //Constructores
        public Autor()
        {
        }

        public Autor(int id, string nombre, string apellido, string apellido2)
        {
            this.idAutor = id;
            this.nombreAutor = nombre;
            this.apellido1Autor = apellido;
            this.apellido2Autor = apellido2;
        }

        //override
        public override string ToString()
        {
            return   nombreAutor +" "+ apellido1Autor + " " + apellido2Autor;
        }
    }
}
