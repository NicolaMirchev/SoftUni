using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorProblem
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    class Author : Attribute
    {
        public Author(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
