namespace Nuevo_Ejemplo_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Crear las instancias de los empleados

            Empleado Pedro = new Empleado();

            Pedro.Nombre = "Pedro";
            Pedro.Departamento = "IT";
            Pedro.Telefono = "666666666";
                
            Empleado Maria = new Empleado();

            Maria.Nombre = "Maria";
            Maria.Departamento = "Desarrollo Apps";
            Maria.Telefono = "222222222";

            Empleado Juan = new Empleado();

            Juan.Nombre = "Juan";
            Juan.Departamento = "Recursos Humanos";
            Juan.Telefono = "444444444";

            Empleado Javier = new Empleado();

            Javier.Nombre = "Javier";
            Javier.Departamento = "Soporte Herramientas";
            Javier.Telefono = "888888888";

        }
    }
}
