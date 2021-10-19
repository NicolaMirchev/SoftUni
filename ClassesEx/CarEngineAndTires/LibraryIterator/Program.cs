using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var library = new Library();
            library.AddBook("name", new List<string>() { "author" }, 1995);
            library.AddBook("name2", new List<string>() { "nesshto" }, 1994);
            library.AddBook("name3", new List<string>() { "drug" }, 1993);

            foreach (var book in library)
            {
                Console.WriteLine($"{ book.Name}, {book.Year}");
            }

        }
    }
}
