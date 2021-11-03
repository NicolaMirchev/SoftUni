using System;

namespace Cars
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            Seat seat = new Seat("model", "black");

        // Console.WriteLine(seat.Start()); 
        // Console.WriteLine(seat);
        //
        // Tesla tesla = new Tesla("black", "model 3", 2);
        // Console.WriteLine(tesla);
        // Console.WriteLine(tesla.Start());

            ICar car = new Tesla("Red", "Model X", 3);
            Console.WriteLine(car.Start());
        }
    }
}
