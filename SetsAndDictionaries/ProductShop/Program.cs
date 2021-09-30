using System;
using System.Collections.Generic;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new SortedDictionary<string, Dictionary<string, double>>();

            string data = Console.ReadLine();
            while (data.ToLower() != "revision")
            {
                string[] infoArr = data.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = infoArr[0];
                string productName = infoArr[1];
                double price = double.Parse(infoArr[2]);

                if (products.ContainsKey(shop))
                {
                    products[shop].Add(productName, price);
                }
                else
                {
                    products[shop] = new Dictionary<string, double>(); 
                    products[shop].Add(productName, price);
                }

                data = Console.ReadLine();
            }
            foreach (var shop in products)
            {

                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }

            }

        }
    }
}
