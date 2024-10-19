using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEmpleados.ClasesAbstractas
{
    public abstract class Trabajador : Empleado
    {
        public Trabajador(string nombre, int años) : base(nombre, años)
        {
        }
    }
}

