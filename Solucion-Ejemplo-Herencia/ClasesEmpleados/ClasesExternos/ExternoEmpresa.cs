using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesEmpleados.ClasesAbstractas;
using ClasesEmpleados.ClasesAuxiliares;
using ClasesEmpleados.Interfaces;

namespace ClasesEmpleados.ClasesExternos
{
    public class ExternoEnEmpresa : Externo, IPlanificacion, IFichajes
    {
        public List<Fichaje> Fichajes { get; set; }
        public string Departmento { get; set; }
        public DateTime ProximaReunion { get; set; }
        public ExternoEnEmpresa(string nombre, int años, string empresa, string departmento) : base(nombre, años, empresa)
        {
            Departmento = departmento;
        }
    }
}