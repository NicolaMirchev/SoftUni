using System;
using System.Linq;

namespace CountUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
          

            Console.WriteLine(string.Join(Environment.NewLine, input.Where(word => char.IsUpper(word[0])).ToArray())); 
            

            
        }
    }
}
