using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        public Box()
        {
            Values = new List<T>();
        }
        private List<T> Values { get; set; }

        public void Add(T item)
        {
            Values.Add(item);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var firstIndexSaved = Values[firstIndex];
            Values[firstIndex] = Values[secondIndex];
            Values[secondIndex] = firstIndexSaved;
            
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in Values)
            {
                sb.AppendLine($"System.String: {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }

}