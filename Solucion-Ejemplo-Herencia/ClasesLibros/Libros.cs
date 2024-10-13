using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesLibros
{
    public abstract class Libros
    { 
    
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public int Paginas { get; set; }

        public Libros(string titulo, string autor, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
        }

        public abstract void MostrarInfo();
    }
}
