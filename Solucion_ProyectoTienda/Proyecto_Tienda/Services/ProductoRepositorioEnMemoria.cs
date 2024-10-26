
namespace Proyecto_Tienda.Services;

public class ProductoRepositorioEnMemoria : IProductoRepositorio
{
    private List<Producto> _productos = new List<Producto>();

    public ProductoRepositorioEnMemoria()
    {
        // Generador de productos con Bogus
        var faker = new Faker<Producto>()
            .RuleFor(p => p.Id, (f, p) => f.IndexFaker + 1)
            .RuleFor(p => p.Nombre, (f, p) => f.Commerce.ProductName())
            .RuleFor(p => p.Categoria, (f, p) => f.Commerce.Categories(1).First())
            .RuleFor(p => p.Precio, (f, p) => decimal.Parse(f.Commerce.Price(1, 1000)))
            .RuleFor(p => p.PrecioIva, (f, p) => p.Precio * 1.21m)  // Suponiendo un IVA del 21%
            .RuleFor(p => p.FechaAgregado, (f, p) => DateTime.Now);

        // Generar 1000 productos en memoria
        _productos = faker.Generate(1000);
    }


    public IEnumerable<Producto> ObtenerTodos()
    {
        return _productos;
    }

    public void Agregar(Producto producto)
    {
        producto.Id = _productos.Max(p => p.Id) + 1;
        producto.FechaAgregado = DateTime.Now;
        _productos.Add(producto);
    }
}
