using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Tienda.Controllers
{
    public class ProductosController : Controller
    {

        // Lista genérica de productos
        private static List<Producto> productos = new List<Producto>
        {
            new Producto(1, "Laptop", "Electrónica", 1200m),
            new Producto(2, "Teléfono", "Electrónica", 800m),
            new Producto(3, "Silla", "Muebles", 150m),
            new Producto(4, "Mesa", "Muebles", 300m),
            new Producto(5, "iPhone", "Electrónica", 1650m),
            new Producto(6, "Bolígrafo", "Material Oficina", 22m),
            new Producto(7, "Lápiz", "Material Oficina", 20m)
        };


        public IActionResult ListaProductos()
        {
            return View(productos);
        }


        // Acción que obtiene un producto específico por su ID
        public IActionResult DetallesProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        // Acción que itera sobre la lista de productos y devuelve los nombres
        public IActionResult NombresProductos()
        {
            var nombres = productos.Select(p => p.Nombre).ToList();
            return View(nombres);
        }

    }
}