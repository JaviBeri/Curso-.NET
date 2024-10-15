using ClasesEmpleados.ClasesAbstractas;
using ClasesEmpleados.ClasesAuxiliares;
using ClasesEmpleados.Interfaces;

namespace ClasesEmpleados.ClasesTrabajadores
{
    public class Factoria : Trabajador, ITurnos, IFichajes
    {

        #region IFichajes
        public List<Fichaje> Fichajes { get; set; }
        #endregion

        #region ITurnos
        public string Turno { get; set; }
        #endregion

        #region Constructores
        public Factoria(string nombre, int años) : base(nombre, años)
        {
        }
        #endregion

        #region Sobreescritura de metodos
        public override string ToString()
        {
            return $"Factoria: {Nombre} ({Años} años)";
        }
        #endregion
    }
}