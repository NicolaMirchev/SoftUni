using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    class Library : IEnumerable<Book>
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
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
