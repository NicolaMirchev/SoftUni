using System;

namespace Animals
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            var cat = new Cat("Ciska", "Wiskas");

            Console.WriteLine(cat.ExplainSelf());
        }
    }
}
