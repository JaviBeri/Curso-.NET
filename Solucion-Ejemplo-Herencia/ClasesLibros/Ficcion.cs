using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesLibros
{
    public abstract class Ficcion : Libros
    {

        public Ficcion(string titulo, string autor, int paginas)
            : base(titulo, autor, paginas)
        {
        }
    }
}
