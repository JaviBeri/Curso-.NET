using ClasesEmpleados.ClasesEmpresas;
using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Formats.Asn1;

namespace ClasesEmpleados.Servicios
{
    public class GestorEmpresas
    {
        // Lista de empresas
        public List<Empresa> empresas = new List<Empresa>();

        private string archivo = @"C:\w\repos\240919-Programacion-Net\Archivos\companies.csv";




        #region Leer y escribir en CSV
        private void LeerCsv()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {

                PrepareHeaderForMatch = args => args.Header.ToLower(),
            };

            if (!File.Exists(archivo))
            {
                using (var writer = new StreamWriter(archivo))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    // Escribir cabeceras iniciales
                    csv.WriteField("name");
                    csv.WriteField("id");
                    csv.NextRecord();
                }
            }



            try
            {
                // Inicia un bloque 'using' que asegura que el objeto 'reader'
                // se disponga correctamente al finalizar el bloque.
                // 'StreamReader' es una clase que facilita la lectura de caracteres
                // desde un archivo de manera eficiente.
                // La variable 'archivo' contiene la ruta del archivo CSV
                // desde donde se leerán los datos.
                // El uso de 'using' asegura que el archivo se cierre correctamente
                // después de que se haya terminado de usar, liberando así los recursos.
                using (var reader = new StreamReader(archivo))
                // Inicia un bloque 'using' que asegura que el objeto 'csv'
                // se disponga correctamente al finalizar el bloque.
                // 'CsvReader' es una clase que facilita la lectura de datos en formato CSV.
                // El objeto 'reader' se utiliza para leer los datos del archivo CSV.
                // La variable 'config' contiene la configuración para el 'CsvReader',
                // incluyendo la cultura y cómo se deben manejar los encabezados.
                // El uso de 'using' asegura que el 'CsvReader' se cierre correctamente
                // después de que se haya terminado de usar, liberando así los recursos.
                using (var csv = new CsvReader(reader, config))

                {
                    var records = csv.GetRecords<Empresa>();
                    empresas.Clear();
                    foreach (var company in records)
                    {
                        empresas.Add(new Empresa(company.Nombre, company.Id));
                    }
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
        }

        private void EscribirCsv()
        {
            try
            {
                // Inicia un bloque 'using' que asegura que el objeto 'writer'
                // se disponga correctamente al finalizar el bloque.
                // En términos sencillos, "disponer" significa liberar o cerrar correctamente
                // los recursos que un objeto está utilizando,
                // como archivos o conexiones,
                // para evitar problemas como fugas de memoria.
                //
                // Crea un nuevo objeto 'StreamWriter' que se encargará de escribir
                // en el archivo especificado por la variable 'archivo'.
                // 'StreamWriter' es una clase que facilita la escritura de caracteres
                // en un archivo de manera eficiente.
                // La variable 'archivo' contiene la ruta del archivo CSV
                // donde se escribirán los datos.
                // El uso de 'using' asegura que el archivo se cierre correctamente
                // después de que se haya terminado de usar, liberando así los recursos.
                using (var writer = new StreamWriter(archivo))



                // Inicia un bloque 'using' que asegura que el objeto 'csv'
                // se disponga correctamente al finalizar el bloque.
                // En términos sencillos, "disponer" significa liberar o cerrar correctamente
                // los recursos que un objeto está utilizando, como archivos o conexiones,
                // para evitar problemas como fugas de memoria.
                using (var csv = new CsvWriter(
                    // Crea un nuevo objeto 'CsvWriter' que se encargará de escribir
                    // en el archivo especificado por el objeto 'writer'.
                    // 'CsvWriter' es una clase que facilita la escritura de datos en formato CSV.
                    writer,
                    // Configura el 'CsvWriter' con una nueva instancia de 'CsvConfiguration'.
                    new CsvConfiguration(
                        // Especifica la cultura que se utilizará para formatear los datos.
                        // 'CultureInfo.InvariantCulture' asegura que la configuración cultural
                        // sea independiente de la cultura del sistema, lo que es útil para
                        // mantener un formato consistente de los datos.
                        CultureInfo.InvariantCulture
                    )


                    //using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        // Opcional: configura si necesitas algunas opciones adicionales
                    }))
                {
                    // Escribir cabeceras manualmente en minúsculas
                    csv.WriteField("nombre");
                    csv.WriteField("id");
                    csv.NextRecord(); // Mueve a la siguiente línea después de escribir las cabeceras

                    // Escribir los registros de la lista de empresas
                    foreach (var company in empresas)
                    {
                        csv.WriteField(company.Nombre);
                        csv.WriteField(company.Id);
                        csv.NextRecord(); // Mueve a la siguiente línea después de escribir un registro
                    }
                }
                // Mensaje de confirmación de que la empresa se ha creado exitosamente
                Console.WriteLine("Empresa creada exitosamente.");
            }
            catch (System.UnauthorizedAccessException ex)
            {
                // Manejo de excepción en caso de que no se tenga permiso para escribir en el archivo
                Console.WriteLine("No se ha podido grabar la empresa en el csv");
                Console.WriteLine(ex.Message);
                //throw; // Comentado para evitar que la excepción se propague
            }
            catch (Exception ex)
            {
                // Manejo de cualquier otra excepción que pueda ocurrir
                Console.WriteLine(ex.Message);
                //throw; // Comentado para evitar que la excepción se propague
            }
        }
        #endregion

        public void CrearEmpresa()
        {

            /*
             
                    // Acciones realizadas al dar de alta una compañía:

                    // 1. Leer los datos del archivo CSV para actualizar la lista de empresas
                    LeerCsv();

                    // 2. Limpiar la consola antes de solicitar los datos de la nueva empresa
                    Console.Clear();

                    // 3. Generar un nuevo ID para la empresa, basado en el número actual de empresas en la lista
                    var id = companies.Count + 1;

                    // 4. Solicitar al usuario que ingrese el nombre de la nueva empresa
                    Console.Write("Ingrese el nombre de la empresa: ");
                    var nombre = Console.ReadLine();

                    // 5. Crear una nueva instancia de la clase Company con el nombre y el ID generados
                    var company = new Company(nombre, id);

                    // 6. Agregar la nueva empresa a la lista de empresas
                    companies.Add(company);

                    // 7. Escribir la lista actualizada de empresas en el archivo CSV
                    EscribirCsv();

             
             */


            // Leer los datos del archivo CSV para actualizar la lista de empresas
            LeerCsv();

            // Limpiar la consola antes de solicitar los datos de la nueva empresa
            Console.Clear();

            // Generar un nuevo ID para la empresa, basado en el número actual de empresas
            // en la lista
            var id = empresas.Count + 1;

            // Solicitar al usuario que ingrese el nombre de la nueva empresa
            Console.Write("Ingrese el nombre de la empresa: ");
            var nombre = Console.ReadLine();

            // Crear una nueva instancia de la clase Company con el nombre y el ID generados
            var empresa = new Empresa(nombre, id);

            // Agregar la nueva empresa a la lista de empresas
            empresas.Add(empresa);

            // Escribir la lista actualizada de empresas en el archivo CSV
            EscribirCsv();
        }

        public void ListarEmpresas()
        {
            LeerCsv();

            Console.Clear(); // Limpiar la consola antes de listar las empresas
            if (empresas.Count == 0)
            {
                Console.WriteLine("No hay empresas en la lista.");
            }
            else
            {
                Console.WriteLine("Listado de empresas");
                Console.WriteLine("===================");

                foreach (var company in empresas)
                {
                    Console.WriteLine(company.ToString());
                }
            }
        }

    }
}
