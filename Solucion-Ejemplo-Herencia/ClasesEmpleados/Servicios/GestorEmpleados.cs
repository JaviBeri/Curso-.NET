using ClasesEmpleados.ClasesAbstractas;
using ClasesEmpleados.ClasesEmpresa;
using ClasesEmpleados.ClasesTrabajadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEmpleados.Servicios
{
    public class GestorEmpleados
    {
        // Lista de empresas
        public List<Empresa> empresas = new List<Empresa>();
        // Lista de empleados
        public List<Empleado> empleados = new List<Empleado>();

        private GestorEmpresas _gestorEmpresas = new GestorEmpresas();
        public void CrearEmpleado()
        {
            Console.Clear(); // Limpiar la consola antes de crear un empleado

            // Pedir los datos del empleado por pantalla
            Console.Write("Ingrese el nombre del empleado: ");
            var nombre = Console.ReadLine();

            Console.Write("Ingrese los años de experiencia: ");
            //if (!int.TryParse(Console.ReadLine(), out int años))
            //{
            //    Console.WriteLine("Error: Años de experiencia no válidos.");
            //    return;
            //}

            var añoscadena = Console.ReadLine();
            var años = 0;
            try
            {
                años = Convert.ToInt32(añoscadena);
            }
            catch (System.FormatException ex)
            {
                años = 0;
                //throw;
            }


            // Mostrar la lista de empresas para seleccionar una
            _gestorEmpresas.ListarEmpresas();
            Console.WriteLine();
            Console.Write("Ingrese el id de la empresa: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Error: ID de empresa no válido.");
                return;
            }

            var empleado = new Administrativo(nombre, años);
            var company = empresas.Find(c => c.Id == id);

            if (company != null)
            {
                empleado.EmpresaId = company.Id;
                empleados.Add(empleado);
                Console.WriteLine("Empleado creado exitosamente.");
            }
            else
            {
                Console.WriteLine("Error: Empresa no encontrada.");
            }

        }

        public void ListarEmpleados()
        {
            Console.Clear(); // Limpiar la consola antes de listar los empleados
            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados en la lista.");
            }
            else
            {
                Console.WriteLine("Listado de empleados");
                Console.WriteLine("====================");

                foreach (var empleado in empleados)
                {
                    Console.WriteLine($"Nombre: {empleado.Nombre}, Años: {empleado.Años}, Empresa: {empleado.EmpresaId}");
                }
            }
        }
    }
}