using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowelss = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] consonantss = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            var vowels = new Queue<char>(vowelss);
            var consonants = new Stack<char>(consonantss);

            List<char> allCollectedLetters = new List<char>();

            while (consonants.Count > 0)
            {
                char currentVowel = vowels.Peek();
                vowels.Enqueue(vowels.Dequeue());

                char currentConsonant = consonants.Pop();

                if (!allCollectedLetters.Contains(currentVowel))
                {
                    allCollectedLetters.Add(currentVowel);
                }
                allCollectedLetters.Add(currentConsonant);
            }

            var wordsToPrint = new List<string>();
            int pearCounter = 0;
            int flourCounter = 0;
            int porkCounter = 0;
            int oliveCounter = 0;

            for (int i = 0; i < allCollectedLetters.Count; i++)
            {
                if ("pear".Contains(allCollectedLetters[i]))
                {
                    pearCounter++;
                }
                if ("flour".Contains(allCollectedLetters[i]))
                {
                    flourCounter++;
                }
                if ("pork".Contains(allCollectedLetters[i]))
                {
                    porkCounter++;
                }
                if ("olive".Contains(allCollectedLetters[i]))
                {
                    oliveCounter++;
                }

            }
            var outPut = new List<string>();
            if (pearCounter >= 4)
            {
                outPut.Add("pear");
            }
            if (flourCounter >= 5)
            {
                outPut.Add("flour");
            }
            if (porkCounter >= 4)
            {
                outPut.Add("pork");
            }
            if (oliveCounter >= 5)
            {
                outPut.Add("olive");
            }

            Console.WriteLine($"Words found: {outPut.Count}");
            foreach (var item in outPut)
            {
                Console.WriteLine(item);
            }
        }
    }
}
