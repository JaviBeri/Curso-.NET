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
            Pedro.NumEmpleado = 1234;
            Pedro.IBAN = "63754237289";
            Pedro.NSS = "9873438635";

            Pedro.MostrarDatos();
                
            Empleado Maria = new Empleado();

            Maria.Nombre = "Maria";
            Maria.Departamento = "Desarrollo Apps";
            Maria.Telefono = "222222222";
            Maria.NumEmpleado = 6789;
            Maria.IBAN = "12987863532";
            Maria.NSS = "5463882526";

            Maria.MostrarDatos();

            Empleado Juan = new Empleado();

            Juan.Nombre = "Juan";
            Juan.Departamento = "Recursos Humanos";
            Juan.Telefono = "444444444";
            Juan.NumEmpleado = 4321;
            Juan.IBAN = "98353747698";
            Juan.NSS = "3984534732";

            Juan.MostrarDatos();

            Empleado Javier = new Empleado();

            Javier.Nombre = "Javier";
            Javier.Departamento = "Soporte Herramientas";
            Javier.Telefono = "888888888";
            Javier.NumEmpleado = 4567;
            Javier.IBAN = "926364378465";
            Javier.NSS = "256145241";

            Javier.MostrarDatos();

        }
    }
}
