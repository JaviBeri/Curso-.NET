namespace Proyecto_Tienda.Services;
public class ServicioScoped
{
    public Guid Id { get; private set; }

    public ServicioScoped()
    {
        Id = Guid.NewGuid();
    }
}