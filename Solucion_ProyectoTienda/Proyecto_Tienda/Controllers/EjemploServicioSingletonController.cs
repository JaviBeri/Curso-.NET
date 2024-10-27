using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Tienda.Controllers
{
    public class EjemploServicioSingletonController : Controller
    {
        private readonly ServicioSingleton _servicio1;
        private readonly ServicioSingleton _servicio2;

        public EjemploServicioSingletonController(ServicioSingleton servicio1, ServicioSingleton servicio2)
        {
            _servicio1 = servicio1;
            _servicio2 = servicio2;
        }

        public IActionResult Index()
        {
            // Los IDs serán iguales porque se reutiliza la misma instancia
            ViewBag.Id1 = _servicio1.Id;
            ViewBag.Id2 = _servicio2.Id;
            return View();
        }
    }
}
