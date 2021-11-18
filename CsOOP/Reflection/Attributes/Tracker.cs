using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AuthorProblem
{
    class Tracker
    {

        public void PrintMethodsByAuthor()
        { 
            var assembly = typeof(StartUp);
            var methods = assembly.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);

            foreach (var method in methods)
            {
                if (method.CustomAttributes.Any(a => a.AttributeType == typeof(Author)))
                {

                    foreach (var atribute in atributes)
                    {

                    }

                }

            }
        
        }
    }
}
