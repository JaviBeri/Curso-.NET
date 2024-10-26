using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Tienda.Controllers
{
    public class ProductosRepositorioController : Controller
    {

        private readonly IRepository<Producto> _productoRepositorio;

        public ProductosRepositorioController(IRepository<Producto> productoRepositorio)
        {
            _productoRepositorio = productoRepositorio;
        }

        public IActionResult Index()
        {
            var productos = _productoRepositorio.GetAllBogus();
            return View(productos);
        }
    }
}