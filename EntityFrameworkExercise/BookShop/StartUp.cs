namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            // DbInitializer.ResetDatabase(db);

            Console.WriteLine(GetGoldenBooks(db));


        }


        public static  string GetGoldenBooks(BookShopContext context)
        {

            var filteredBooks = context.Books.Where(b => b.EditionType == EditionType.Gold)
                                             .Where(b => b.Copies < 5000)
                                             .OrderBy(b => b)
                                             .ToArray();

            var sb = new StringBuilder();



            foreach (var item in filteredBooks)
            {
                context.Entry(item).Reference(b => b.Author).Load();
                Console.WriteLine(item.Author.FirstName);
            }

            return  sb.ToString();
        }
        public static string GetBooksByAgeRestrictions(BookShopContext context, string command)
        {
            AgeRestriction ageRestriction= new AgeRestriction();

            if (command.ToLower() == "minor")
            {
                ageRestriction = AgeRestriction.Minor;
            }
            else if (command.ToLower() == "teen")
            {
                ageRestriction = AgeRestriction.Teen;
            }
            else if (command.ToLower() == "adult")
            {
                ageRestriction = AgeRestriction.Adult;
            }

            var books = context.Books.Where(b => b.AgeRestriction == ageRestriction).Select(b => b.Title).OrderBy(t => t).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var item in books)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }

    }
}
