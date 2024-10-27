using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace Proyecto_Tienda.Controllers
{
    public class EjemplosBootstrapController : Controller
    {
        public IActionResult BackgroundColors()
        {
            return View();
        }

        public IActionResult ContainersRows()
        {
            return View();
        }
        public IActionResult MediaBreakpoints()
        {
            return View();
        }
        public IActionResult GridSystem()
        {
            return View();
        }

        public IActionResult NavegacionBase()
        {
            return View();
        }

        public IActionResult NavegacionEjemplo()
        {
            return View();
        }
        public IActionResult EtiquetasEncabezado()
        {
            return View();
        }
        public IActionResult ColoresTexto()
        {
            return View();
        }

        public IActionResult ParrafosCitas()
        {
            return View();
        }
        public IActionResult ElementosEnLinea()
        {
            return View();
        }
        public IActionResult Listas()
        {
            return View();
        }
        public IActionResult Flotante()
        {
            return View();
        }
        public IActionResult FijosJustificados()
        {
            return View();
        }
        public IActionResult Botones()
        {
            return View();
        }
        public IActionResult Imagenes()
        {
            return View();
        }
        public IActionResult ImagenesFigure()
        {
            return View();
        }
        public IActionResult EjmploFontAwesome()
        {
            return View();
        }
        public IActionResult EjmploTarjetas()
        {
            return View();
        }
        public IActionResult EjmploTarjetasDinamico()
        {
            // ControladorAccionViewModel -> EjemplosBootstrapEjmploTarjetasDinamicoViewModel

            var vm = new EjemplosBootstrapEjmploTarjetasDinamicoViewModel
            {
                Tarjetas = new List<PropiedadesTarjeta>
                {
                    new PropiedadesTarjeta
                    {
                        Imagen = "/images/company-logo.png",
                        AltImagen = "Company Logo",
                        Titulo = "Nuevo Servicio Premium",
                        SubTitulo = "Optimización de Procesos Empresariales",
                        Texto = "Transforma la eficiencia operativa de tu empresa con nuestro servicio de optimización de procesos." +
                        "Simplifica tareas clave y aumenta la productividad en todas las áreas clave de tu negocio.",
                        Enlace = "#",
                        TextoEnlace = "Descubre más"
                    },
                    new PropiedadesTarjeta
                    {
                        Imagen = "/images/service-optimization.jpeg",
                        AltImagen = "Optimización de Procesos",
                        Titulo = "Optimización de Procesos",
                        SubTitulo = "Mejora la eficiencia operativa",
                        Texto = "Nuestro servicio está diseñado para identificar y mejorar áreas clave en la producción, " +
                        "permitiendo reducir costos y maximizar la eficiencia.",
                        Enlace = "#",
                        TextoEnlace = "Más Información"
                    },
                    new PropiedadesTarjeta
                    {
                        Imagen = "/images/service-cloud.jpeg",
                        AltImagen = "Servicios en la Nube",
                        Titulo = "Servicios en la Nube",
                        SubTitulo = "Soluciones escalables y seguras",
                        Texto = "Implementamos soluciones en la nube que permiten escalar tus aplicaciones de manera segura," +
                        " mejorando la agilidad de tu negocio.",
                        Enlace = "#",
                        TextoEnlace = "Más Información"
                    },
                                        new PropiedadesTarjeta
                    {
                        Imagen = "/images/service-consulting.jpeg",
                        AltImagen = "Consultoría Estratégica",
                        Titulo = "Consultoría Estratégica",
                        SubTitulo = "Asesoría para el crecimiento",
                        Texto = "Nuestros consultores trabajan contigo para desarrollar una estrategia " +
                        "empresarial que impulse tu crecimiento a largo plazo.",
                        Enlace = "#",
                        TextoEnlace = "Más Información"
                    },
                    new PropiedadesTarjeta
                    {
                        Imagen = "/images/service-analytics.jpeg",
                        AltImagen = "Análisis de Datos",
                        Titulo = "Análisis de Datos",
                        SubTitulo = "Decisiones basadas en datos",
                        Texto = "Ofrecemos soluciones avanzadas de análisis de datos que te permiten " +
                        "tomar decisiones informadas, basadas en información clave para tu empresa.",
                        Enlace = "#",
                        TextoEnlace = "Más Información"
                    },
                      new PropiedadesTarjeta
                    {
                        Imagen = "/images/service-cybersecurity.webp",
                        AltImagen = "Ciberseguridad",
                        Titulo = "Ciberseguridad",
                        SubTitulo = "Protege tus activos digitales",
                        Texto = "Nuestros servicios de ciberseguridad garantizan la protección " +
                        "de tus datos y la seguridad de tus operaciones en línea contra amenazas externas.",
                        Enlace = "#",
                        TextoEnlace = "Más Información"
                    },
                    new PropiedadesTarjeta
                    {
                        Imagen = "/images/service-cybersecurity.webp",
                        AltImagen = "Ciberseguridad",
                        Titulo = "Ciberseguridad",
                        SubTitulo = "Protege tus activos digitales",
                        Texto = "Nuestros servicios de ciberseguridad garantizan la protección " +
                        "de tus datos y la seguridad de tus operaciones en línea contra amenazas externas.",
                        Enlace = "#",
                        TextoEnlace = "Más Información"
                    }

                }
            };

            return View(vm);
        }

        public IActionResult EjmploFormulario()
        {
            return View();
        }
        public IActionResult EjmploEncuesta()
        {
            return View();
        }
        public IActionResult FormularioEnLinea()
        {
            return View();
        }
        public IActionResult FormularioMultiColumna()
        {
            return View();
        }
        public IActionResult FormularioValidaciones()
        {
            return View();
        }
        public IActionResult FormularioGrupos()
        {
            return View();
        }
        public IActionResult FormularioCheckRadioSelect()
        {
            return View();
        }
        public IActionResult EjemploJumbotron()
        {
            return View();
        }
        public IActionResult EjemploCarrusel()
        {
            return View();
        }
        public IActionResult EjemploCollapse()
        {
            return View();
        }
        public IActionResult EjemploAcordeon()
        {
            return View();
        }
    }
}