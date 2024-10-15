namespace ClasesLibros
{
    public class Science : NonFiction
    {
        public Science(string title, string author, int pages)
            : base(title, author, pages)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Science Book: {Title}, by {Author}, {Pages} pages.");
        }
    }
}

