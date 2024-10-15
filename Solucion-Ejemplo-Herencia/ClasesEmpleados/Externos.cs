using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesEmpleados.ClasesAbstractas
{
    public abstract class Externo : Empleado
    {
        public string Empresa { get; set; }
        public Externo(string nombre, int años, string empresa) : base(nombre, años)
        {
            Empresa = empresa;
        }
    }
}