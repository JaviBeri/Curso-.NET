using ClasesEmpleados.ClasesAbstractas;
using ClasesEmpleados.Interfaces;

namespace ClasesEmpleados.ClasesGestores
{
    public class JefeProyecto : Gestor, IPlanificacion, IAparcamiento
    {
        public DateTime ProximaReunion { get; set; }
        public bool TienePlazaAparcamiento { get; set; }
        public string PlazaAparcamiento { get; set; }


        public JefeProyecto(string nombre, int años) : base(nombre, años)
        {
        }

        public override string ToString()
        {
            return $"Senior Management: {Nombre} ({Años} años)";
        }
    }
}
