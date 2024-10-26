namespace Proyecto_Tienda.Services;
public interface IMonedaRepositorio
{
    IEnumerable<Moneda> ObtenerTodas();
    Moneda ObtenerPorId(int id);
}