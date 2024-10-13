
using Clases_Animales;
using ClasesEmpleados;
using ClasesLibros;

// Crear una serie de animales basados en las cases definidas en Animales
var animales = new List<Animal>
{
    new Retriever("Buddy", 5),
    new Terrier("Max", 3),
    new GatoDoméstico("Whiskers", 2),
    new Tigre("Tony", 7)
};

// Mostrar datos de animales con bucle foreach y Console.WriteLine
foreach (var animal in animales)
{
    Console.WriteLine($"Nombre: {animal.Nombre}, Edad: {animal.Edad}");
}

// Crear una lista de Empleados basados en las clases de puestos
var empleados = new List<Empleado>
{
    new Administrativo("John", 5),
    new Factory("Jane", 3),
    new MiddleMGMT("Jim", 2),
    new SeniorMGMT("Jill", 7)
};

// Mostrar datos de empleados con bucle foreach y método ToString
foreach (Empleado empleado in empleados)
{
    Console.WriteLine(empleado.ToString() );
}

// Crear una lista de libros según su temática
var libros = new List<Libros>
{
    new Literatura("The Great Gatsby", "F. Scott Fitzgerald", 246),
    new Historia("The Da Vinci Code", "Dan Brown", 318),
    new Ciencia("The Guns of August", "Barbara Tuchman", 188),
    new Popular("A Brief History of Time", "Stephen Hanking", 227),
};

// Mostrar datos de libros con bucle foreach y método DisplayInfo
foreach (Libros libro in libros)
{
    libro.MostrarInfo();
}