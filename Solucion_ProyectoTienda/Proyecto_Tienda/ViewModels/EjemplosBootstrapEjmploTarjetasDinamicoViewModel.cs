namespace Proyecto_Tienda.ViewModels
{
    public class EjemplosBootstrapEjmploTarjetasDinamicoViewModel
    {
        public List<PropiedadesTarjeta> Tarjetas { get; set; }

    }

    public class PropiedadesTarjeta
    {
        public string Imagen { get; set; }
        public string AltImagen { get; set; }
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Texto { get; set; }
        public string Enlace { get; set; }

        public string TextoEnlace { get; set; }
    }
}

