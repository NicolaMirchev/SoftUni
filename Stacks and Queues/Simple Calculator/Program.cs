using System;
using System.Collections;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack stack = new Stack();

            for (int i = 0; i < input.Length; i++)            
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    int endingIndex = i;
                    int startingIndex = (int)stack.Pop();
                    string result = input.Substring(startingIndex, endingIndex - startingIndex + 1);

                    Console.WriteLine(result);
                }


            }
        }
    }
}
