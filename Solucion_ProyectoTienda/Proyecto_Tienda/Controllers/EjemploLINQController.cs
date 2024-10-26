using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Tienda.Controllers
{
    public class EjemploLINQController : Controller
    {
        public IActionResult EjemploNiveles()
        {

            string[] niveles = { "Basico", "Intermedio", "Avanzado" };
            var nc = niveles.Count();

            return View(nc);
        }

        public IActionResult EjemploNivelesSeisLetras()
        {

            string[] niveles = { "Inicial", "Basico", "Intermedio", "Avanzado", "SuperAvanzado" };
            var nc = niveles.Count();

            // Obtener los niveles que tienen maximo 6 letras
            // mediante foreach
            List<string> nivelesSeisLetras = new List<string>();
            foreach (var nivel in niveles)
            {
                if (nivel.Length <= 8)
                {
                    nivelesSeisLetras.Add(nivel);
                }
            }

            //// Obtener los niveles que tienen maximo 8 letras
            //// Con sintaxis de consulta
            IEnumerable<string> nivelesSeisLetrasLinq = from nivel in niveles
                                                        where nivel.Length <= 8
                                                        select nivel;


            // Obtener los niveles que tienen maximo 8 letras
            // Con sintaxis de métodos
            IEnumerable<string> nivelesSeisLetrasMetodos = niveles.Where(nivel => nivel.Length <= 8);


            return View(nivelesSeisLetrasLinq);
        }

        public IActionResult FiltrarProductos()
        {

            // Lista de productos disponibles
            Producto[] productos = {
            new Producto { Nombre = "Laptop", Precio = 1200m },
            new Producto { Nombre = "Teléfono", Precio = 800m },
            new Producto { Nombre = "Tablet", Precio = 400m },
            new Producto { Nombre = "Monitor", Precio = 250m },
            new Producto { Nombre = "Teclado", Precio = 50m },
            new Producto { Nombre = "Ratón", Precio = 25m },
            new Producto { Nombre = "Bolígrafo", Precio = 3m },
            new Producto { Nombre = "Lápiz", Precio = 2m },
        };


            decimal precioMinimo = 300m; // Definimos el precio mínimo para filtrar

            // Lista temporal para almacenar los productos filtrados
            var productosFiltrados = new List<Producto>();

            // Filtrar productos manualmente
            foreach (var producto in productos)
            {
                if (producto.Precio > precioMinimo)
                {
                    productosFiltrados.Add(producto);
                }
            }

            // Filtrar productos con LINQ sintaxis sql
            var productosFiltradosLinq = from producto in productos
                                         where producto.Precio > precioMinimo
                                         orderby producto.Precio descending
                                         select producto;


            // Filtrar productos con LINQ métodos
            var productosFiltradosMetodos = productos
                .Where(producto => producto.Precio > precioMinimo)
                .OrderByDescending(producto => producto.Precio);


            return View(productosFiltradosLinq);
        }



        public IActionResult FiltrarProductosBogus()
        {
            // Generador de productos con Bogus
            var faker = new Faker<Producto>()
                .RuleFor(p => p.Nombre, f => f.Commerce.ProductName()) // Generar nombres de productos
                .RuleFor(p => p.Precio, f => f.Random.Decimal(1, 2000)); // Generar precios entre 1 y 2000

            // Generamos 1000 productos aleatorios
            var productos = new List<Producto>();
            for (int i = 0; i < 1000; i++)
            {
                productos.Add(faker.Generate());
            }

            decimal precioMinimo = 1300m; // Definimos el precio mínimo para filtrar

            // Filtrar productos con LINQ (sintaxis SQL-like)
            var productosFiltradosLinq = (from producto in productos
                                          where producto.Precio > precioMinimo
                                          orderby producto.Precio descending
                                          select producto).Skip(100).Take(5);

            // Filtrar productos con LINQ (métodos de extensión)
            var productosFiltradosMetodos = productos
                .Where(producto => producto.Precio > precioMinimo)
                .OrderByDescending(producto => producto.Precio);

            return View(productosFiltradosLinq); // Puedes cambiar a productosFiltradosMetodos si prefieres
        }

        public IActionResult EjemploEmpleados()
        {
            List<Empleado> empleados = GenerarEmpleados(1000);

            // Filtrar empleados con sueldo mayor a 3000
            var empleadosSueldo = empleados.Where(e => e.Sueldo > 3000);

            return View(empleadosSueldo);
        }

        private static List<Empleado> GenerarEmpleados(int numeroEmpleados)
        {
            // Genera 100 empleados con Bogus
            var faker = new Faker<Empleado>()
                .RuleFor(e => e.Nombre, f => f.Person.FirstName)
                // apellido
                .RuleFor(e => e.Apellido, f => $"{f.Name.LastName()} {f.Name.LastName()}")
                .RuleFor(e => e.Edad, f => f.Random.Int(18, 65))
                .RuleFor(e => e.Sueldo, f => f.Random.Decimal(1000, 5000))
                .RuleFor(e => e.Departamento, f => f.PickRandom<Departamento>());
            // Genera 100 empleados
            var empleados = faker.Generate(numeroEmpleados);
            return empleados;
        }

        public IActionResult EjemploEmpleados2()
        {
            List<Empleado> empleados = GenerarEmpleados(1000);

            // El Departamento sea Desarrollo o Soporte
            // El apellido empiece por C
            // Devuelve el resultado en orden descendente por nombre
            IOrderedEnumerable<Empleado> empleadosFiltro = empleados
                .Where(e => e.Departamento == Departamento.Desarrollo || e.Departamento == Departamento.Soporte)
                .Where(e => e.Apellido.StartsWith("C"))
                .OrderByDescending(e => e.Nombre);

            // Ejecutar la consulta devolviendo una lista
            List<Empleado> empleadosLista = empleadosFiltro.ToList();


            return View(empleadosLista);
        }

        public IActionResult EjemploEmpleadosSubConsulta()
        {
            List<Empleado> empleados = GenerarEmpleados(1000);

            // Subconsulta
            // Ejemplo de subconsulta
            // Ejemplo de uso de la subconsulta para filtrar empleados cuyo último apellido empiece con "V"
            // Ejemplo 1: Empleado con apellido "García Vázquez" será incluido
            // Ejemplo 2: Empleado con apellido "López" no será incluido
            // Ejemplo 3: Empleado con apellido "Martínez Varela" será incluido

            //var empleadosFiltro = empleados.Where(e => e.Apellido.Split()
            //                                            .LastOrDefault().StartsWith("V"));

            // Filtramos la lista de empleados
            var empleadosFiltro = empleados
                .Where(e =>
                {
                    // Dividimos el apellido completo en palabras, separando por espacios
                    // Esto generará un array de cadenas con cada palabra en el apellido.
                    var apellidos = e.Apellido.Split();

                    // Obtenemos el último apellido o palabra del array. Si no hay palabras (por alguna razón),
                    // retornamos un valor nulo de manera segura.
                    var ultimoApellido = apellidos.LastOrDefault();

                    // Comprobamos si el último apellido no es nulo y comienza con la letra "V".
                    // Esto filtrará aquellos empleados cuyo último apellido empieza con "V".
                    return ultimoApellido != null && ultimoApellido.StartsWith("V");
                });



            // Ejecutar la consulta devolviendo una lista
            List<Empleado> empleadosLista = empleadosFiltro.ToList();


            return View(empleadosLista);
        }
        public IActionResult EjemploEmpleadosOperadoresReverse()
        {
            List<Empleado> empleados = GenerarEmpleados(1000);

            // Filtra empleados cuya edad sea menor o igual a 30
            var empleadosFiltrados = empleados.Where(e => e.Edad <= 30);

            // Crea un ViewModel con ambas listas
            var viewModel = new EmpleadosViewModel
            {
                EmpleadosOriginal = empleadosFiltrados, // Orden original
                EmpleadosInvertidos = empleadosFiltrados.Reverse() // Orden inverso
            };

            return View(viewModel);
        }

        public IActionResult EjemploEmpleadosOperadoresSkipTakeWhileReverse()
        {
            List<Empleado> empleados = GenerarEmpleados(1000);

            // Filtrar por edad menor o igual a 30
            var empleadosFiltrados = empleados.Where(e => e.Edad <= 30).OrderBy(e => e.Edad);

            // Skip: Omitir el primer empleado
            var empleadosSkip = empleadosFiltrados.Skip(10);

            // TakeWhile: Tomar empleados cuya edad sea menor o igual a 25
            var empleadosTakeWhile = empleadosFiltrados.TakeWhile(e => e.Edad <= 25);

            // Filtrar, ordenar y agrupar por departamento
            var empleadosFiltrarOrdenarAgrupar = empleadosFiltrados
                .OrderBy(e => e.Nombre)
                .GroupBy(e => e.Departamento);

            // Crear el ViewModel con todas las consultas
            var viewModel = new EmpleadosViewModel
            {
                EmpleadosOriginal = empleadosFiltrados,  // Orden original
                EmpleadosInvertidos = empleadosFiltrados.Reverse(),  // Orden inverso
                EmpleadosSkip = empleadosSkip,  // Resultado de Skip
                EmpleadosTakeWhile = empleadosTakeWhile,  // Resultado de TakeWhile
                EmpleadosFiltrarOrdenarAgrupar = empleadosFiltrarOrdenarAgrupar  // Filtrar/Ordenar/Agrupar
            };

            return View(viewModel);
        }


    }
}