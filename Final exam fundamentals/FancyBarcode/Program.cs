using System;
using System.Text.RegularExpressions;

namespace FancyBarcode
{
    class Program
    {
        static void Main(string[] args)
        {



            int barcodesNum = int.Parse(Console.ReadLine());
            string pattern = @"\@\#+[A-Z](?:[a-z]|[\d]|[A-Z])(?:[a-z]|[\d]|[A-Z])(?:[a-z]|[\d]|[A-Z])(?:[a-z]|[\d]|[A-Z])+[A-Z]\@\#+";

            var regex = new Regex(pattern);

            for (int i = 0; i < barcodesNum; i++)
            {
                string text = Console.ReadLine();

                if (regex.IsMatch(text))
                {
                    string group = null;

                    for (int j = 0; j < text.Length; j++)
                    {
                        if (char.IsDigit(text[j]))
                        {
                            group += text[j];
                        }
                    }

                    if (group == null)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {group}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

        }
    }
}
