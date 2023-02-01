namespace Practice_Mosh.Advance.Linq
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Linq Extension Methods
            var books = BookRepository.GetBooks();
            // Select or Project
            var prices = books.Select(b => b.Title);
            // Where
            var cheapBooks = books.Where(b => b.Price < 10).Select(b => b.Title);
            // Order-by
            var sortedBooks = books.OrderBy(b => b.Price);
            var descSortBooks = books.OrderByDescending(b => b.Price);
            // Single
            var oneBook = books.Single(b => b.Title == "C# Intermediate");
            // SingleOrDefault
            var singleBook = books.SingleOrDefault(b => b.Title == "ASP.NET Beginner");
            // First and Last
            var firstBook = books.First(b => b.Title == "C# Advance");
            var lastBook = books.Last(b => b.Title == "C# Advance");
            // Skip and Take
            var pagedBooks = books.Skip(2).Take(2);
            // Aggregate functions
            // Count
            var noOfBooks = books.Count();
            // Max and Min
            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            // Sum and Average
            var sum = books.Sum(b => b.Price);
            var avg = books.Average(b => b.Price);

            // Linq Query Operator
            var cheaperBooks = from b in books
                               where b.Price < 10
                               select b;
            foreach(var book in cheaperBooks)
                Console.WriteLine(book);
        }
    }
}
