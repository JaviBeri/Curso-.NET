namespace Proyecto_Tienda.Controllers;

public class EjemplosServicioTransitorioController : Controller
{
    private readonly ServicioTransitorio _servicio1;
    private readonly ServicioTransitorio _servicio2;

    public EjemplosServicioTransitorioController(ServicioTransitorio servicio1, ServicioTransitorio servicio2)
    {
        _servicio1 = servicio1;
        _servicio2 = servicio2;
    }

    public IActionResult Index()
    {
        // Los IDs serán diferentes porque son dos instancias distintas
        ViewBag.Id1 = _servicio1.Id;
        ViewBag.Id2 = _servicio2.Id;
        return View();
    }
}
