using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuevo_Ejemplo_Clases
{
    internal class Empleado
    {
        public string Nombre { get; set; }
       
        public string Departamento { get; set; }
        
        public string Telefono { get; set; }
        
        public int NumEmpleado { get; set; }

        public string NSS { get; set; }

        public string IBAN { get; set; }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre empleado: {Nombre}, Departamento: {Departamento}, Teléfono: {Telefono}, " +
                $"Número de empleado: {NumEmpleado}, IBAN: {IBAN}, NSS: {NSS}");
        }

    }
}
