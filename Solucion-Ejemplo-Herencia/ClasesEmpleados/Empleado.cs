using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEmpleados.ClasesAbstractas
{
    public abstract class Empleado
    {

        // Propiedad Nombre
        public string Nombre { get; set; }

        // Propiedad Años en la empresa
        public int Años { get; set; }

        public int EmpresaId
        {
            set; get;
        }

        public int Id
        {
            get; set;
        }

        // Constructor que recibe el nombre y los años
        public Empleado(string nombre, int años)
        {
            Nombre = nombre;
            Años = años;
        }
    }
}