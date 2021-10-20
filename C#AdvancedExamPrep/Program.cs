using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ingredientsArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] freshArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            IDictionary<string, int> succesfulDishes = new Dictionary<string, int>();
            succesfulDishes.Add("Dipping sauce", 0);
            succesfulDishes.Add("Green salad", 0);
            succesfulDishes.Add("Chocolate cake", 0);
            succesfulDishes.Add("Lobster", 0);

            Queue<int> ingredients = new Queue<int>(ingredientsArr);
            Stack<int> freshness = new Stack<int>(freshArr);

            while (ingredients.Count > 0 && freshness.Count > 0)
            {
                if (ingredients.Peek() == 0)
                {
                    ingredients.Dequeue();
                }
                else
                {
                    int freshnessLevel = ingredients.Peek() * freshness.Pop();
                    if (freshnessLevel == 400)
                    {
                        succesfulDishes["Lobster"]++;
                        ingredients.Dequeue();
                    }
                    else if (freshnessLevel == 300)
                    {
                        succesfulDishes["Chocolate cake"]++;
                        ingredients.Dequeue();
                    }
                    else if (freshnessLevel == 250)
                    {
                        succesfulDishes["Green salad"]++;
                        ingredients.Dequeue();
                    }
                    else if (freshnessLevel == 150)
                    {
                        succesfulDishes["Dipping sauce"]++;
                        ingredients.Dequeue();
                    }
                    else
                    {
                        ingredients.Enqueue(ingredients.Dequeue() + 5);
                    }

                }

            }

            if (succesfulDishes.All(x => x.Value > 0))
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
                foreach (var dish in succesfulDishes.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"# {dish.Key}-->{dish.Value}");
                }

            }
            else
            {
                Console.WriteLine($"Ingredients left:{ingredients.Sum()}");

                foreach (var dish in succesfulDishes.Where(d => d.Value> 0).OrderBy(d=> d.Key))
                {
                    Console.WriteLine($"# {dish.Key}-->{dish.Value}");
                }
            }

        }
    }
}
