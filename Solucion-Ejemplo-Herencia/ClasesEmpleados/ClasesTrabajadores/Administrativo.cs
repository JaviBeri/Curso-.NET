using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesEmpleados.ClasesAbstractas;
using ClasesEmpleados.ClasesAuxiliares;
using ClasesEmpleados.Interfaces;

namespace ClasesEmpleados.ClasesTrabajadores
{
    public class Administrativo : Trabajador, ITurnos, IPlanificacion, IFichajes
    {
        #region ITurnos
        public string Turno { get; set; }
        #endregion

        #region IPlanificacion
        public DateTime ProximaReunion { get; set; }
        #endregion

        #region IFichajes
        public List<Fichaje> Fichajes { get; set; }
        #endregion

        #region Constructores
        public Administrativo(string nombre, int años) : base(nombre, años)
        {
        }
        #endregion

        #region Sobreescritura de métodos
        public override string ToString()
        {
            return $"Administrativo: {Nombre} ({Años} años)";
        }
        #endregion
    }
}

