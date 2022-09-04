using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DataSource
{
    public static class BooksProvider
    {
        public static IEnumerable<Book> GetBooks()
        {
            IEnumerable<Book> books = new Book[]
            {
                new Book{ Author = "J.K Rowling", Name = "Harry Potter", PublishDate = "1995-02-02", Genre = "Magic" },
                new Book{ Author = "Dan Brown", Name = "Angels and Demons", PublishDate = "2004-05-09", Genre = "Thriller"},
                new Book{Author = "Aghori", Name = "Aghori baba", PublishDate = "2020-02-03", Genre = "SciFi"}
            };

            return books;
        }
    }
}
