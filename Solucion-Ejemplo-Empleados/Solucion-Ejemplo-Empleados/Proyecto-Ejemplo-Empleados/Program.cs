using Nuevo_Ejemplo_Clases;

// Crear la variable que almacenará la lista de empleados
List<Empleado> listaEmpleados = new List<Empleado>();



// Crear empleado mediante inicialización de propiedades
Empleado Pedro = new Empleado();

Pedro.Nombre = "Pedro";
Pedro.Departamento = "IT";
Pedro.Telefono = "666666666";
Pedro.NumEmpleado = 1234;
Pedro.IBAN = "63754237289";
Pedro.NSS = "9873438635";

// Añadir empleado a la lista
listaEmpleados.Add(Pedro);

// Crear empleado mediante inicialización de propiedades en la misma línea
Empleado Maria = new Empleado()
{
    Nombre = "Maria",
    Departamento = "Desarrollo Apps",
    Telefono = "222222222",
    NumEmpleado = 6789,
    IBAN = "12987863532",
    NSS = "5463882526"
};
// Añadir empleado a la lista
listaEmpleados.Add(Maria);

// Crear empleados mediante constructor
Empleado Juan = new Empleado("juan", "Recursos Humanos", "444444444", 4321, "987654987", "932165721");
// Añadir empleado a la lista
listaEmpleados.Add(Juan);

Empleado Javier = new Empleado("Javier", "Soporte Herramientas", "888888888", 4567, "926364378465", "256145241"); ;
// Añadir empleado a la lista
listaEmpleados.Add(Javier);

// Mostrar los datos de los empleados de la lista
foreach (Empleado empleado in listaEmpleados)
{
    empleado.MostrarDatos();
}