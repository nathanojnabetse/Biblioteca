using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Prestamo
    {
        //Atributos
        int idPrestamo;
        DateTime fechaPrestamo;
        DateTime fechaLimite;
        DateTime fechaDevolucion;
        decimal multa;
        Libro libroPrestado;

        Persona persona; 

        //Set y Gets
        public int IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaLimite { get => fechaLimite; set => fechaLimite = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public decimal Multa { get => multa; set => multa = value; }
        public Libro LibroPrestado { get => libroPrestado; set => libroPrestado = value; }
        public Persona Persona { get => persona; set => persona = value; }

        //Constructores
        public Prestamo()
        {
        }

        public Prestamo(int id, DateTime prestamo, DateTime limite, DateTime devolucion, decimal multa, Libro libro)
        {
            this.idPrestamo = id;
            this.fechaPrestamo = prestamo;
            this.fechaLimite = limite;
            this.fechaDevolucion = devolucion;
            this.multa = multa;
            this.libroPrestado = libro;
        }

        public Prestamo(int id, DateTime prestamo, DateTime limite, decimal multa)
        {
            this.idPrestamo = id;
            this.fechaPrestamo = prestamo;
            this.fechaLimite = limite;
            this.multa = multa;
        }

        public Prestamo(int id, DateTime prestamo, DateTime limite, decimal multa, Persona persona)
        {
            this.idPrestamo = id;
            this.fechaPrestamo = prestamo;
            this.fechaLimite = limite;
            this.multa = multa;
            this.persona = persona;
        }

        public Prestamo(int id, DateTime prestamo, DateTime limite, decimal multa, Libro libro,Persona persona)
        {
            this.idPrestamo = id;
            this.fechaPrestamo = prestamo;
            this.fechaLimite = limite;
            this.multa = multa;
            this.libroPrestado = libro;
            this.persona = persona;
        }

        //Override
        public override string ToString()
        {
            return   libroPrestado.Nombre +  "\t\t" + fechaLimite + "\t\t"+ persona;

        }
    }
}
