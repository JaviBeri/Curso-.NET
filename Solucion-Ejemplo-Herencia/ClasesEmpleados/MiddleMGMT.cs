using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEmpleados
{
    public class MiddleMGMT : Manager
    {
        public MiddleMGMT(string nombre, int años) : base(nombre, años)
        {
        }

        public override string ToString()
        {
            return $"Middle Management: {Nombre} ({Años} años)";
        }
    }
}
