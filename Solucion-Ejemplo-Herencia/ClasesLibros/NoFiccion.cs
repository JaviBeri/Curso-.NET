using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesLibros
{
    public abstract class NonFiction : Book
    {
        public NonFiction(string title, string author, int pages)
            : base(title, author, pages)
        {
        }
    }
}
