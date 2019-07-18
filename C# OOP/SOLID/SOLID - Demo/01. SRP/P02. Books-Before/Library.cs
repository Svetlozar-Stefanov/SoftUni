using System.Collections.Generic;
using System.Linq;

namespace P02._Books_Before
{
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public Library(List<Book> books)
        {
            this.books = books;
        }


        public int GetBookIndex(string title)
        {
            return books.IndexOf(books.FirstOrDefault(b => b.Title == title));
        }
    }
}
