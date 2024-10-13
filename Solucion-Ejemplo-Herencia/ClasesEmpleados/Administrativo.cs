using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEmpleados
{
    public class Administrativo : Worker
    {
        public Administrativo(string nombre, int años) : base(nombre, años)
        {
        }
    }
}
