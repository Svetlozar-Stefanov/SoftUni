using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            Array.Sort(books);
            this.books = books.ToList();
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;

            private int index;

            public LibraryIterator(IEnumerable<Book> books)
            {
                Reset();
                this.books = books.ToList();
            }
            public Book Current => books[index];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                return ++index < books.Count;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
