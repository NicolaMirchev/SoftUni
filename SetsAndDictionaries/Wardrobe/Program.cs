using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var clotes = new Dictionary<string, Dictionary<string , int>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                string[] separateColor = input.Split(" -> ");
                string color = separateColor[0];

                string[] clothes = separateColor[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!clotes.ContainsKey(color)) 
                    {
                        clotes.Add(color, new Dictionary<string, int>());
                    }

                    if (!clotes[color].ContainsKey(clothes[j]))
                    {
                        clotes[color].Add(clothes[j], 0);  
                    }
                    clotes[color][clothes[j]]++;
                }

            }

            string[] whatToWear = Console.ReadLine().Split(' ');
            string serchingColor = whatToWear[0];
            string clothe= whatToWear[1];

            foreach (var colorr in clotes)
            {
                Console.WriteLine($"{colorr.Key} clothes:");
                foreach (var (vestido, number) in colorr.Value)
                {
                    if (vestido == clothe && colorr.Key == serchingColor)
                    {
                        Console.WriteLine($"* {vestido} - {number} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {vestido} - {number}");
                    }

                }

            }
        }
    }
}
