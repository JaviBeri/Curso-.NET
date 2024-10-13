namespace ClasesLibros
{
    public class Literatura : Ficcion
    {
        public Literatura(string titulo, string autor, int paginas)
            : base(titulo, autor, paginas)
        {
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Libro de literatura: {Titulo}, de {Autor}, {Paginas} páginas");
        }
    }
}

