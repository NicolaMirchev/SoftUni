namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
             DbInitializer.ResetDatabase(db);

            string command = Console.ReadLine();

            System.Console.WriteLine(GetBooksByAgeRestrictions(db, command));


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
