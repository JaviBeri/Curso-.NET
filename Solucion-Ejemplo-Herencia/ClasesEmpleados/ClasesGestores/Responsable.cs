using ClasesEmpleados.ClasesAbstractas;
using ClasesEmpleados.Interfaces;

namespace ClasesEmpleados.ClasesGestores
{
    public class Responsable : Gestor, IPlanificacion
    {
        public DateTime ProximaReunion { get; set; }
        public Responsable(string nombre, int años) : base(nombre, años)
        {
        }

        public override string ToString()
        {
            return $"Responsable: {Nombre} ({Años} años)";
        }
    }
}
