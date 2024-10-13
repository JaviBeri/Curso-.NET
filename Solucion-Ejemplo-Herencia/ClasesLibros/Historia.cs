namespace ClasesLibros
{
    public class Historia : NoFiccion
    {

        public Historia(string titulo, string autor, int paginas)
            : base(titulo, autor, paginas)
        {
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Libro de Historia: {Titulo}, de {Autor}, {Paginas} páginas");
        }
    }
}

