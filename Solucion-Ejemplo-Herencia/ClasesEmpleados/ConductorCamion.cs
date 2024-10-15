using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesEmpleados.ClasesAbstractas;
using ClasesEmpleados.Interfaces;

namespace ClasesEmpleados.ClasesTrabajadores
{
    public class ConductorCamion : Trabajador, IAparcamiento
    {
        public bool TienePlazaAparcamiento { get; set; }
        public string PlazaAparcamiento { get; set; }
        public ConductorCamion(string nombre, int años) : base(nombre, años)
        {
        }
    }
}