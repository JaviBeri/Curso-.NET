using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEmpleados.ClasesAbstractas
{
    public abstract class Gestor : Empleado
    {
        public Gestor(string nombre, int años) : base(nombre, años)
        {
        }
    }
}

