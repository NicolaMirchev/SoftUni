using System;
namespace SumOfCoins

{
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int targetSum = int.Parse(Console.ReadLine());

            var coins = ChooseCoins(input.ToList(), targetSum);
            Console.WriteLine($"Number of coins to take: {coins.Values.Sum()}");
            foreach (var coin in coins)
            {
                Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            var coinsCount = new Dictionary<int, int>();

            for (int i = coins.Count - 1; i >= 0 ; i--)
            {
                if (targetSum <= 0)
                {
                    break;
                }
                if (targetSum / coins[i] >= 1)
                {
                int currentCoins = targetSum / coins[i];
                coinsCount.Add(coins[i], currentCoins);
                }
                else
                {
                    continue;
                }

                targetSum = targetSum % coins[i];
            }

            if (targetSum > 0)
            {
                throw new InvalidOperationException("Error!");
            }
            else
            {
                return coinsCount;
            }

        }
    }
}