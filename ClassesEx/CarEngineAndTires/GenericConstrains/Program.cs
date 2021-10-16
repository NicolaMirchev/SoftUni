using System;

namespace GenericScale
{
   public class StartUp
    {
        static void Main(string[] args)
        {
          // var smth = new EqualityScale<int>(15, 15);
          //
          // Console.WriteLine(smth.AreEqual());

            string first = "first";
            string second = "first";
            var refTypeData = new EqualityScale<string>(first, second);

            Console.WriteLine(refTypeData.AreEqual());
        }
    }
}
