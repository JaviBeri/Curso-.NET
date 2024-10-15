namespace ClasesLibros
{
    public class History : NonFiction
    {
        public History(string title, string author, int pages)
            : base(title, author, pages)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"History Book: {Title}, by {Author}, {Pages} pages.");
        }
    }
}