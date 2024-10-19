using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesEmpleados.Interfaces
{
    public interface IAparcamiento
    {
        public bool TienePlazaAparcamiento { get; set; }

        public string PlazaAparcamiento { get; set; }
    }
}
