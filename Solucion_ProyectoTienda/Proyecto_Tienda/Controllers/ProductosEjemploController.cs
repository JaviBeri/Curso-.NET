using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Tienda.Controllers
{
    public class ProductosEjemploController : Controller
    {
        private readonly IProductoRepositorio _productoRepositorio;

        public ProductosEjemploController(IProductoRepositorio productoRepositorio)
        {
            _productoRepositorio = productoRepositorio;
        }

        // Acción para mostrar la lista de productos
        public IActionResult Index()
        {
            var productos = _productoRepositorio.ObtenerTodos();
            return View(productos);
        }

        // Acción para mostrar el formulario de creación de productos
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        // Acción para manejar el POST del formulario de creación de productos
        [HttpPost]
        public IActionResult Crear(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _productoRepositorio.Agregar(producto);
                return RedirectToAction("Index");
            }
            return View(producto);
        }
    }

}
