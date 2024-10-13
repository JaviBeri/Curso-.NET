namespace ClasesLibros
{
    public class Ciencia : NoFiccion 
    {

        public Ciencia(string titulo, string autor, int paginas)
            : base(titulo, autor, paginas)
        { 
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Libro de ciencia {Titulo}, de {Autor}, {Paginas} páginas");
        }
    }
}

