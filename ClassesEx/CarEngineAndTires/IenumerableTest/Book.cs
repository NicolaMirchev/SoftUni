using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    class Book
    {

        public Book(string name, List<string> authors, int year)
        {
            Year = year;
            Name = name;
            Authors = authors;
        }
        public int Year { get; set; }

        public List<string> Authors { get; set; }

        public string Name { get; set; }
    }
}
