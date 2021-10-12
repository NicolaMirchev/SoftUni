using System;
using System.Collections.Generic;

namespace MathQuestions
{
    class Program
    {
        static void Main(string[] args)
        { 
            var questions = new Dictionary<string, string>();

            var random = new Random();

            string input = Console.ReadLine();

            while (input != "End")
            {
                var question = new byte[16];


                random.NextBytes(question);

            }
        }
    }
}
