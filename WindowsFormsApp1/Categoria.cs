using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Categoria
    {
        //Atributos
        int idCategoria;
        string nombreCategoria;
      

        public Categoria(int v, string text)
        {
            
            this.idCategoria = v;
            this.nombreCategoria = text;
        }

        public Categoria()
        {


        }
        //Set y Get
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }

        //Override
        public override string ToString()
        {
            return nombreCategoria;
        }
    }
}
