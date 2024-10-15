namespace ClasesLibros
{
    public class Popular : Fiction
    {
        public Popular(string title, string author, int pages)
            : base(title, author, pages)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Popular Fiction Book: {Title}, by {Author}, {Pages} pages.");
        }
    }
}
