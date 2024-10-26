namespace Proyecto_Tienda.Services;

public class ProductoRepositorioEnMemoriaGenerico : IRepository<Producto>
{

    private readonly List<Producto> _productos;

    public ProductoRepositorioEnMemoriaGenerico()
    {
        // Generador de productos con Bogus
        var faker = new Faker<Producto>()
            .RuleFor(p => p.Id, (f, p) => f.IndexFaker + 1)
            .RuleFor(p => p.Nombre, (f, p) => f.Commerce.ProductName())
            .RuleFor(p => p.Precio, (f, p) => decimal.Parse(f.Commerce.Price(1, 1000)));

        // Generar 1000 productos en memoria
        _productos = faker.Generate(1000);
    }
    public IEnumerable<Producto> GetAll()
    {
        foreach (var producto in _productos)
        {
            yield return producto;
        }
    }

    public IEnumerable<Producto> GetAllBogus()
    {
        // Configuramos un generador de datos para Producto
        var faker = new Faker<Producto>()
            .RuleFor(p => p.Id, f => f.IndexFaker + 1)
            .RuleFor(p => p.Nombre, f => f.Commerce.ProductName())
            .RuleFor(p => p.Precio, f => f.Random.Decimal(1, 1000));

        // Generamos mil productos y los devolvemos uno por uno
        for (int i = 0; i < 1000; i++)
        {
            var producto = faker.Generate();

            // Calculamos el precio con IVA usando el método de extensión
            var precioConIVA = producto.PrecioConIVA();

            producto.PrecioIva = precioConIVA;
            producto.Nombre = producto.FormatearNombreProducto();

            //producto.Precio = producto.Precio.PrecioConIVADecimal();

            // Opcional: Puedes asignar el valor a una nueva propiedad o solo usarlo donde sea necesario
            // Si decides tener una propiedad adicional en Producto para el precio con IVA, hazlo aquí.

            yield return producto;
        }
    }
}
