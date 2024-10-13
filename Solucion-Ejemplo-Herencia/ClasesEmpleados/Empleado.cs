using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEmpleados
{
    public class Empleado
    {

        // Propiedad Nombre
        public string Nombre { get; set; }

        // Propiedad Años en la empresa
        public int Años { get; set; }

        // Constructor que recibe el nombre y los años
        public Empleado(string nombre, int años)
        {
            Nombre = nombre;
            Años = años;
        }
    }
}
