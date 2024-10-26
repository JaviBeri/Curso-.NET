using Microsoft.AspNetCore.Mvc;
using Proyecto_Tienda.Models;
using Proyecto_Tienda.Services;
using System.Diagnostics;

namespace Proyecto_Tienda.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IEmailService _emailService;

    public HomeController(ILogger<HomeController> logger, IEmailService emailService)
    {
        _logger = logger;
        _emailService = emailService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        ViewBag.Message = "�Gracias por tu inter�s en nuestra tienda!";
        ViewBag.Fecha = DateTime.Now;
        ViewBag.Email = "pedidos@mail.com";

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
