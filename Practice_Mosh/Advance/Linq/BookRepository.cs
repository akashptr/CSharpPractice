using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Advance.Linq
{
    internal class BookRepository
    {
        public static IEnumerable<Book> GetBooks()
        {
            var books = new List<Book>();
            books.Add(new Book { Title = "C# Basic", Price = 10.2, PublishDate = new DateTime(2015, 05, 22) });
            books.Add(new Book { Title = "C# Intermediate", Price = 12, PublishDate = new DateTime(2016, 03, 14) });
            books.Add(new Book { Title = "C# Advance", Price = 9.99, PublishDate = new DateTime(2017, 04, 17) });
            books.Add(new Book { Title = "C# Expert", Price = 23.45, PublishDate = new DateTime(2018, 11, 20) });
            books.Add(new Book { Title = "C# Advance", Price = 4.50, PublishDate = new DateTime(2017, 07, 26) });
            return books;
        } 
    }
}
