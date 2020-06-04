using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Genero
    {
        //Atributos
        int idGenero;
        string nombreGenero;

        public Genero(int idGenero, string nombreGenero)
        {
            this.idGenero = idGenero;
            this.nombreGenero = nombreGenero;
        }

        //Set y Get
        public int IdGenero { get => idGenero; set => idGenero = value; }
        public string NombreGenero { get => nombreGenero; set => nombreGenero = value; }

        //Override
        public override string ToString()
        {
            return nombreGenero;
        }
    }
}
