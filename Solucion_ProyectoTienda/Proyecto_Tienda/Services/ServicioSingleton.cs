namespace Proyecto_Tienda.Services
{
    public class ServicioSingleton
    {
        public Guid Id { get; private set; }

        public ServicioSingleton()
        {
            Id = Guid.NewGuid();
        }
    }
}

