namespace ClasesLibros
{
    public class Popular : Ficcion
    {

        public Popular(string titulo, string autor, int paginas)
            : base(titulo, autor, paginas)
        {
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Libro Popular de Ficción: {Titulo}, de {Autor}, {Paginas} páginas");
        }
    }
}

