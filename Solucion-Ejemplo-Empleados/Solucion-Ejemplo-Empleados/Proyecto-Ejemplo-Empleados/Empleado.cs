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


        // Método para mostrar datos de los empleados
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre empleado: {Nombre}, Departamento: {Departamento}, Teléfono: {Telefono}, " +
                $"Número de empleado: {NumEmpleado}, IBAN: {IBAN}, NSS: {NSS}");
        }

        // Constructor de empleados sin parámetros
        public Empleado()
        {
            Nombre = "Sin nombre";
            Departamento = "Sin departamento";
            Telefono = "Sin teléfono";
            NumEmpleado = 0;
            NSS = "Sin NSS";
            IBAN = "Sin IBAN";
        }

        // Constructor de empleados con parámetros
        public Empleado(string nombre, string departamento, string telefono, int numempleado, string nss, string iban )
        {
            Nombre = nombre;
            Departamento = departamento;
            Telefono = telefono;
            NumEmpleado = numempleado;
            NSS = nss;
            IBAN = iban;
        }
    }
}
