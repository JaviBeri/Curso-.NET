namespace Proyecto_Tienda.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        public string Categoria { get; set; }

        [Range(0.01, 10000.00, ErrorMessage = "El precio debe estar entre 0.01 y 10,000")]
        public decimal Precio { get; set; }
        public decimal PrecioIva { get; set; }

        public DateTime FechaAgregado { get; set; }


        public Producto(int id, string nombre, string categoria, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }
        public Producto()
        {

        }
    }
}
