namespace Proyecto_Tienda.Utilidades
{
    public static class ProductoExtensions
    {
        private const decimal IVA = 0.21m; // 21% de IVA

        // Método de extensión para calcular el precio con IVA
        public static decimal PrecioConIVA(this Producto producto)
        {
            return producto.Precio + (producto.Precio * IVA);
        }

        public static decimal PrecioConIVADecimal(this decimal precio)
        {
            return precio + (precio * IVA);
        }

        // Método de extensión para capitalizar el nombre del producto
        public static string FormatearNombreProducto(this Producto producto)
        {
            if (string.IsNullOrEmpty(producto.Nombre))
                return producto.Nombre;

            // Separar el nombre en palabras y capitalizar la primera letra de cada palabra
            var palabras = producto.Nombre.Split(' ');
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length > 0)
                {
                    palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1).ToLower();
                }
            }
            return string.Join('-', palabras);
        }
        // Método de extensión para capitalizar el nombre del producto
        public static string FormatearNombreProductoCadena(this string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
                return nombre;

            // Separar el nombre en palabras y capitalizar la primera letra de cada palabra
            var palabras = nombre.Split(' ');
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length > 0)
                {
                    palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1).ToLower();
                }
            }
            return string.Join('-', palabras);
        }
    }
}
