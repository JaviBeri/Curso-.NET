namespace Proyecto_Tienda.Services;
public class ServicioTransitorio
{
    public Guid Id { get; private set; }

    public ServicioTransitorio()
    {
        Id = Guid.NewGuid();
    }
}

