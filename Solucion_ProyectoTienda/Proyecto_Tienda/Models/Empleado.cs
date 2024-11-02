namespace Proyecto_Tienda.Models
{
    public class Empleado
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public Departamento Departamento { get; set; }
        public int Edad { get; set; }
        public decimal Sueldo { get; set; }
    }
}
