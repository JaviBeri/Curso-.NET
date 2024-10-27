using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Tienda.Controllers
{
    public class EjemploServicioScopedController : Controller
    {
        private readonly ServicioScoped _servicio1;
        private readonly ServicioScoped _servicio2;

        public EjemploServicioScopedController(ServicioScoped servicio1, ServicioScoped servicio2)
        {
            _servicio1 = servicio1;
            _servicio2 = servicio2;
        }

        public IActionResult Index()
        {
            // Los IDs serán iguales porque están dentro de la misma solicitud HTTP
            ViewBag.Id1 = _servicio1.Id;
            ViewBag.Id2 = _servicio2.Id;
            return View();
        }
    }
}
