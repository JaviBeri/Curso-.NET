namespace Proyecto_Tienda.Services;

public interface IProductoRepositorio
{
    IEnumerable<Producto> ObtenerTodos();
    void Agregar(Producto producto);
}

