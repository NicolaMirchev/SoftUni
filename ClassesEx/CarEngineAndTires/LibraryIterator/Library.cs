using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
   public class Library : IEnumerable<Book>
    {

        public Library()
        {
            books = new List<Book>();
        }
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }
        private List<Book> books { get; set; }

        public void AddBook(string name, List<string> authors, int year)
        {
            books.Add(new Book(name, authors, year));            
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        class LibraryIterator : IEnumerator<Book>
        {
            public LibraryIterator(List<Book> books)
            {
                this.books = books;
            }
            private List<Book> books;

            private int CurrentIndex;
            public Book Current => books[CurrentIndex];

            object IEnumerator.Current => Current;


            public bool MoveNext()
            {
                CurrentIndex++;
                return CurrentIndex < books.Count;
            }

            public void Reset()
            {
                CurrentIndex = -1;
            }
            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
    }
}
