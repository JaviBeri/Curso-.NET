using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesEmpleados.ClasesAbstractas;
using ClasesEmpleados.Interfaces;

namespace ClasesEmpleados.ClasesExternos
{
    public class Subcontratista : Externo, IPlanificacion
    {
        public string Proyecto { get; set; }
        public DateTime ProximaReunion { get; set; }

        public Subcontratista(string nombre, int años, string empresa, string proyecto)
            : base(nombre, años, empresa)
        {
            Proyecto = proyecto;
        }
    }
}