using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesLibros
{
    public abstract class NoFiccion : Libros
        
    {

        public NoFiccion(string titulo, string autor, int paginas)
            : base(titulo, autor, paginas)
        {
        }
    }
}

