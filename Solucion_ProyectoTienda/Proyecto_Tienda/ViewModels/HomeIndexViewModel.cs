namespace Proyecto_Tienda.ViewModels
{
    public class PropiedadesOpciones
    {
        public string NombreControlador { get; set; }
        public string NombreAccion { get; set; }
        public string TextoOpcion { get; set; }
    }

    public class HomeIndexViewModel
    {
        public List<PropiedadesOpciones> Opciones { get; set; }

    }
}

