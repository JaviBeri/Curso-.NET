using ClasesEmpleados;
using ClasesEmpleados.ClasesAbstractas;
using ClasesEmpleados.ClasesEmpresa;
using ClasesEmpleados.ClasesTrabajadores;
using ClasesEmpleados.Servicios;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace EjemploHerenciaProyecto
{
    public class Menu
    {
        // Lista de empresas
        public List<Empresa> empresas = new List<Empresa>();
        // Lista de empleados
        public List<Empleado> empleados = new List<Empleado>();

        private GestorEmpresas _gestorEmpresas = new GestorEmpresas();
        private GestorEmpleados _gestorEmpleados = new GestorEmpleados();

        private string archivo = @"C:\Visual-GitHub\Archivos.csv";

        public void MostrarMenu()
        {
            while (true)
            {
                // Limpiar la consola y mostrar las opciones
                Console.Clear();
                MostrarOpciones();

                // Leer la opción ingresada
                var opcion = Console.ReadLine();

                // Validar la opción seleccionada
                switch (opcion)
                {
                    case "1":
                        CrearEmpresa();
                        break;
                    case "2":
                        ListarEmpresas();
                        break;
                    case "3":
                        CrearEmpleado();
                        break;
                    case "4":
                        ListarEmpleados();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                // Pausar la consola para mostrar el resultado y permitir al usuario ver el mensaje
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        }

        public void ListarEmpleados()
        {
            _gestorEmpleados.ListarEmpleados();
        }

        private void CrearEmpleado()
        {
            _gestorEmpleados.CrearEmpleado();
        }

        public void MostrarOpciones()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menú de opciones");
            Console.WriteLine("================");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1 - Crear Empresa");
            Console.WriteLine("2 - Listar Empresa");
            Console.WriteLine("3 - Agregar Empleado");
            Console.WriteLine("4 - Listar Empleados");
            Console.ResetColor();
        }

        public void CrearEmpresa()
        {
            _gestorEmpresas.CrearEmpresa();

        }



        public void ListarEmpresas()
        {
            _gestorEmpresas.ListarEmpresas();

        }
    }
}