using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDeNotas
{
    public class Nota
    {
        //Clase muy simple, solo tiene los tres atributos que debe tener una nota, getters y setters y constructores.
        private DateTime fecha;
        private String autor;
        private String descripcion;

        public Nota()
        {
        }

        public Nota(DateTime fecha, string autor, string descripcion)
        {
            this.Fecha = fecha;
            this.Autor = autor;
            this.Descripcion = descripcion;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
